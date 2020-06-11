using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaCOM
{
    public class COMCommunicate2
    {
        public static void Communicate(string portName)
        {
            string res;

            SerialPort mySerialPort = new SerialPort(portName);
            mySerialPort.BaudRate = 9600;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.DataBits = 8;

            mySerialPort.Open();

            mySerialPort.DiscardInBuffer();

            int totalBytes = mySerialPort.BytesToRead;

            if(totalBytes > 0)
            {
                byte[] buffer = new byte[27];
                mySerialPort.Read(buffer, 0, totalBytes);
                res = BitConverter.ToString(buffer);
                Console.Write(res);
            } 
            else
            {
                Console.WriteLine("err");
            }
        }
    }
}
