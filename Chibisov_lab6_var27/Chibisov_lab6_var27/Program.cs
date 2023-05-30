using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] lines = File.ReadAllLines("C:\\Users\\ar22s\\OneDrive\\Рабочий стол\\input.txt");
        List<int> integers = new List<int>();
        List<double> doubles = new List<double>();
        List<char> chars = new List<char>();

        foreach (string line in lines)
        {
            string[] elements = line.Split(' ');
            foreach (string element in elements)
            {
                if (int.TryParse(element, out int intValue))
                {
                    integers.Add(intValue);
                }
                else if (double.TryParse(element, out double doubleValue))
                {
                    doubles.Add(doubleValue);
                }
                else if (char.TryParse(element, out char charValue))
                {
                    chars.Add(charValue);
                }
            }
        }

        integers.Sort();
        doubles.Sort();
        chars.Sort();

        using (StreamWriter writer = new StreamWriter($"integer({integers.Count}).txt"))
        {
            foreach (int value in integers)
            {
                writer.WriteLine(value);
            }
        }

        using (StreamWriter writer = new StreamWriter($"double({doubles.Count}).txt"))
        {
            foreach (double value in doubles)
            {
                writer.WriteLine(value);
            }
        }

        using (StreamWriter writer = new StreamWriter($"char({chars.Count}).txt"))
        {
            foreach (char value in chars)
            {
                writer.WriteLine(value);
            }
        }
    }
}
