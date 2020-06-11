using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestaCOM
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "TestaCOM - Teste de Comunicação com Portas COM";
            Console.WriteLine("Digite o nome da porta para teste: ");
            string port = Console.ReadLine();
            COMCommunicate.Communicate(port.ToUpper());
            //COMCommunicate2.Communicate(port.ToUpper());

            Console.ReadKey();
            Console.WriteLine("Fechando Operação...");
            Thread.Sleep(3000);  
        }
    }
}
