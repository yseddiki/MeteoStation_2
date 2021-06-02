using MeteoStation_2.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace MeteoStation_2
{

    public partial class Form1 : Form
    {
        User user;
        DB db = new DB();
        internal Forms.FormUser UserForm ;
        internal TabPage PageUser;
        internal Forms.FormGraph GraphForm;
        internal Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
        int cpt = 1 ;
        internal TabPage PageGraph;
        String DefaultCOM = "COM2";
        DataTable dt = new DataTable();
        bool bData_received = true;
        byte[] BufferS;
        List<Base> LBase = new List<Base>();
        List<byte> BufferF = new List<byte>();
        int maxId = 5;
        int count;
        public Form1()
        {
            InitializeComponent();
            IDCombobox();
            createGrid();
            initialSerialPort();

        }
        private void createGrid()
        {

            ///////////////////////////////
            ///CREATE GRID
            DataColumn dc = new DataColumn();
            dc = new DataColumn("ID", typeof(int));
            dt.Columns.Add(dc);
            dc = new DataColumn("Nbre Octet", typeof(int));
            dt.Columns.Add(dc);
            dc = new DataColumn("Type", typeof(int));
            dt.Columns.Add(dc);
            dc = new DataColumn("Data");
            dt.Columns.Add(dc);
            dc = new DataColumn("CheckSum", typeof(int));
            dt.Columns.Add(dc);
            dc = new DataColumn("Etat");
            dt.Columns.Add(dc);
            //////////////////////////////
            ////Liason de la datatable datagrid       
            for (int i = 0; i < maxId; i++)
            {
                dt.Rows.Add(i);
            }
            dt.Rows.Add(50);
            datagridMeteo.DataSource = dt;
            
        }
        private void initialSerialPort()
        {
            Serial.PortName = DefaultCOM;
            Serial.ReceivedBytesThreshold = 1;
            Serial.Handshake = Handshake.None;
            Serial.DtrEnable = false;
            Serial.RtsEnable = false;
            // Instatiate this class
            affichageConfigurations(false);
            // Begin communications
            timer1.Start();
            timer1.Enabled = false;
            Serial.Open();
            Serial.DataReceived += new SerialDataReceivedEventHandler(Serial_DataReceived);
        }
        private void Serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            ///////////////////////////////////////////////
            ////Cette méthode sert à recevoir les données bruts
            if (bData_received == true)
            {
                count = Serial.BytesToRead;
                BufferS = new byte[count];
                Serial.Read(BufferS, 0, count);
                bData_received = false;                
                AddtoBufferF();
            }
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            //cette fontion sauvegarde les paramètres entrés pour chaque ID dans un excel
            try
            {
                var filePath = "./../../Data.csv";
                using (StreamWriter writer = new StreamWriter(new FileStream(filePath, FileMode.Create, FileAccess.Write)))
                {
                    foreach (Base elem in LBase )
                    {
                        if (elem.isConvert)
                        {
                            writer.WriteLine(elem.id + "," + ((Mesure)elem).Minint + "," + ((Mesure)elem).Maxint+ "," + ((Mesure)elem).MinAlarm + "," + ((Mesure)elem).MaxAlarm);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btUpload_Click(object sender, EventArgs e)
        {
            //cette fonction charge les paramètres qui sont dans un fichiers csv
            try
            {
                var filePath = "./../../Data.csv";
                using (var reader = new StreamReader(filePath))
                {
                    List<string> listConfig = new List<string>();
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        foreach (Base elem in LBase)
                        {
                            if (elem.id == int.Parse(values[0]))
                            {
                                ((Mesure)elem).Minint= int.Parse(values[1]);
                                ((Mesure)elem).Maxint = int.Parse(values[2]);
                                ((Mesure)elem).MinAlarm = int.Parse(values[3]);
                                ((Mesure)elem).MaxAlarm = int.Parse(values[4]);
                                elem.isConvert = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddtoBufferF()
        {            
            ////Cette méthode sert à inserer les données dans la liste finale
            for (int index = 0; index < BufferS.Length; index++)
            {
                BufferF.Add(BufferS[index]);
            }
            AddTrame();
        }
        public bool checkframe()
        {
            ////////////////////////////////////////////////////////
            ////Cette méthode sert à  verifier le début d'une trame
            while (BufferF.Count > 14)
            {
                if (BufferF[0] == 85 && BufferF[1] == 170 && BufferF[2] == 85 && (BufferF[3] < 11 || BufferF[3] == 50))
                {
                    return true;
                }
                else
                {
                    BufferF.RemoveAt(0);
                }
            }
            return false;
        }
        private void InsertValueInDatagrid()
        {
            /////////////////////////////
            ///Cette méthode sert à inserer les valeurs dans le datagrid
            foreach (Base trame in LBase)
            {
                if (trame.id < 10)
                {
                    dt.Rows[(trame.id)].SetField(1, trame.cptOctet);
                    dt.Rows[(trame.id)].SetField(2, trame.Type);
                    if (trame.isConvert == false)
                    {
                        dt.Rows[(trame.id)].SetField(3, (double)trame.data);
                    }
                    else
                    {
                        dt.Rows[(trame.id)].SetField(3,((Mesure)trame).getDataConvert());
                    }
                    dt.Rows[(trame.id)].SetField(4, trame.checksum);

                }
                else if (trame.id==50)
                {
                    dt.Rows[5].SetField(1, trame.cptOctet);
                    dt.Rows[5].SetField(2, trame.Type);
                    dt.Rows[5].SetField(3, trame.data);
                    dt.Rows[5].SetField(4, trame.checksum);
                }
            }
            datagridMeteo.DataSource = dt;
        }
        private void insertAliveInDatagrid()
        {
            /////////////////////////////
            ///Cette méthode sert à inserer les keepAlive et les up ou down dans le datagrid
            foreach (Base trame in LBase)
            {
                if(trame.id == 0)
                {
                    dt.Rows[(trame.id)].SetField(5, "Keep Alive");
                }
                else if(trame.isConvert ==true)
                {
                    int dataconvert = (int)((Mesure)trame).getDataConvert();
                    if ((int)((Mesure)trame).MaxAlarm< dataconvert)
                    {
                       dt.Rows[(trame.id)].SetField(5, "Up");
                    }
                    else if ((int)((Mesure)trame).MinAlarm > dataconvert)
                    {
                        dt.Rows[(trame.id)].SetField(5, "Down");
                    }
                    else
                    {
                        dt.Rows[(trame.id)].SetField(5, "OK");
                    }
                }

            }
            datagridMeteo.DataSource = dt;
        }
        private void bt_Update_Click(object sender, EventArgs e)
        {
            foreach (Base trame in LBase)
            {
                if (trame.id == (int) comboBoxID.SelectedItem)
                {
                    int Maxinterval = (int)nUD_MaxInterval.Value;
                    int Mininterval = (int)nUD_MinInterval.Value;
                    int MaxAlarm = (int)numericUpDownAlarmMax.Value;
                    int MinAlarm = (int)numericUpDownAlarmMin.Value;

                    ((Mesure)trame).MaxAlarm = MaxAlarm;
                    ((Mesure)trame).MinAlarm = MinAlarm;
                    ((Mesure)trame).Maxint= Maxinterval;
                    ((Mesure)trame).Minint= Mininterval;                  
                    ((Mesure)trame).isConvert = true;
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            InsertValueInDatagrid();
            insertAliveInDatagrid();
        }
        private void IDCombobox()
        {
            for(int i = 1; i<maxId-1; i++)
            {
                comboBoxID.Items.Add(i);
            }
        }
        private void AddTrame()
        {
            while (BufferF.Count > 14)
            {
                if (checkframe())
                {
                    Base obj = new Base();
                    /////////////////////////////////
                    ///Creation d'une trame d'information
                    if (BufferF[3] < 11 && BufferF[3] !=0)
                    {
                        obj = new Mesure();
                    }
                    if (BufferF[3] == 50)
                    {
                        obj = new Alarm();
                    }
                    ////////////////////////////////////////
                    ///Commencement de la recuperation des informations de la trame
                    /////id position
                    obj.id = BufferF[3];
                    ////////////////
                    ///Nombre de data 
                    obj.cptOctet = BufferF[4];
                    ////////////////
                    ///Type
                    obj.Type = BufferF[5];
                    //////////////////
                    ///Data
                    //////////////////
                    ///Checksumm
                    obj.checksum = BufferF[6 + obj.cptOctet];
                    //////////////////////////////////////////
                    ///Fin de trame
                    for (int cpt = 0; cpt < obj.cptOctet; cpt++)
                    {
                        obj.data += (((UInt32)BufferF[6 + cpt]) << 8 * cpt);
                    }
                    if(checkListBase(obj))
                    {
                        uptadeData(obj);
                    }
                    else
                    {
                        LBase.Add(obj);
                    }
                    Console.WriteLine("taille de la liste:" + LBase.Count);
                    for (int cpt = 0; cpt < 10+obj.cptOctet; cpt++)
                    {
                        BufferF.RemoveAt(0);
                    }
                }
            }
            bData_received = true; 
        }
        private bool checkListBase(Base newtrame)
        {
            ///////////////////////////////////////////////
            ////Cette méthode sert à rajouter la données dans le bon id
            foreach (Base Trame in LBase)
            {
                if(Trame.id==newtrame.id)
                {
                    return true;
                }
            }
            return false;
        }
        private void uptadeData(Base newtrame)
        {
            ///////////////////////////////////////////////////////////
            ////Cette méthode sert à transferer les données de la trame 
            foreach (Base Trame in LBase)
            {
                if (Trame.id == newtrame.id)
                {
                    Trame.id = newtrame.id;
                    Trame.Type = newtrame.Type;
                    Trame.cptOctet = newtrame.cptOctet;
                    Trame.data = newtrame.data;
                    Trame.checksum = newtrame.checksum;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ///////////////////////////////////////////////
            ////Cette méthode sert à mettre en pause envoie des données
            if (timer1.Enabled==true)
            {
                timer1.Enabled = false;
                button1.Text = "Start";
            }
            else 
            {
                timer1.Enabled = true;
                button1.Text = "Pause";
            }
        }
        private void initUserPage(int access)
        { 
            this.UserForm = new Forms.FormUser();
            this.PageUser = new System.Windows.Forms.TabPage();
            //TabPage
            this.PageUser.Controls.Add(this.UserForm); 
            this.PageUser.Location = new System.Drawing.Point(4, 22);
            this.PageUser.Name = "tabPageUsers";
            this.PageUser.Padding = new System.Windows.Forms.Padding(3);
            this.PageUser.Size = new System.Drawing.Size(853, 257);
            this.PageUser.TabIndex = 0;
            this.PageUser.Text = "Users";
            this.PageUser.UseVisualStyleBackColor = true;
            this.tabcontrol.Controls.Add(this.PageUser);
            ///Form
            UserForm.Location = new System.Drawing.Point(10, 10);
            UserForm.Name = "FormUser";
            UserForm.Size = new System.Drawing.Size(1000, 300);
            UserForm.TabIndex = 5;
            db.createDB();
            db.linkDB(UserForm.dataGridViewUser);
            if(access == 2)
            {
                UserForm.groupBoxCreate.Visible = false;
            }
            else if (access == 3)
            {
                UserForm.groupBoxCreate.Visible = false;
                UserForm.groupBoxUserDelete.Visible = false;
            }

            UserForm.btRead.Click += delegate (object sender2, EventArgs e2)
            {
                db.button_RD_Click(sender2, e2, UserForm.dataGridViewUser);
            };
            UserForm.btInsert.Click += delegate (object sender2, EventArgs e2)
            {
                db.button_Insert_Click(sender2, e2, UserForm.dataGridViewUser,  UserForm.name.Text, UserForm.pwd.Text,int.Parse(UserForm.Access.Text));
            };
            UserForm.btDelete.Click += delegate (object sender2, EventArgs e2)
            {
                db.button_DL_Click(sender2, e2, UserForm.dataGridViewUser, UserForm.textBoxnameDelete.Text);
            };
        }
        private void connectbutton_Click(object sender, EventArgs e)
        {
           user = db.ConnectDB(UserInput.Text, passwordInput.Text);
            if(user!=null)
            {
                ////////////////////////////////
                ////Basic User
                SetVisibleConnect(false);
                SetUserName(true);
                initPageGraph();
                affichageConfigurations(true);
                ////////////////////////////////
                ///MiddleRights
                if (user.Access == 3)
                {
                    initUserPage(3);
                }
                ////////////////////////////////
                ///MasterRights
                else if (user.Access == 2)
                {
                    initUserPage(2);
                }
                ////////////////////////////////
                ///AdminRights
                else if (user.Access == 1)
                {
                    initUserPage(1);
                } 
            }
           
        }
        private void affichageConfigurations(bool v)
        {
            groupBoxConfiguration.Visible = v;
        }
        private void SetUserName(bool v)
        {
            if (v)
            {
                accountlabel.Visible = true;
                accountlabel.Text = "Account :" + user.name + " Level Access :" + user.Access; 
            }
            else
            {
                accountlabel.Text = "";
                accountlabel.Visible = false;

            }
        }
        private void SetVisibleConnect(bool v)
        {
            if (v)
            {
                labelUser.Visible = true;
                labelPassword.Visible = true;
                UserInput.Visible = true;
                passwordInput.Visible = true;
                connectbutton.Visible = true;
            }
            else
            {
                labelUser.Visible = false;
                labelPassword.Visible = false;
                UserInput.Visible = false;
                passwordInput.Visible = false;
                connectbutton.Visible = false;
                
            }
        }
        private void initPageGraph()
        {
            this.GraphForm = new Forms.FormGraph();
            this.PageGraph = new System.Windows.Forms.TabPage();
            //TabPageGraph
            this.PageGraph.Controls.Add(this.GraphForm); 
            this.PageGraph.Location = new System.Drawing.Point(4, 22);
            this.PageGraph.Name = "tabPageGraph";
            this.PageGraph.Padding = new System.Windows.Forms.Padding(3);
            this.PageGraph.Size = new System.Drawing.Size(853, 257);
            this.PageGraph.TabIndex = 0;
            this.PageGraph.Text = "Graphiques";
            this.PageGraph.UseVisualStyleBackColor = true;
            this.tabcontrol.Controls.Add(this.PageGraph);
            ///Form
            GraphForm.Location = new System.Drawing.Point(10, 10);
            GraphForm.Name = "FormUser";
            GraphForm.Size = new System.Drawing.Size(1000, 300);
            GraphForm.TabIndex = 5;
            ///////////////////////////
            ///Add Data
            GraphForm.comboBoxIDGraphique.Click += delegate (object sender2, EventArgs e2)
            {
                foreach (Base Trame in LBase)
                {
                    if (Trame.isConvert == true)
                    {
                        if(!GraphForm.comboBoxIDGraphique.Items.Contains(Trame.id))
                        GraphForm.comboBoxIDGraphique.Items.Add(Trame.id);
                    }
                }
            };
            GraphForm.btLauch.Click += delegate (object sender2, EventArgs e2)
            {
                if (GraphForm.comboBoxIDGraphique.SelectedItem != null)
                {
                    Timer timer = new Timer();
                    timer.Interval = 2000;
                    cpt = 1;
                    GraphForm.chartID.Series.Clear();
                    GraphForm.chartID.Series.Add(series1);
                    /////////////////////////////
                    ///Valeurs
                    timer.Start();
                    timer.Tick += new EventHandler(addValueGraphics);
                }
                else
                {
                    MessageBox.Show("Vous devez choisir un id Mesure");
                }
            };

        }
        private void  addValueGraphics(Object myObject, EventArgs myEventArgs)
        {
            int id = (int)GraphForm.comboBoxIDGraphique.SelectedItem;
            foreach (Base Trame in LBase)
            {
                if (Trame.id == id)
                {
                    series1.Points.AddXY(cpt, (int)(((Mesure)Trame).getDataConvert()));
                    cpt++;
                    GraphForm.chartID.Show();
                }
            }
        }

        
    }
}