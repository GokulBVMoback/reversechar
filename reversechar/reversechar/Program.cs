using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversechar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letter1, letter2, letter3, letter4, letter5;
            Console.Write("Letter1:");
            letter1 = Convert.ToChar(Console.ReadLine());
            Console.Write("Letter2:");
            letter2 = Convert.ToChar(Console.ReadLine());
            Console.Write("Letter3:");
            letter3 = Convert.ToChar(Console.ReadLine());
            Console.Write("Letter4:");
            letter4 = Convert.ToChar(Console.ReadLine());
            Console.Write("Letter5:");
            letter5 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Reversed letters are:" + letter5 + " " + letter4 + " " + letter3 +" "+ letter2+" "+letter1);
        }
    }
}
