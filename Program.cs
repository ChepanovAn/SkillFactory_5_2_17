using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_5_2_17
{
    class Program
    {
        static void ShowArray(int[] array, bool priznak = true)
        {
            if (priznak)
            {
                Array.Sort(array);
            }

            foreach (var item in array)
            {
                Console.WriteLine(item);
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            int[] array = { 6, 10, 5 };
            ShowArray(array);
        }
    }
}
