using System;
using System.IO;

class Day1
{
    static void Main(string[] args)
    {
        
        string path = @"C:\Users\joshu\source\repos\Advent of Code\Day 1\Liste.txt";
        string text = File.ReadAllText(path);

        
        string[] lines = text.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        
        int[] column1 = new int[lines.Length];
        int[] column2 = new int[lines.Length];

        for (int i = 0; i < lines.Length; i++)
        {
            
            string[] parts = lines[i].Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length == 2)
            {
                column1[i] = int.Parse(parts[0]);
                column2[i] = int.Parse(parts[1]);
            }
            else
            {
                Console.WriteLine($"Fehler in Zeile {i + 1}: {lines[i]}");
            }
        }
        Array.Sort(column1);
        Array.Sort(column2);

        int[] dif = new int[column1.Length];
        for (int x = 0; x < column1.Length; x++)
        {
            dif[x] = Math.Abs(column1[x] - column2[x]);
        }

        int counter = 0;
        long final = 0;

        for (int y = 0; y < column1.Length; y++)
        {
            counter = 0;
            for(int x = 0; x < column2.Length; x++)
            {
                if (column1[y] == column2[x])
                {
                    counter++;
                }
                
            }
            final += (counter * column1[y]);
            
        }


        Console.WriteLine("Column 1            Column 2           Difference");
        for (int i = 0; i < column2.Length; i++)
        {
            Console.Write(column2[i]);
            Console.Write($"               {column1[i]}              ");
            Console.WriteLine(dif[i]);
        }
        int summe = 0;
        for (int i = 0; i < dif.Length; i++)
        {
            summe += dif[i];
        }


        Console.WriteLine($"Gesammte Strecke: {summe}");
        Console.WriteLine(final);
    }
}