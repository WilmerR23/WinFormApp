using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int fib in Fibs(6))//1, 5
            {
                Console.WriteLine(fib + " ");//4, 10
            }
            Console.ReadKey();
        }

        static IEnumerable<int> Fibs(int fibCount)
        {
            for (int i = 0, prevFib = 0, currFib = 1; i < fibCount; i++)//2
            {
                yield return prevFib;//3, 9
                int newFib = prevFib + currFib;//6
                prevFib = currFib;//7
                currFib = newFib;//8
            }
        }
    }
}
