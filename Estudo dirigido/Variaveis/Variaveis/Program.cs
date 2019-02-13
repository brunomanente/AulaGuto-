using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            Console.ReadLine();
            */

            Console.WriteLine("qual é o seu nome");
            Console.WriteLine("qual é o seu sobrenome");
            string myFirstName;
            myFirstName = Console.ReadLine();

            string myLastName;
            Console.Write("Me informe o seu sobrenome?");
            myLastName = Console.ReadLine();

            Console.WriteLine("olá," + myFirstName + " " + myLastName);
            Console.ReadLine();
        }
    }
}
