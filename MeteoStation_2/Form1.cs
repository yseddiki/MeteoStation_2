﻿using MeteoStation_2.Class;
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

        String DefaultCOM = "COM2";
        DataTable dt = new DataTable();
        bool bData_received = true;
        byte[] BufferS;
        List<Base> LBase = new List<Base>();
        List<byte> BufferF = new List<byte>();
        int count;
        int cptRead = 0;
        Timer timer = new Timer { Interval = 200, Enabled = false };


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
            dc = new DataColumn("Data", typeof(UInt32)) ;
            dt.Columns.Add(dc);
            dc = new DataColumn("CheckSum", typeof(int));
            dt.Columns.Add(dc);
            //////////////////////////////
            ////Liason de la datatable datagrid
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
            AddtoLTrame();
        }
        private void AddtoLTrame()
        {
            String fintrame = "";
            bool VerifTrame = false;
            bool traitementTrame = false;
            for (int index = 0; index < BufferF.Count; index++)
            {
                if (BufferF[index] == 85 && VerifTrame == false)
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
                        traitementTrame = true;

                    }
                    else
                    {
                        VerifTrame = false;
                    }
                }
                if (traitementTrame == true)
                {
                    /////////////////////////////////
                    ///Creation d'une trame d'information
                    Base newtrame = new Base();
                    UInt32 newdata =0;
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
                    String Verif="";
                    for (int cpt = 0; cpt < newtrame.cptOctet; cpt++)
                    {
                        newdata += ((UInt32) BufferS[memoryposition + 3 + cpt])<<8*cpt;
                        Verif += BufferS[memoryposition + 3 + cpt] + " + ";
                    }
                    Console.WriteLine("verif data "+Verif);
                    Verif = "";
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
                        Console.WriteLine("New trame id:" + newtrame.id + "| Nbre :" + newtrame.cptOctet + "| Type :" + newtrame.cptOctet + "| " + "| Data :" + newtrame.data + "| " + "| Checksum :" + newtrame.checksum);
                        LBase.Add(newtrame);
                        Console.WriteLine("taille de la liste:" + LBase.Count);
                        index = index + 3;
                        VerifTrame = false;
                        traitementTrame = false;

                    }
                    else
                    {
                        Console.WriteLine("probleme" + fintrame);
                    }

                }
            }
            MessageBox.Show("Fin de la lecture du jet d'information n°" + cptRead);
            UpdateDatagrid();
        }
        private void UpdateDatagrid()
        {
            InsertValueInDatagrid();
            RefreshDataGrid();
        }
        public double GetDataConvert(UInt32 Data,int nbredata,int MaxInterval,int MinInterval)
        {
            double DataConvert;
            DataConvert =((int)(Data / 2 * (nbredata * 8)) * (MaxInterval - MinInterval) - MinInterval);
            return DataConvert;
        }
        private void RefreshDataGrid()
        {
            ///Verif
            ///
        }

        private void InsertValueInDatagrid()
        {
            foreach (Base trame in LBase)
            {
              
                dt.Rows.Add(trame.id, trame.cptOctet, trame.Type, trame.data, trame.checksum);
               
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
                    trame.data = GetDataConvert(trame.data,trame.cptOctet,Maxinterval,Mininterval);
                }
            }
        }        
    }
}
