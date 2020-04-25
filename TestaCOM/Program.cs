using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestaCOM
{
    class Program
    {
        public static void Main(string[] args)
        {
            COMCommunicate.Communicate("COM3");
            Console.WriteLine("Pressione qualquer tecla para fechar...");
            Console.ReadKey();
        }

    }
}
