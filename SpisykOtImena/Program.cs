using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpisykOtImena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            int i = 0;
            for (i = 0; i < names.Count-1; i++)
            {
                Console.Write($"{names[i]}; ");
            }
            Console.Write(names[i]);
            Console.WriteLine();
            //ne se poluchi sys string.Join
        }
    }
}
