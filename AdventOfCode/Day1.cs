using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class Day1
    {
        public static void day1()
        {
            int[] left;
            int[] right;

            string[] lines = File.ReadAllLines("Input.txt");

            left = new int[lines.Length];
            right = new int[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                left[i] = int.Parse(parts[0]);   // Erste Zahl ins 'left'-Array
                right[i] = int.Parse(parts[1]);  // Zweite Zahl ins 'right'-Array
            }

            int z = 0;
            int y = 0;

            Array.Sort(left);
            Array.Sort(right);
            for (int i = 0; i < left.Length; i++)
            {
                z = Math.Abs(left[i] - right[i]);
                y = y + z;
            }
            Console.WriteLine(y);
        }

        public static void day1Part2()
        {
            int[] left;
            int[] right;

            string[] lines = File.ReadAllLines("Input.txt");

            left = new int[lines.Length];
            right = new int[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                left[i] = int.Parse(parts[0]);   // Erste Zahl ins 'left'-Array
                right[i] = int.Parse(parts[1]);  // Zweite Zahl ins 'right'-Array
            }

            int count = 0;
            int z = 0;
            int y = 0;


            for (int i = 0; i < left.Length; i++)
            {
                count = 0;

                for (int j = 0; j < right.Length; j++)
                {
                    if (left[i] == right[j])
                    {
                        count++;
                    }
                }
                z = left[i] * count;
                y = y + z;
            }
            Console.WriteLine(y);
        }
    }
}
