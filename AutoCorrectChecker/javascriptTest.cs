using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCorrectChecker
{
    public partial class javascriptTest : Form
    {
        public javascriptTest()
        {
            InitializeComponent();
            labelCorrect.Hide();
            labelNotCorrect.Hide();
            bunifuButton3Test1.Hide();
            bunifuButton4Test1.Hide();
            bunifuButton5Test1.Hide();



            label1Test2.Hide();
            label2Test2.Hide();
            label3Test2.Hide();
            textBox1Test2.Hide();
            textBox2Test2.Hide();
            bunifuButton1Test2.Hide();
            bunifuButton2Test2.Hide();
            bunifuButton3Test2.Hide();
            bunifuButton4Test2.Hide();
            bunifuButton5Test2.Hide();



            label1Test3.Hide();
            label2Test3.Hide();
            label3Test3.Hide();
            label4Test3.Hide();
            label5Test3.Hide();
            label6Test3.Hide();
            label7Test3.Hide();
            textBox1Test3.Hide();
            textBox2Test3.Hide();
            textBox3Test3.Hide();
            bunifuButton1Test3.Hide();
            bunifuButton2Test3.Hide();
            bunifuButton3Test3.Hide();
            bunifuButton4Test3.Hide();
            bunifuButton5Test3.Hide();


            label1Test4.Hide();
            label2Test4.Hide();
            label3Test4.Hide();
            label4Test4.Hide();
            label5Test4.Hide();
            textBox1Test4.Hide();
            textBox2Test4.Hide();
            textBox3Test4.Hide();
            bunifuButton1Test4.Hide();
            bunifuButton2Test4.Hide();
            bunifuButton3Test4.Hide();
            bunifuButton4Test4.Hide();
            bunifuButton5Test4.Hide();


            label1Test5.Hide();
            label2Test5.Hide();
            label3Test5.Hide();
            label4Test5.Hide();
            label5Test5.Hide();
            label6Test5.Hide();
            label7Test5.Hide();
            label8Test5.Hide();
            textBox1Test5.Hide();
            textBox2Test5.Hide();
            textBox3Test5.Hide();
            textBox4Test5.Hide();
            textBox5Test5.Hide();
            bunifuButton1Test5.Hide();
            bunifuButton2Test5.Hide();
            bunifuButton3Test5.Hide();
            bunifuButton4Test5.Hide();
            bunifuButton5Test5.Hide();

        }
        private void bunifuButton1Test1_Click(object sender, EventArgs e)
        {
            if(textBox1Test1.Text == "carName" && textBox2Test1.Text == "Volvo")
            {
                panel1.BackColor = Color.FromArgb(0xD9, 0xEE, 0xE1);

                label1Test1.Hide();
                label2Test1.Hide();
                label3Test1.Hide();
                label4Test1.Hide();
                textBox1Test1.Hide();
                textBox2Test1.Hide();
                labelCorrect.Show();
                bunifuButton1Test1.Hide();
                bunifuButton2Test1.Hide();
                bunifuButton5Test1.Show();
                
            }
            else
            {
                panel1.BackColor = Color.FromArgb(0xFF, 0xC0, 0xC7);

                label1Test1.Hide();
                label2Test1.Hide();
                label3Test1.Hide();
                label4Test1.Hide();
                textBox1Test1.Hide();
                textBox2Test1.Hide();
                labelNotCorrect.Show();
                bunifuButton1Test1.Hide();
                bunifuButton2Test1.Hide();
                bunifuButton3Test1.Show();
            }
        }

        private void bunifuButton3Test1_Click(object sender, EventArgs e)
        {
            panel1.BackColor = SystemColors.ControlLight;

            textBox1Test1.Text = null;
            textBox2Test1.Text = null;

            label1Test1.Show();
            label2Test1.Show();
            label3Test1.Show();
            label4Test1.Show();
            textBox1Test1.Show();
            textBox2Test1.Show();
            labelNotCorrect.Hide();

            bunifuButton1Test1.Show();
            bunifuButton2Test1.Show();
            bunifuButton3Test1.Hide();
        }

        private void bunifuButton2Test1_Click(object sender, EventArgs e)
        {
            textBox1Test1.Text = "carName";
            textBox2Test1.Text = "Volvo";

            bunifuButton1Test1.Hide();
            bunifuButton2Test1.Hide();
            bunifuButton4Test1.Show();
        }

        private void bunifuButton4Test1_Click(object sender, EventArgs e)
        {
            textBox1Test1.Text = null;
            textBox2Test1.Text = null;

            bunifuButton1Test1.Show();
            bunifuButton2Test1.Show();
            bunifuButton4Test1.Hide();
        }

        private void bunifuButton5Test1_Click(object sender, EventArgs e)
        {
            panel1.BackColor = SystemColors.ControlLight;
            labelCorrect.Hide();
            bunifuButton5Test1.Hide();

            label1Test2.Show();
            label2Test2.Show();
            label3Test2.Show();
            textBox1Test2.Show();
            textBox2Test2.Show();
            bunifuButton1Test2.Show();
            bunifuButton2Test2.Show();
        }

        private void bunifuButton1Test2_Click(object sender, EventArgs e)
        {
            if (textBox1Test2.Text == "x" && textBox2Test2.Text == "50")
            {
                panel1.BackColor = Color.FromArgb(0xD9, 0xEE, 0xE1);

                label1Test2.Hide();
                label2Test2.Hide();
                label3Test2.Hide();
                textBox1Test2.Hide();
                textBox2Test2.Hide();
                labelCorrect.Show();
                bunifuButton1Test2.Hide();
                bunifuButton2Test2.Hide();
                bunifuButton5Test2.Show();

            }
            else
            {
                panel1.BackColor = Color.FromArgb(0xFF, 0xC0, 0xC7);

                label1Test2.Hide();
                label2Test2.Hide();
                label3Test2.Hide();
                textBox1Test2.Hide();
                textBox2Test2.Hide();
                labelNotCorrect.Show();
                bunifuButton1Test2.Hide();
                bunifuButton2Test2.Hide();
                bunifuButton3Test2.Show();
            }
        }

        private void bunifuButton3Test2_Click(object sender, EventArgs e)
        {
            panel1.BackColor = SystemColors.ControlLight;

            textBox1Test2.Text = null;
            textBox2Test2.Text = null;

            label1Test2.Show();
            label2Test2.Show();
            label3Test2.Show();
            textBox1Test2.Show();
            textBox2Test2.Show();
            labelNotCorrect.Hide();

            bunifuButton1Test2.Show();
            bunifuButton2Test2.Show();
            bunifuButton3Test2.Hide();
        }

        private void bunifuButton2Test2_Click(object sender, EventArgs e)
        {
            textBox1Test2.Text = "x";
            textBox2Test2.Text = "50";

            bunifuButton1Test2.Hide();
            bunifuButton2Test2.Hide();
            bunifuButton4Test2.Show();
        }

        private void bunifuButton4Test2_Click(object sender, EventArgs e)
        {
            textBox1Test2.Text = null;
            textBox2Test2.Text = null;

            bunifuButton1Test2.Show();
            bunifuButton2Test2.Show();
            bunifuButton4Test2.Hide();
        }

        private void bunifuButton5Test2_Click(object sender, EventArgs e)
        {
            panel1.BackColor = SystemColors.ControlLight;
            labelCorrect.Hide();
            bunifuButton5Test2.Hide();

            label1Test3.Show();
            label2Test3.Show();
            label3Test3.Show();
            label4Test3.Show();
            label5Test3.Show();
            label6Test3.Show();
            label7Test3.Show();
            textBox1Test3.Show();
            textBox2Test3.Show();
            textBox3Test3.Show();
            bunifuButton1Test3.Show();
            bunifuButton2Test3.Show();

        }

        private void bunifuButton1Test3_Click(object sender, EventArgs e)
        {
            if (textBox1Test3.Text == "x" && textBox2Test3.Text == "5" && textBox3Test3.Text == "+")
            {
                panel1.BackColor = Color.FromArgb(0xD9, 0xEE, 0xE1);

                label1Test3.Hide();
                label2Test3.Hide();
                label3Test3.Hide();
                label4Test3.Hide();
                label5Test3.Hide();
                label6Test3.Hide();
                label7Test3.Hide();
                textBox1Test3.Hide();
                textBox2Test3.Hide();
                textBox3Test3.Hide();
                bunifuButton1Test3.Hide();
                bunifuButton2Test3.Hide();
                bunifuButton5Test3.Show();
                labelCorrect.Show();
            }
            else
            {
                panel1.BackColor = Color.FromArgb(0xFF, 0xC0, 0xC7);

                label1Test3.Hide();
                label2Test3.Hide();
                label3Test3.Hide();
                label4Test3.Hide();
                label5Test3.Hide();
                label6Test3.Hide();
                label7Test3.Hide();
                textBox1Test3.Hide();
                textBox2Test3.Hide();
                textBox3Test3.Hide();
                bunifuButton1Test3.Hide();
                bunifuButton2Test3.Hide();
                bunifuButton3Test3.Show();
                labelNotCorrect.Show();

            }


        }

        private void bunifuButton3Test3_Click(object sender, EventArgs e)
        {
            panel1.BackColor = SystemColors.ControlLight;

            textBox1Test3.Text = null;
            textBox2Test3.Text = null;
            textBox3Test3.Text = null;

            label1Test3.Show();
            label2Test3.Show();
            label3Test3.Show();
            label4Test3.Show();
            label5Test3.Show();
            label6Test3.Show();
            label7Test3.Show();
            textBox1Test3.Show();
            textBox2Test3.Show();
            textBox3Test3.Show();
            labelNotCorrect.Hide();

            bunifuButton1Test3.Show();
            bunifuButton2Test3.Show();
            bunifuButton3Test3.Hide();
        }

        private void bunifuButton2Test3_Click(object sender, EventArgs e)
        {

            textBox1Test3.Text = "x";
            textBox2Test3.Text = "5";
            textBox3Test3.Text = "+";

            bunifuButton1Test3.Hide();
            bunifuButton2Test3.Hide();
            bunifuButton4Test3.Show();
        }

        private void bunifuButton4Test3_Click(object sender, EventArgs e)
        {
            textBox1Test3.Text = null;
            textBox2Test3.Text = null;
            textBox3Test3.Text = null;

            bunifuButton1Test3.Show();
            bunifuButton2Test3.Show();
            bunifuButton4Test3.Hide();
        }

        private void bunifuButton5Test3_Click(object sender, EventArgs e)
        {
            panel1.BackColor = SystemColors.ControlLight;
            labelCorrect.Hide();
            bunifuButton5Test3.Hide();

            label1Test4.Show();
            label2Test4.Show();
            label3Test4.Show();
            label4Test4.Show();
            label5Test4.Show();
            textBox1Test4.Show();
            textBox2Test4.Show();
            textBox3Test4.Show();
            bunifuButton1Test4.Show();
            bunifuButton2Test4.Show();



        }

        private void bunifuButton1Test4_Click(object sender, EventArgs e)
        {
            if (textBox1Test4.Text == "var" && textBox2Test4.Text == "z" && textBox3Test4.Text == "alert")
            {
                panel1.BackColor = Color.FromArgb(0xD9, 0xEE, 0xE1);

                label1Test4.Hide();
                label2Test4.Hide();
                label3Test4.Hide();
                label4Test4.Hide();
                label5Test4.Hide();
                textBox1Test4.Hide();
                textBox2Test4.Hide();
                textBox3Test4.Hide();
                bunifuButton1Test4.Hide();
                bunifuButton2Test4.Hide();
                bunifuButton5Test4.Show();
                labelCorrect.Show();
            }
            else
            {
                panel1.BackColor = Color.FromArgb(0xFF, 0xC0, 0xC7);

                label1Test4.Hide();
                label2Test4.Hide();
                label3Test4.Hide();
                label4Test4.Hide();
                label5Test4.Hide();
                textBox1Test4.Hide();
                textBox2Test4.Hide();
                textBox3Test4.Hide();
                bunifuButton1Test4.Hide();
                bunifuButton2Test4.Hide();
                bunifuButton3Test4.Show();
                labelNotCorrect.Show();

            }

        }

        private void bunifuButton3Test4_Click(object sender, EventArgs e)
        {
            panel1.BackColor = SystemColors.ControlLight;

            textBox1Test4.Text = null;
            textBox2Test4.Text = null;
            textBox3Test4.Text = null;

            label1Test4.Show();
            label2Test4.Show();
            label3Test4.Show();
            label4Test4.Show();
            label5Test4.Show();
            textBox1Test4.Show();
            textBox2Test4.Show();
            textBox3Test4.Show();
            labelNotCorrect.Hide();

            bunifuButton1Test4.Show();
            bunifuButton2Test4.Show();
            bunifuButton3Test4.Hide();
        }

        private void bunifuButton2Test4_Click(object sender, EventArgs e)
        {
            textBox1Test4.Text = "var";
            textBox2Test4.Text = "z";
            textBox3Test4.Text = "alert";

            bunifuButton1Test4.Hide();
            bunifuButton2Test4.Hide();
            bunifuButton4Test4.Show();
        }

        private void bunifuButton4Test4_Click(object sender, EventArgs e)
        {
            textBox1Test4.Text = null;
            textBox2Test4.Text = null;
            textBox3Test4.Text = null;

            bunifuButton1Test4.Show();
            bunifuButton2Test4.Show();
            bunifuButton4Test4.Hide();
        }

        private void bunifuButton5Test4_Click(object sender, EventArgs e)
        {
            panel1.BackColor = SystemColors.ControlLight;
            labelCorrect.Hide();
            bunifuButton5Test4.Hide();

            label1Test5.Show();
            label2Test5.Show();
            label3Test5.Show();
            label4Test5.Show();
            label5Test5.Show();
            label6Test5.Show();
            label7Test5.Show();
            label8Test5.Show();
            textBox1Test5.Show();
            textBox2Test5.Show();
            textBox3Test5.Show();
            textBox4Test5.Show();
            textBox5Test5.Show();
            bunifuButton1Test5.Show();
            bunifuButton2Test5.Show();

        }

        private void bunifuButton1Test5_Click(object sender, EventArgs e)
        {
            if (textBox1Test5.Text == "firstName" && textBox2Test5.Text == "," && textBox3Test5.Text == "\"Berisha\"," && textBox4Test5.Text == "height" && textBox5Test5.Text == "190cm")
            {
                panel1.BackColor = Color.FromArgb(0xD9, 0xEE, 0xE1);

                label1Test5.Hide();
                label2Test5.Hide();
                label3Test5.Hide();
                label4Test5.Hide();
                label5Test5.Hide();
                label6Test5.Hide();
                label7Test5.Hide();
                label8Test5.Hide();
                textBox1Test5.Hide();
                textBox2Test5.Hide();
                textBox3Test5.Hide();
                textBox4Test5.Hide();
                textBox5Test5.Hide();
                bunifuButton1Test5.Hide();
                bunifuButton2Test5.Hide();
                bunifuButton5Test5.Show();
                labelCorrect.Show();
            }
            else
            {
                panel1.BackColor = Color.FromArgb(0xFF, 0xC0, 0xC7);

                label1Test5.Hide();
                label2Test5.Hide();
                label3Test5.Hide();
                label4Test5.Hide();
                label5Test5.Hide();
                label6Test5.Hide();
                label7Test5.Hide();
                label8Test5.Hide();
                textBox1Test5.Hide();
                textBox2Test5.Hide();
                textBox3Test5.Hide();
                textBox4Test5.Hide();
                textBox5Test5.Hide();
                bunifuButton1Test5.Hide();
                bunifuButton2Test5.Hide();
                bunifuButton3Test5.Show();
                labelNotCorrect.Show();

            }
        }

        private void bunifuButton3Test5_Click(object sender, EventArgs e)
        {
            panel1.BackColor = SystemColors.ControlLight;

            textBox1Test5.Text = null;
            textBox2Test5.Text = null;
            textBox3Test5.Text = null;
            textBox4Test5.Text = null;
            textBox5Test5.Text = null;

            label1Test5.Show();
            label2Test5.Show();
            label3Test5.Show();
            label4Test5.Show();
            label5Test5.Show();
            label6Test5.Show();
            label7Test5.Show();
            label8Test5.Show();
            textBox1Test5.Show();
            textBox2Test5.Show();
            textBox3Test5.Show();
            textBox4Test5.Show();
            textBox5Test5.Show();
            labelNotCorrect.Hide();

            bunifuButton1Test5.Show();
            bunifuButton2Test5.Show();
            bunifuButton3Test5.Hide();
        }

        private void bunifuButton2Test5_Click(object sender, EventArgs e)
        {
            textBox1Test5.Text = "firstName";
            textBox2Test5.Text = ",";
            textBox3Test5.Text = "\"Berisha\",";
            textBox4Test5.Text = "height";
            textBox5Test5.Text = "190cm";

            bunifuButton1Test5.Hide();
            bunifuButton2Test5.Hide();
            bunifuButton4Test5.Show();
        }

        private void bunifuButton4Test5_Click(object sender, EventArgs e)
        {
            textBox1Test5.Text = null;
            textBox2Test5.Text = null;
            textBox3Test5.Text = null;
            textBox4Test5.Text = null;
            textBox5Test5.Text = null;

            bunifuButton1Test5.Show();
            bunifuButton2Test5.Show();
            bunifuButton4Test5.Hide();
        }

        private void bunifuButton5Test5_Click(object sender, EventArgs e)
        {
            var backToForm1 = new Form1();
            backToForm1.Show();
            this.Hide();
        }
    }
 }

