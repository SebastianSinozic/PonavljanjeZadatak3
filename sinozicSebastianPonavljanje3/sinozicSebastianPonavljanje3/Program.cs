using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace sinozicSebastianPonavljanje3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisite 1. stringa ");
            string a = Console.ReadLine();
            Console.WriteLine("Upisite 2. stringa ");
            string b = Console.ReadLine();
            Console.WriteLine("Upisite 3. stringa ");
            string c = Console.ReadLine();


            string x = a + b + c;
            x = new string(x.Reverse().ToArray());


            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
