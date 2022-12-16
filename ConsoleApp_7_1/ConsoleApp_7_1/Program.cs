using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку, содержащую 2 запятые: ");
            string text = Console.ReadLine();

            int count = 0;
            foreach (char c in text)
                if (c == ',') count++;

            if (count != 2)
            {
                Console.WriteLine("Нужно ввести две запятые!");
                return;
            }

            int pos1 = text.IndexOf(',');
            int pos2 = -1;
            if (pos1 >= 0)
                pos2 = text.IndexOf(',', pos1 + 1);
            if (pos1 >= 0 && pos2 >= 0)
                text = text.Remove(pos1 + 1, pos2 - pos1 - 1);
            Console.WriteLine($"Измененная строка: {text}");
            Console.ReadKey(true);
        }
    }
}
