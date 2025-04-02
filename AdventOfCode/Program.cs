using System;

class Program
{
    // Die Main-Methode, die als Einstiegspunkt für das Programm dient.
    static void Main(string[] args)
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
        for(int i = 0; i < left.Length; i++) 
        {
            z = Math.Abs(left[i] - right[i]);
            y = y +z;
        }
        Console.WriteLine(y);
        Console.ReadKey();
    }
}
