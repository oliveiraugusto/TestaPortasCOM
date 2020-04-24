using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestaPortasCOM
{
    public partial class FormReceiveData : Form
    {
        public FormReceiveData()
        {
            InitializeComponent();
        }

        private void FormReceiveData_Load(object sender, EventArgs e)
        {
            SerialPort mysp = new SerialPort(Program.NamePort);
            try
            {
                mysp.BaudRate = 9600;
                mysp.DataBits = 8;
                mysp.Parity = Parity.None;
                mysp.StopBits = StopBits.One;
                mysp.Handshake = Handshake.None;
                mysp.RtsEnable = true;

                mysp.DataReceived += new SerialDataReceivedEventHandler(DataReceiveHandler);

                mysp.Open();             

            }
            catch (Exception ex)
            {
                throw new Exception($"Não foi possivel conectar a porta {Program.NamePort}\nDetalhes:\n" + ex.Message);
            }
            finally
            {
                mysp.Close();
            }
        }

        private void DataReceiveHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort sp = (SerialPort)sender;
                string data = sp.ReadExisting();
                listViewDataCOM.Items.Add($"{DateTime.Now.ToString()}-{data}");
            }
            catch (Exception ex)
            {

                throw new Exception($"Não Não foi possivel recolher dados da porta {Program.NamePort}\nDetalhes:\n" + ex.Message);
            }
        }
    }
}
