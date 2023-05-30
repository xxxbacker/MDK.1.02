using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


namespace ReverseString
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Заданаие 1");
                Console.Write("Введите строку: ");
                string input = Console.ReadLine();

                char[] chars = input.ToCharArray();
                Array.Reverse(chars);

                Console.WriteLine(new string(chars));

                Console.WriteLine("Задание 2");

            string text = "fffoofflkfgo fbshbhgvdsfoosgrjfg jnrdjgbjsrdbjgoojs fn rgjkng rsgjjksrg rgdsfgoo";
            string[] words = text.Split(' ');

            int count = 0;
            foreach (string word in words)
            {
                int oCount = 0;
                foreach (char c in word)
                {
                    if (c == 'o')
                    {
                        oCount++;
                    }
                }
                if (oCount > 2)
                {
                    count++;
                }
            }

            Console.WriteLine("Количество слов с более чем двумя 'о': " + count);
        }
        }
    }
