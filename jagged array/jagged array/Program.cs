using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[2][];

            jagged[0] = new int[] { 1, 2 };
            jagged[1] = new int[] { 3, 4, 5 };

            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
