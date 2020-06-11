using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestaPortasCOM
{
    public class COMCommunicate
    {
        public static void Communicate(string portName)
        {
            try
            {

                SerialPort mySerialPort = new SerialPort(portName);
                mySerialPort.BaudRate = 9600;
                mySerialPort.Parity = Parity.None;
                mySerialPort.StopBits = StopBits.One;
                mySerialPort.DataBits = 8;

                mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

                mySerialPort.Open();

                Console.WriteLine("Recebendo dados...\n");

                Console.ReadKey();
                mySerialPort.Close();
            }
            catch (Exception ex)
            {
                throw new Exception($"Houve um erro ao se comunicar com a porta {portName}.\nDetalhes: " + ex.Message);
            }

        }

        public static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            Console.WriteLine($"{DateTime.Now} {indata}");
            Console.ReadKey();
        }
    }
}
