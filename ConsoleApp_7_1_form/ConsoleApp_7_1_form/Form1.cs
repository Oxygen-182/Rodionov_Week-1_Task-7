using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp_7_1_form
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

            string s = textBox1.Text;

            int count = 0;
            foreach (char c in s)
                if (c == ',') count++;

            if (count != 2)
            {
                textBox2.Text += "Нужно ввести две запятые!";
                return;
            }

            int pos1 = s.IndexOf(',');
            int pos2 = -1;
            if (pos1 >= 0)
                pos2 = s.IndexOf(',', pos1 + 1);
            if (pos1 >= 0 && pos2 >= 0)
                s = s.Remove(pos1 + 1, pos2 - pos1 - 1);

            textBox2.Text += s;
        }
    }
}
