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

namespace TestaPortasCOM
{
    public partial class FormTestPort : Form
    {
        public FormTestPort()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComTest();
        }
        public void ComTest()
        {
            listViewComPorts.Clear();
            var ports = SerialPort.GetPortNames();
            if(ports.Count() == 0)
            {
                listViewComPorts.Items.Add("Não existem portas COM disponiveis ou configuradas neste dispositivo");
            }
            else
            {
                foreach (var port in ports)
                {
                    listViewComPorts.Items.Add(port);
                }
            } 
        }



        private void button1_Click(object sender, EventArgs e)
        {
            ComTest();
        }

        private void buttonTestPort_Click(object sender, EventArgs e)
        {            
            if(!string.IsNullOrEmpty(listViewComPorts.SelectedItems[0].Text))
            {
                Program.NamePort = listViewComPorts.SelectedItems[0].Text;
                var frd = new FormReceiveData();
                frd.Show();
            }
            else
            {
                MessageBox.Show("Selecione uma porta COM");
            }
            
        }
    }
}
