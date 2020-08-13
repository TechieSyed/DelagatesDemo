using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagatesDemo
{
    class Demo
    {
        public void PrintHi(string name)
        {
            Console.WriteLine("Hi " + name);
        }
    }
    class Program
    {
        delegate void Dowork(string input);
        static void Main(string[] args)
        {
            Dowork obj;
            obj = new Dowork(PrintMessage);

            var d = new Demo();
            //obj += new Dowork(d.PrintHi);
            obj += d.PrintHi;

            obj("Jojo Jose");

            Console.ReadKey();
        }
        static void PrintMessage(string username)
        {
            Console.WriteLine("Hello "+username);
        }
        
    }
}
