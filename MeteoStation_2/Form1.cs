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
        private Forms.FormAlarm AlarmPage;

        String DefaultCOM = "COM2";
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
            dc = new DataColumn("Data", typeof(UInt32));
            dt.Columns.Add(dc);
            dc = new DataColumn("CheckSum", typeof(int));
            dt.Columns.Add(dc);
            //////////////////////////////
            ////Liason de la datatable datagrid
            for (int i = 1; i < 6; i++)
            {
                dt.Rows.Add(i);
            }
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
            if (bData_received == true)
            {
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
            for (uint index = 0; index < BufferS.Length; index++)
            {
                Console.WriteLine("Index :" + index + " | Value :" + BufferS[index]);
            }
        }
        private void AddtoBufferF()
        {
            //////////////////////////////////
            ////Insertion to list
            for (int index = 0; index < BufferS.Length; index++)
            {
                BufferF.Add(BufferS[index]);
            }
            AddTrame();
        }
        public bool checkframe()
        {
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
        {
            double DataConvert;
            double denomiteur = Math.Pow(2, nbredata * 8) - 1;
            Console.WriteLine(denomiteur);
            ///////////////////
            ////Méthode
            DataConvert = ((double)(Data / denomiteur) * (MaxInterval - MinInterval)) + MinInterval;
            return DataConvert;
        }
        private void InsertValueInDatagrid()
        {
            foreach (Base trame in LBase)
            {
                dt.Rows[(trame.id - 1)].SetField(1, trame.cptOctet);
                dt.Rows[(trame.id - 1)].SetField(2, trame.Type);
                dt.Rows[(trame.id - 1)].SetField(3, trame.data);
                dt.Rows[(trame.id - 1)].SetField(4, trame.checksum);
            }
            datagridMeteo.DataSource = dt;
        }
        private void bt_Update_Click(object sender, EventArgs e)
        {
            foreach (Base trame in LBase)
            {
                if (trame.id == 2)
                {

                    int Maxinterval = (int)nUD_MaxInterval.Value;
                    int Mininterval = (int)nUD_MinInterval.Value;
                    MessageBox.Show("Data convertie " + GetDataConvert(trame.data, trame.cptOctet, Maxinterval, Mininterval));
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //InsertValueInDatagrid();
        }
        private void AddTrame()
        {
            while (BufferF.Count < 14)
            {
                if (checkframe())
                {
                    Base obj = new Base();
                    /////////////////////////////////
                    ///Creation d'une trame d'information
                    if (BufferF[3] < 11)
                    {
                        obj = new Mesure();
                    }
                    if (BufferF[3] == 51)
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
                    obj.checksum = BufferF[8 + obj.cptOctet];
                    //////////////////////////////////////////
                    ///Fin de trame 
                    int index = 8 + obj.cptOctet;
                    String fintrame = BufferF[index + 1].ToString() + BufferF[index + 2].ToString() + BufferF[index + 3].ToString();
                    for (int cpt = 0; cpt < obj.cptOctet; cpt++)
                    {
                        obj.data += (((UInt32)BufferF[8 + cpt]) << 8 * cpt);
                    }
                }
            }
        }
    }


    /* private void AddtoLTrame()
      {
          String fintrame = "";
          bool VerifTrame = false;
          bool traitementTrame = false;
          bool EndTrame = false;
          for (int index = 0; index < BufferF.Count; index++)
          {
              if (index < BufferF.Count - 10)
              {
                  if (BufferF[index] == 85 && VerifTrame == false && index < BufferF.Count)
                  {
                      String debuttrame = "";
                      VerifTrame = true;
                      debuttrame = BufferF[index].ToString() + BufferF[index + 1].ToString() + BufferF[index + 2].ToString();
                      Console.WriteLine("Debut de trame");
                      /////////////////////////////////////
                      ////Position sur id de la trame
                      if (debuttrame == "8517085")
                      {
                          ////////////////////////////////////
                          //Verif que c'est bien le debut d'une trame
                          ////////////////////////////////////
                          ///Verif si il y a une trame complete 
                          Console.WriteLine("Taille du buffer : "+BufferF.Count +" N° "+index);
                          int verif = BufferF[index + 4];

                          String Sfin = BufferF[index + verif + 7].ToString() + BufferF[index + verif + 8].ToString() + BufferF[index + verif + 9].ToString();
                          Console.WriteLine("Nbre " + verif + "test " + Sfin);
                          if (Sfin == "17085170")
                          {
                              traitementTrame = true;
                          }

                      }
                      else
                      {
                          VerifTrame = false;
                      }
                  }
                  if (traitementTrame == true && index + 12 < BufferF.Count)
                  {
                      /////////////////////////////////
                      ///Creation d'une trame d'information
                      Base newtrame = new Base();
                      UInt32 newdata = 0;
                      ////////////////////////////////////////
                      ///Commencement de la recuperation des informations de la trame
                      /////id position
                      int memoryposition = index + 3;
                      newtrame.id = BufferF[memoryposition];
                      ////////////////
                      ///Nombre de data 
                      newtrame.cptOctet = BufferF[memoryposition + 1];
                      ////////////////
                      ///Type
                      newtrame.Type = BufferF[memoryposition + 2];
                      //////////////////
                      ///Data
                      for (int cpt = 0; cpt < newtrame.cptOctet; cpt++)
                      {
                          newdata += ((UInt32)BufferS[memoryposition + 3 + cpt]) << 8 * cpt;
                      }
                      newtrame.data = newdata;
                      ///////////////
                      ///Checksumm
                      newtrame.checksum = BufferS[memoryposition + 3 + newtrame.cptOctet];
                      //////////////////////////////////////////
                      ///Fin de trame 
                      index = memoryposition + 3 + newtrame.cptOctet;
                      fintrame = BufferF[index + 1].ToString() + BufferF[index + 2].ToString() + BufferF[index + 3].ToString();
                      //////////////////////////////////////////
                      ///reset

                      if (fintrame == "17085170")
                      {
                          Console.WriteLine("New trame id:" + newtrame.id + "| Nbre :" + newtrame.cptOctet + "| Type :" + newtrame.Type + "| " + "| Data :" + newtrame.data + "| " + "| Checksum :" + newtrame.checksum);
                          LBase.Add(newtrame);
                          Console.WriteLine("taille de la liste:" + LBase.Count);
                          VerifTrame = false;
                          traitementTrame = false;
                      }
                      else
                      {
                          Console.WriteLine("probleme" + fintrame);
                      }
                  }
              }
          }
          Console.WriteLine("Fin de la lecture du jet d'information n°" + cptRead);
          //bData_received = true;
          //Serial.DataReceived += new SerialDataReceivedEventHandler(Serial_DataReceived);
      }*/
}