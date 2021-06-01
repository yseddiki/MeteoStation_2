using MeteoStation_2.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeteoStation_2
{

    public partial class Form1 : Form
    {
        DB db = new DB();
        internal Forms.FormUser UserPage ;
        String DefaultCOM = "COM2";
        bool bdatagridConvert = false;
        DataTable dt = new DataTable();
        bool bData_received = true;
        byte[] BufferS;
        List<Base> LBase = new List<Base>();
        List<byte> BufferF = new List<byte>();
        int count;
        int cptRead = 0;
        public Form1()
        {
            InitializeComponent();
            createGrid();
            initUserPage();
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
            dc = new DataColumn("Data", typeof(double));
            dt.Columns.Add(dc);
            dc = new DataColumn("CheckSum", typeof(int));
            dt.Columns.Add(dc);
            //////////////////////////////
            ////Liason de la datatable datagrid
            for (int i = 0; i < 5; i++)
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
            Console.WriteLine("Incoming Data :");
            // Begin communications
            timer1.Start();
            Serial.Open();
            Serial.DataReceived += new SerialDataReceivedEventHandler(Serial_DataReceived);
        }

        private void Serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            ///////////////////////////////////////////////
            ////Cette méthode sert à recevoir les données bruts
            if (bData_received == true)
            {
                Console.WriteLine("DATA RECEIVED");
                count = Serial.BytesToRead;
                BufferS = new byte[count];
                Serial.Read(BufferS, 0, count);
                bData_received = false;
                cptRead++;
                AddtoBufferF();
            }
        }

        private void SysoToTab()
        {
            ///////////////////////////////////////////////
            ////Cette méthode sert à pour debuger
            for (uint index = 0; index < BufferS.Length; index++)
            {
                Console.WriteLine("Index :" + index + " | Value :" + BufferS[index]);
            }
        }
        private void AddtoBufferF()
        {
            ///////////////////////////////////////////////
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
        public double GetDataConvert(UInt32 Data, int nbredata, int MaxInterval, int MinInterval)
        {   ///////////////////////////////////////////////
            ////Cette méthode sert à  convertir les données
            double DataConvert;
            double denomiteur = Math.Pow(2, nbredata * 8) - 1;   
            DataConvert = ((double)(Data / denomiteur) * (MaxInterval - MinInterval)) + MinInterval;
            return DataConvert;
        }
        private void InsertValueInDatagrid()
        {
            /////////////////////////////
            ///Cette méthode sert à inserer les valeurs dans le datagrid
            foreach (Base trame in LBase)
            {
                if (trame.id < 6)
                {
                    dt.Rows[(trame.id)].SetField(1, trame.cptOctet);
                    dt.Rows[(trame.id)].SetField(2, trame.Type);
                    if (bdatagridConvert == false)
                    {
                        dt.Rows[(trame.id)].SetField(3, (double)trame.data);
                    }
                    else
                    {
                        dt.Rows[(trame.id)].SetField(3,((Mesure)trame).DataConvert);
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
        private void bt_Update_Click(object sender, EventArgs e)
        {
            
            foreach (Base trame in LBase)
            {
                bdatagridConvert = true;
                if (trame.id == 2)
                {
                    int Maxinterval = (int)nUD_MaxInterval.Value;
                    int Mininterval = (int)nUD_MinInterval.Value;
                    ((Mesure)trame).DataConvert=GetDataConvert(trame.data, trame.cptOctet, Maxinterval, Mininterval);
                    ((Mesure)trame).isConfigured = true;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            InsertValueInDatagrid();
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
                    Console.WriteLine("New trame id:" + obj.id + "| Nbre :" + obj.cptOctet + "| Type :" + obj.Type + "| " + "| Data :" + obj.data + "| " + "| Checksum :" + obj.checksum);
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
        private void initUserPage()
        { 
            this.UserPage = new Forms.FormUser();
            this.Controls.Add(UserPage);
            UserPage.Location = new System.Drawing.Point(10, 230);
            UserPage.Name = "FormUser";
            UserPage.Size = new System.Drawing.Size(1000, 1000);
            UserPage.TabIndex = 5;
            db.createDB();
            db.linkDB(UserPage.dataGridViewUser);
            UserPage.btRead.Click += delegate (object sender2, EventArgs e2)
            {
                db.button_RD_Click(sender2, e2, UserPage.dataGridViewUser);
            };
            UserPage.btInsert.Click += delegate (object sender2, EventArgs e2)
            {
                db.button_Insert_Click(sender2, e2, UserPage.dataGridViewUser,UserPage.id.Text, UserPage.name.Text,UserPage.pwd.Text);
            };
            UserPage.btDelete.Click += delegate (object sender2, EventArgs e2)
            {
                db.button_DL_Click(sender2, e2, UserPage.dataGridViewUser, UserPage.name.Text);
            };
        }
    }
}