using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EGNForms
{
    public partial class Form1 : Form
    {
        int firstNumber;
        int seconNumber;
        int thirdNumber;
        int fifthNumber;
        int sixthNumber;
        int seventhNumber;
        int eightNumber;
        int ninthNumber;
        int tenthNumber;

        public Form1()
        {
            InitializeComponent();
        }
        private void SettingNumbers(long egn)
        {
            int firstNumber = GetFirstNumberOfEGN(egn);
            int secondNumber = GetFirstNumberOfEGN(egn);
            int thirdNumber = GetThirdNumberOfEGN(egn);
            int fourthNumber = GetFourthNumberOfEGN(egn);
            int fifthNumber = GetFifthNumberOfEGN(egn);
            int sixthNumber = GetSixthNumberOfEGN(egn);
            int seventhNumber = GetSeventhNumberOfEGN(egn);
            int eighthNumber = GetEighthNumberOfEGN(egn);
            int ninthNumber = GetNinthNumberOfEGN(egn);
            int tenthNumber = GetTenthNumberOfEGN(egn);
        }

        
        /// <summary>
        /// Check if egn has 10 numbers.
        /// </summary>
        /// <param name="egn"> The egn that is entered. </param>
        /// <returns></returns>
        public bool CheckValidation(long egn)
        {
            if (egn == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            long egn = long.Parse(textBox1.Text);
            
            if(CheckValidation(egn)==true)
            {
                MessageBox.Show("Валидно ЕГН. Искате ли да продължите?", "Валидност",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                DialogResult result = MessageBox.Show("Валидно ЕГН. Искате ли да продължите?", "Валидност",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    label2.Text = "Valid. You can continue.";
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                    button6.Enabled = true;
                }
                else
                {
                    label2.Text = "Invadil. You can't continue.";
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                }
            }
            else
            {
                label2.Text = "Invalid.";
                textBox1.Text = "";
                label4.Text = "";
                label6.Text = "";
                label8.Text = "";
                label10.Text = "";
                label12.Text = "";
            }
        }
        //methods for separating the numbers from the EGN
        private int GetFirstNumberOfEGN(long egn)
        {
            return (int)(egn / 1000000000 % 10);
        }
        private int GetSecondNumberOfEGN(long egn)
        {
            return (int)(egn / 100000000 % 10);
        }
        private int GetThirdNumberOfEGN(long eng)
        {
            return (int)(eng / 10000000 % 10);
        }
        private int GetFourthNumberOfEGN(long egn)
        {
            return (int)(egn / 1000000 % 10);
        }
        private int GetFifthNumberOfEGN(long egn)
        {
            return (int)(egn / 100000 % 10);
        }
        private int GetSixthNumberOfEGN(long egn)
        {
            return (int)(egn / 10000 % 10);
        }
        private int GetSeventhNumberOfEGN(long egn)
        {
            return (int)(egn / 1000 % 10);
        }
        private int GetEighthNumberOfEGN(long egn)
        {
            return (int)(egn / 100 % 10);
        }
        private int GetNinthNumberOfEGN(long egn)
        {
            return (int)(egn / 10 % 10);
        }
        private int GetTenthNumberOfEGN(long egn)
        {
            return (int)(egn % 10);
        }
        private bool CheckForMonth(long egn)
        {
            fifthNumber = GetFifthNumberOfEGN(egn);
            sixthNumber = GetSixthNumberOfEGN(egn);

            if (fifthNumber >= 0 && fifthNumber <= 9 && sixthNumber >=0 && sixthNumber <= 9)
            {
                return true;
            }
            else
            {
                return false;   
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            long egn = long.Parse(textBox1.Text);

        }
        /// <summary>
        /// Check the gender of the person.
        /// </summary>
        /// <param name="egn"> The EGN entered. </param>
        /// <returns></returns>
        private string CheckGender(long egn)
        {
            ninthNumber = GetNinthNumberOfEGN(egn);
            if(ninthNumber % 2 == 0)
            {
                return "Male";
            }
            else
            {
                return "Female";
            }
        }
        // CheckForGender
        private void button6_Click(object sender, EventArgs e)
        {
            long egn = long.Parse(textBox1.Text);
            label12.Text = CheckGender(egn);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
