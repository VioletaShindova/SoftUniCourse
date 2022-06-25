using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StreamReaderWriter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
        string name = "randomnumbers.txt";
        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sWriter = new StreamWriter(name, false, Encoding.GetEncoding("windows-1251"));

            Random random = new Random();

            for (int i = 0; i < 6; i++)
            {
                sWriter.WriteLine(random.Next(1, 80));
            }
            sWriter.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            StreamReader sReader = new StreamReader(name, Encoding.GetEncoding("windows-1251"));

            string line = "";

            while (line != null)
            {
                line = sReader.ReadLine();

                if(line != null)
                {
                    listBox1.Items.Add(line);
                }
            }
            sReader.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader sReader = new StreamReader(name, Encoding.GetEncoding("windows-1251"));

            string line = "";

            int sum = 0;

            while (line != null)
            {
                line = sReader.ReadLine();

                if (line != null)
                {
                    int n = int.Parse(line);
                    sum += n;
                }
            }
            sReader.Close();
            string message = "The sum is " + sum.ToString();
            MessageBox.Show(message, "Sum");

            StreamWriter sw = new StreamWriter(name, true, Encoding.GetEncoding("windows-1251"));
            sw.WriteLine(sum.ToString());
            sw.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox1.Text);
            listBox1.Items.Add(number);
        }
    }
}
