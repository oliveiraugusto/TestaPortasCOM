using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Text.RegularExpressions;

namespace TestaCOM
{
    public class COMCommunicate
    {
        protected static List<char> Indata { get; set; } = new List<char>();

        public static void Communicate(string portName)
        {
            try
            {             
                SerialPort mySerialPort = new SerialPort(portName);
                mySerialPort.BaudRate = 9600;
                mySerialPort.Parity = Parity.None;
                mySerialPort.StopBits = StopBits.One;
                mySerialPort.DataBits = 8;
                //mySerialPort.DtrEnable = true;

                mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

                mySerialPort.Open();

                Console.WriteLine("Recebendo dados...\n");
                Console.ReadKey();
                //Console.Write($"{DateTime.Now} ");
                mySerialPort.Close();             
            }
            catch (Exception ex)
            {
                throw new Exception($"Houve um erro de comunicação com a porta {portName}.\nDetalhes: "+ex.Message);
            }
                        
        }

        public static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                while (Indata.Count >= 0 && Indata.Count < 23)
                {
                    var sp = (SerialPort)sender;
                    var temp = sp.ReadExisting();
                    if(temp.Length <= 23)
                    {
                        foreach (var t in temp.ToCharArray(0, temp.Length))
                        {
                            if(Indata.Count < 23)
                                Indata.Add(t);
                        }                        
                    } 
                    else
                    {
                        foreach (var t in temp.ToCharArray(0, 23))
                        {
                            if (Indata.Count < 23)
                                Indata.Add(t);
                        }
                    }
                }

                if (Indata.Count == 23)
                {
                    string flow = "";
                    foreach (var i in Indata)
                    {
                        flow += i;
                    }

                    flow = Regex.Replace(flow, "[^0-9a-z A-Z.]+", "");

                    var data = new StreamWriter("data", true);
                    data.WriteLine($"{DateTime.Now} {flow.ToString()}");
                    data.Close();
                    Console.WriteLine($"{DateTime.Now} {flow.ToString()}");
                    //if(Indata.Count == 23)
                        Indata.Clear();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }
    }
}
