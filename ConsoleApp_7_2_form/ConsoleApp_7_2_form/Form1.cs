using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp_7_2_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();

            string str = string.Empty;
            StringBuilder sb = new StringBuilder();

            while (true)
            {
                str = textBox1.Text;

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

            int count = 0;
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
                textBox2.Text += "В сообщении нет слов\n";
                return;
            }

            Array.Sort(words, (x, y) => String.Compare(x, y));
            textBox2.Text += "Слова из сообщения в алфовитном порядке: " + Environment.NewLine + Environment.NewLine;

            foreach (string s in words)
            {
                if (!string.IsNullOrWhiteSpace(s))
                {
                    textBox2.Text += s + Environment.NewLine;
                }
            }
        }
    }
}
