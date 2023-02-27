using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VuvejdaneNaSpisykOtKonzolataNaEdinRed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums =Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < nums.Count; i++)
            {
                Console.WriteLine($"nums[{i}] = {nums[i]}");
            }
        }
    }
}
