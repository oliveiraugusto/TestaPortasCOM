using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaCOM
{
    public class COMCommunicate
    {
        public static void Communicate(string portName)
        {
            SerialPort mySerialPort = new SerialPort(portName);

            mySerialPort.BaudRate = 9600;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.DataBits = 8;
            //mySerialPort.Handshake = Handshake.None;
            //mySerialPort.RtsEnable = true;
            mySerialPort.ReadTimeout = 2000;

            mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            mySerialPort.Open();

            Console.WriteLine("Recebendo dados...\n \n \n");
            Console.ReadKey();
            mySerialPort.Close();
        }

        public static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            var writer = new StreamWriter("teste.txt", true);
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            Console.Write($"{DateTime.Now} {indata}");
            writer.Write($"{DateTime.Now} {indata}");
            writer.Write("\n");
            writer.Close();
        }
    }
}
