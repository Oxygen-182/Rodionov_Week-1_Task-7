using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = string.Empty;
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                Console.Write("Введите осмысленное сообщение, содержащее знаки препинания: ");
                str = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(str))
                {
                    Console.Write("\n");
                    break;
                }
            }

            foreach (char c in str)
                if (char.IsPunctuation(c) || char.IsNumber(c)) sb.Append(" ");
                else sb.Append(c);

            string[] words = sb.ToString().Split(' ');

            List<string> result = new List<string>();

            long count = 0;
            foreach (string s in words)
            {
                if (!string.IsNullOrWhiteSpace(s))
                {
                    result.Add(s);
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("В сообщении нет слов\n");
                return;
            }

            Array.Sort(words, (x, y) => String.Compare(x, y));
            Console.WriteLine("Слова из сообщения в алфовитном порядке:\n");
            foreach (string s in words)
            {
                if (!string.IsNullOrWhiteSpace(s))
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
