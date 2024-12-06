namespace Day_2
{
    internal class Day2
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\joshu\source\repos\Advent of Code\Day 2\Levels.txt";

            string text = File.ReadAllText(path);

            string[] lines = text.Split(new[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < lines.Length; i++)
            {                
                string[] newArray = lines[i].Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine(newArray);
            }
            
        }
    }
}
