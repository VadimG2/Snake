using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.X = 1;
            p1.Y = 3;
            p1.sym = '*';
            p1.Draw();

            Point p2 = new Point();
            p2.X = 4;
            p2.Y = 5;
            p2.sym = '#';
            p2.Draw();

            Console.ReadLine();
        }
    }
}
