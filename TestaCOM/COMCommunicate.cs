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
        public static void Communicate(string portName)
        {
            try
            {             
                SerialPort mySerialPort = new SerialPort(portName);
                mySerialPort.BaudRate = 9600;
                mySerialPort.Parity = Parity.None;
                mySerialPort.StopBits = StopBits.One;
                mySerialPort.DataBits = 8;
                mySerialPort.RtsEnable = true;
                mySerialPort.Handshake = Handshake.None;
                //mySerialPort.ReadTimeout = 100;

                mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

                mySerialPort.Open();

                Console.WriteLine("Recebendo dados...\n");
                Console.ReadKey();
                mySerialPort.Close();             
            }
            catch (Exception ex)
            {
                throw new Exception($"Houve um erro de comunicação com a porta {portName}.\nDetalhes: "+ex.Message);
            }
                        
        }


        /// <summary>
        /// Recebe, imprime e grava em arquivo  resultado da porta COM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string Indata = string.Empty;

            try
            {
                //enquanto não encontrar o caractere de escape "\r" continua buscando dados na porta COM e colocando na variavel
                while(!Indata.Contains("\r"))
                {
                    var sp = (SerialPort)sender;
                    Indata += sp.ReadExisting();
                }

                //Após encontrar o caractere de escape, imprime com a data na tela
                var data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                Console.WriteLine($"{data}--{Indata}");

                //guarda no arquivo com data
                var text = new StreamWriter("data", true);
                text.Write($"{data}--{Indata}");
                text.Close();                
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }
    }
}
