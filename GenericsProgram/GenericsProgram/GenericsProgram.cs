using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GenericsProgram
    {
        public static void toPrint<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                System.Console.WriteLine(element);
            }
            Console.WriteLine("------------------------  ");
        }
    }
}
