using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO
{
    public partial class Form1 : Form
    {
        bool a1, a2, a3, a4, a5, a6, a7, a8, a9;
        bool b1, b2, b3, b4, b5, b6, b7, b8, b9;
        int a = 0;
        int b = 0;
        


        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a++;
            b = a % 2;
            if (b == 0)
            {
                button1.BackColor = Color.Red;
                b1 = true;
            }
            else {
                button1.BackColor = Color.Blue;
                a1 = true;
            }
            button1.Enabled = false;
            if ((a1 && a2 && a3) || (a4 && a5 && a6) || (a7 && a8 && a9) || (a1 && a8 && a6)
    || (a1 && a8 && a6) || (a4 && a8 && a3) || (a1 && a7 && a4)
     || (a2 && a8 && a5) || (a3 && a9 && a6))
            {
                richTextBox1.Visible = true;
            }
            if ((b1 && b2 && b3) || (b4 && b5 && b6) || (b7 && b8 && b9) || (b1 && b8 && b6)
            || (b1 && b8 && b6) || (b4 && b8 && b3) || (b1 && b7 && b4)
            || (b2 && b8 && b5) || (b3 && b9 && b6))
            {
                richTextBox2.Visible = true;
            }
            if (a == 9)
            {
                richTextBox3.Visible = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            a++;
            b = a % 2;
            if (b == 0)
            {
                button2.BackColor = Color.Red;
                b2 = true;
            }
            else
            {
                button2.BackColor = Color.Blue;
                a2 = true;
            }
            button2.Enabled = false;
            if ((a1 && a2 && a3) || (a4 && a5 && a6) || (a7 && a8 && a9) || (a1 && a8 && a6)
    || (a1 && a8 && a6) || (a4 && a8 && a3) || (a1 && a7 && a4)
     || (a2 && a8 && a5) || (a3 && a9 && a6))
            {
                richTextBox1.Visible = true;
            }
            if ((b1 && b2 && b3) || (b4 && b5 && b6) || (b7 && b8 && b9) || (b1 && b8 && b6)
            || (b1 && b8 && b6) || (b4 && b8 && b3) || (b1 && b7 && b4)
            || (b2 && b8 && b5) || (b3 && b9 && b6))
            {
                richTextBox2.Visible = true;
            }
            if (a == 9)
            {
                richTextBox3.Visible = true;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a++;
            b = a % 2;
            if (b == 0)
            {
                button3.BackColor = Color.Red;
                b3 = true;
            }
            else
            {
                button3.BackColor = Color.Blue;
                a3 = true;
            }
            button3.Enabled = false;
            if ((a1 && a2 && a3) || (a4 && a5 && a6) || (a7 && a8 && a9) || (a1 && a8 && a6)
    || (a1 && a8 && a6) || (a4 && a8 && a3) || (a1 && a7 && a4)
     || (a2 && a8 && a5) || (a3 && a9 && a6))
            {
                richTextBox1.Visible = true;
            }
            if ((b1 && b2 && b3) || (b4 && b5 && b6) || (b7 && b8 && b9) || (b1 && b8 && b6)
            || (b1 && b8 && b6) || (b4 && b8 && b3) || (b1 && b7 && b4)
            || (b2 && b8 && b5) || (b3 && b9 && b6))
            {
                richTextBox2.Visible = true;
            }
            if (a == 9)
            {
                richTextBox3.Visible = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            a++;
            b = a % 2;
            if (b == 0)
            {
                button7.BackColor = Color.Red;
                b7 = true;
            }
            else
            {
                button7.BackColor = Color.Blue;
                a7 = true;
            }
            button7.Enabled = false;
            if ((a1 && a2 && a3) || (a4 && a5 && a6) || (a7 && a8 && a9) || (a1 && a8 && a6)
    || (a1 && a8 && a6) || (a4 && a8 && a3) || (a1 && a7 && a4)
     || (a2 && a8 && a5) || (a3 && a9 && a6))
            {
                richTextBox1.Visible = true;
            }
            if ((b1 && b2 && b3) || (b4 && b5 && b6) || (b7 && b8 && b9) || (b1 && b8 && b6)
            || (b1 && b8 && b6) || (b4 && b8 && b3) || (b1 && b7 && b4)
            || (b2 && b8 && b5) || (b3 && b9 && b6))
            {
                richTextBox2.Visible = true;
            }
            if (a == 9)
            {
                richTextBox3.Visible = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            a++;
            b = a % 2;
            if (b == 0)
            {
                button8.BackColor = Color.Red;
                b8 = true;
            }
            else
            {
                button8.BackColor = Color.Blue;
                a8 = true;
            }
            button8.Enabled = false;
            if ((a1 && a2 && a3) || (a4 && a5 && a6) || (a7 && a8 && a9) || (a1 && a8 && a6)
    || (a1 && a8 && a6) || (a4 && a8 && a3) || (a1 && a7 && a4)
     || (a2 && a8 && a5) || (a3 && a9 && a6))
            {
                richTextBox1.Visible = true;
            }
            if ((b1 && b2 && b3) || (b4 && b5 && b6) || (b7 && b8 && b9) || (b1 && b8 && b6)
            || (b1 && b8 && b6) || (b4 && b8 && b3) || (b1 && b7 && b4)
            || (b2 && b8 && b5) || (b3 && b9 && b6))
            {
                richTextBox2.Visible = true;
            }
            if (a == 9)
            {
                richTextBox3.Visible = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {


            a++;
            b = a % 2;
            if (b == 0)
            {
                button9.BackColor = Color.Red;
                b9 = true;
            }
            else
            {
                button9.BackColor = Color.Blue;
                a9 = true;
            }
            button9.Enabled = false;
            if ((a1 && a2 && a3) || (a4 && a5 && a6) || (a7 && a8 && a9) || (a1 && a8 && a6)
    || (a1 && a8 && a6) || (a4 && a8 && a3) || (a1 && a7 && a4)
     || (a2 && a8 && a5) || (a3 && a9 && a6))
            {
                richTextBox1.Visible = true;
            }
            if ((b1 && b2 && b3) || (b4 && b5 && b6) || (b7 && b8 && b9) || (b1 && b8 && b6)
            || (b1 && b8 && b6) || (b4 && b8 && b3) || (b1 && b7 && b4)
            || (b2 && b8 && b5) || (b3 && b9 && b6))
            {
                richTextBox2.Visible = true;
            }
            if (a == 9)
            {
                richTextBox3.Visible = true;
            }
        }
            
        private void button4_Click(object sender, EventArgs e)
        {

            a++;
            b = a % 2;
            if (b == 0)
            {
                button4.BackColor = Color.Red;
                b4 = true;
            }
            else
            {
                button4.BackColor = Color.Blue;
                a4 = true;
            }
            button4.Enabled = false;
            if ((a1 && a2 && a3) || (a4 && a5 && a6) || (a7 && a8 && a9) || (a1 && a8 && a6)
    || (a1 && a8 && a6) || (a4 && a8 && a3) || (a1 && a7 && a4)
     || (a2 && a8 && a5) || (a3 && a9 && a6))
            {
                richTextBox1.Visible = true;
            }
            if ((b1 && b2 && b3) || (b4 && b5 && b6) || (b7 && b8 && b9) || (b1 && b8 && b6)
            || (b1 && b8 && b6) || (b4 && b8 && b3) || (b1 && b7 && b4)
            || (b2 && b8 && b5) || (b3 && b9 && b6))
            {
                richTextBox2.Visible = true;
            }
            if (a == 9)
            {
                richTextBox3.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            a++;
            b = a % 2;
            if (b == 0)
            {
                button5.BackColor = Color.Red;
                b5 = true;
            }
            else
            {
                button5.BackColor = Color.Blue;
                a5 = true;
            }
            button5.Enabled = false;
            if ((a1 && a2 && a3) || (a4 && a5 && a6) || (a7 && a8 && a9) || (a1 && a8 && a6)
    || (a1 && a8 && a6) || (a4 && a8 && a3) || (a1 && a7 && a4)
     || (a2 && a8 && a5) || (a3 && a9 && a6))
            {
                richTextBox1.Visible = true;
            }
            if ((b1 && b2 && b3) || (b4 && b5 && b6) || (b7 && b8 && b9) || (b1 && b8 && b6)
            || (b1 && b8 && b6) || (b4 && b8 && b3) || (b1 && b7 && b4)
            || (b2 && b8 && b5) || (b3 && b9 && b6))
            {
                richTextBox2.Visible = true;
            }
            if (a == 9)
            {
                richTextBox3.Visible = true;
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

            a++;
            b = a % 2;
            if (b == 0)
            {
                button6.BackColor = Color.Red;
                b6 = true;
            }
            else
            {
                button6.BackColor = Color.Blue;
                a6 = true;
            }
            button6.Enabled = false;
            if ((a1 && a2 && a3) || (a4 && a5 && a6) || (a7 && a8 && a9) || (a1 && a8 && a6)
                || (a1 && a8 && a6) || (a4 && a8 && a3) || (a1 && a7 && a4)
                 || (a2 && a8 && a5) || (a3 && a9 && a6))
            {
                richTextBox1.Visible = true;
            }
            if ((b1 && b2 && b3) || (b4 && b5 && b6) || (b7 && b8 && b9) || (b1 && b8 && b6)
            || (b1 && b8 && b6) || (b4 && b8 && b3) || (b1 && b7 && b4)
            || (b2 && b8 && b5) || (b3 && b9 && b6))
            {
                richTextBox2.Visible = true;
            }
            if (a == 9)
            {
                richTextBox3.Visible = true;                
            }
        }

        private void webHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/");
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
