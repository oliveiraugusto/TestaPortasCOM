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
        public string ListViewDadosCOM
        {
            set
            {
                listViewDadosCOM.Items.Add(value);
            }
        }

        public FormTestPort()
        {
            InitializeComponent();
        }

        private void FormTestPort_Load(object sender, EventArgs e)
        {
            var ports = SerialPort.GetPortNames();
            comboBoxPortas.Sorted = true;
            foreach (var p in ports)
            {
                comboBoxPortas.Items.Add(p);
            }

        }

        private void buttonTestPort_Click(object sender, EventArgs e)
        {
           if(serialPortCOM.IsOpen)
            {
                buttonTestPort.Text = "Parar";
                serialPortCOM.Close();
            }
           else
            {
                buttonTestPort.Text = "Testar";
                COMCommunicate.Communicate(comboBoxPortas.Text);
            }
        }

        private void buttonRefreshPort_Click(object sender, EventArgs e)
        {
            InitializeComponent();
        }
    }
}
