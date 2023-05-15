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
    public partial class htmlTest : Form
    {
        public htmlTest()
        {
            InitializeComponent();
            label3.Hide();
            label4.Hide();
            bunifuButton3.Hide();
            bunifuButton4.Hide();
            bunifuButton5.Hide();


            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            textBox2.Hide();
            textBox3.Hide();
            bunifuButton6.Hide();
            bunifuButton7.Hide();
            bunifuButton8.Hide();
            bunifuButton9.Hide();
            bunifuButton10.Hide();

            label1Test3.Hide();
            label2Test3.Hide();
            label3Test3.Hide();
            textBox1Test3.Hide();
            bunifuButton1Test3.Hide();
            bunifuButton2Test3.Hide();
            bunifuButton3Test3.Hide();
            bunifuButton4Test3.Hide();
            bunifuButton5Test3.Hide();


            label1Test4.Hide();
            label2Test4.Hide();
            label3Test4.Hide();
            textBox1Test4.Hide();
            bunifuButton1Test4.Hide();
            bunifuButton2Test4.Hide();
            bunifuButton3Test4.Hide();
            bunifuButton4Test4.Hide();
            bunifuButton5Test4.Hide();




            label1Test5.Hide();
            label2Test5.Hide();
            textBox1Test5.Hide();
            bunifuButton1Test5.Hide();
            bunifuButton2Test5.Hide();
            bunifuButton3Test5.Hide();
            bunifuButton4Test5.Hide();
            bunifuButton5Test5.Hide();


        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "title")
            {
                panel1.BackColor = Color.FromArgb(0xD9, 0xEE, 0xE1);
                label1.Hide();
                label2.Hide();
                textBox1.Hide();
                label3.Show();
                bunifuButton1.Hide();
                bunifuButton2.Hide();
                bunifuButton3.Show();
                label5.Hide();
            }

            else
            {
                panel1.BackColor = Color.FromArgb(0xFF, 0xC0, 0xC7);
                label1.Hide();
                label2.Hide();
                textBox1.Hide();
                label4.Show();
                bunifuButton1.Hide();
                bunifuButton2.Hide();
                bunifuButton5.Show();
                label5.Hide();
            }
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            panel1.BackColor = SystemColors.ControlLight;
            label1.Show(); 
            label2.Show();
            label3.Hide();
            label4.Hide();
            textBox1.Show();
            textBox1.Text = null;
            bunifuButton5.Hide() ;
            bunifuButton1.Show();
            bunifuButton2.Show();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "title";
            bunifuButton1.Hide();
            bunifuButton3 .Hide();
            bunifuButton5 .Hide();
            bunifuButton2.Hide();
            bunifuButton4.Show();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            bunifuButton4.Hide();
            bunifuButton2.Show() ;
            bunifuButton1.Show() ;
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            panel1.BackColor = SystemColors.ControlLight;
            textBox1.Hide();
            label1.Hide();
            label2 .Hide();
            label3.Hide();
            label4 .Hide();
            label5.Hide();
            bunifuButton1 .Hide();
            bunifuButton2 .Hide();
            bunifuButton3.Hide();
            bunifuButton4 .Hide();
            bunifuButton5.Hide();
            bunifuButton6.Show();
            bunifuButton7 .Show();


            label6.Show();
            label7.Show();
            label8.Show();
            label9.Show();
            textBox2.Show();
            textBox3.Show();
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "250" && textBox3.Text == "400")
            {
                panel1.BackColor = Color.FromArgb(0xD9, 0xEE, 0xE1);
                textBox2.Hide();
                textBox3 .Hide();
                label3.Show();
                label6 .Hide();
                label7.Hide();
                label8.Hide();
                label9.Hide();
                bunifuButton6 .Hide();
                bunifuButton7.Hide();
                bunifuButton8.Show();
            }

            else
            {
                panel1.BackColor = Color.FromArgb(0xFF, 0xC0, 0xC7);
                textBox2.Hide();
                textBox3.Hide();
                label4.Show();
                label6.Hide();
                label7.Hide();
                label8.Hide();
                label9.Hide();
                bunifuButton6.Hide();
                bunifuButton7.Hide();
                bunifuButton10.Show();
            }
        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {

            panel1.BackColor = SystemColors.ControlLight;

            label3.Hide();
            label4 .Hide();

            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            
            
            textBox2.Hide();
            textBox3.Hide() ;

            bunifuButton6.Hide() ;
            bunifuButton7.Hide() ;  
            bunifuButton8.Hide() ;
            bunifuButton9 .Hide();
            bunifuButton10.Hide();


            label1Test3.Show();
            label2Test3.Show();
            label3Test3.Show();
            
            textBox1Test3.Show();

            bunifuButton1Test3.Show();
            bunifuButton2Test3.Show();
            bunifuButton3Test3.Hide();
            bunifuButton4Test3.Hide();
            bunifuButton5Test3.Hide();


        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            textBox2.Text = "250";
            textBox3.Text = "400";
            bunifuButton6.Hide();
            bunifuButton7.Hide();
            bunifuButton8 .Hide();
            bunifuButton9.Show();
            bunifuButton10 .Hide();
        }

        private void bunifuButton9_Click(object sender, EventArgs e)
        {
            textBox2.Text = null;
            textBox3.Text= null;
            bunifuButton6.Show();
            bunifuButton7.Show();
            bunifuButton8 .Hide();
            bunifuButton9.Hide();
            bunifuButton10.Hide();
        }

        private void bunifuButton10_Click(object sender, EventArgs e)
        {
            textBox2.Text = null;
            textBox3.Text = null;   
          
            textBox2.Show();
            textBox3.Show();
         
            label3.Hide();
            label4.Hide();
            label6.Show();
            label7.Show();
            label8.Show();
            label9.Show();

            bunifuButton6 .Show();
            bunifuButton7.Show();
            bunifuButton10.Hide() ;

            panel1.BackColor = SystemColors.ControlLight;
        }

        private void bunifuButton1Test3_Click(object sender, EventArgs e)
        {
            if(textBox1Test3.Text == "href=")
            {
                panel1.BackColor = Color.FromArgb(0xD9, 0xEE, 0xE1);
                label1Test3.Hide();
                label2Test3.Hide();
                label3Test3.Hide();
                label3.Show();

                textBox1Test3.Hide() ;

                bunifuButton1Test3.Hide();
                bunifuButton2Test3.Hide();
                bunifuButton3Test3.Hide();
                bunifuButton4Test3.Hide();
                bunifuButton5Test3.Show();
            }


            else
            {
                panel1.BackColor = Color.FromArgb(0xFF, 0xC0, 0xC7);

                label1Test3.Hide();
                label2Test3.Hide();
                label3Test3.Hide();
                label4.Show();
                textBox1Test3.Hide();

                bunifuButton1Test3.Hide();
                bunifuButton2Test3.Hide();
                bunifuButton3Test3.Show();
                bunifuButton4Test3.Hide();
                bunifuButton5Test3.Hide();
            }
        }

        private void bunifuButton3Test3_Click(object sender, EventArgs e)
        {


            panel1.BackColor = SystemColors.ControlLight;

            label1Test3.Show();
            label2Test3.Show();
            label3Test3.Show();
            label4.Hide();
            textBox1Test3.Text = null;
            textBox1Test3.Show();

            bunifuButton1Test3.Show();
            bunifuButton2Test3.Show();
            bunifuButton3Test3.Hide();
        }

        private void bunifuButton2Test3_Click(object sender, EventArgs e)
        {
            textBox1Test3.Text = "href=";

            bunifuButton1Test3.Hide();
            bunifuButton2Test3.Hide();
            bunifuButton4Test3.Show();
        }

        private void bunifuButton4Test3_Click(object sender, EventArgs e)
        {
            textBox1Test3.Text = null;

            bunifuButton1Test3.Show();
            bunifuButton2Test3.Show();
            bunifuButton4Test3.Hide();
        }

        private void bunifuButton1Test4_Click(object sender, EventArgs e)
        {
            if(textBox1Test4.Text == "alt")
            {
                panel1.BackColor = Color.FromArgb(0xD9, 0xEE, 0xE1);

                label1Test4.Hide();
                label2Test4.Hide();
                label3Test4.Hide();
                label3.Show();

                textBox1Test4.Hide() ;

                bunifuButton1Test4.Hide();
                bunifuButton2Test4.Hide();
                bunifuButton5Test4.Show();
            }

            else
            {
                panel1.BackColor = Color.FromArgb(0xFF, 0xC0, 0xC7);

                label1Test4.Hide();
                label2Test4.Hide();
                label3Test4.Hide();
                label4.Show();

                textBox1Test4.Hide();

                bunifuButton1Test4.Hide();
                bunifuButton2Test4.Hide();
                bunifuButton3Test4.Show();
            }
        }

        private void bunifuButton5Test3_Click(object sender, EventArgs e)
        {

            panel1.BackColor = SystemColors.ControlLight;

            label1Test3.Hide();
            label2Test3.Hide();
            label3Test3.Hide();
            label3.Hide();
            textBox1Test3.Hide() ;

            bunifuButton1Test3.Hide();
            bunifuButton2Test3.Hide();
            bunifuButton3Test3.Hide();
            bunifuButton4Test3.Hide();
            bunifuButton5Test3.Hide();

            bunifuButton1Test4.Show();
            bunifuButton2Test4.Show();

            label1Test4.Show();
            label2Test4.Show();
            label3Test4.Show();
            textBox1Test4.Show();


        }

        private void bunifuButton2Test4_Click(object sender, EventArgs e)
        {
            textBox1Test4.Text = "alt";

            bunifuButton1Test4.Hide() ;
            bunifuButton2Test4.Hide();
            bunifuButton4Test4.Show();
        }

        private void bunifuButton4Test4_Click(object sender, EventArgs e)
        {
            textBox1Test4.Text = null;

            bunifuButton1Test4.Show();
            bunifuButton2Test4.Show();
            bunifuButton4Test4.Hide();
        }

        private void bunifuButton3Test4_Click(object sender, EventArgs e)
        {
            textBox1Test4.Text = null;
            panel1.BackColor = SystemColors.ControlLight;

            label1Test4.Show();
            label2Test4.Show();
            label3Test4.Show();
            label4.Hide();
            textBox1Test4.Show();

            bunifuButton1Test4.Show();
            bunifuButton2Test4.Show();
            bunifuButton3Test4.Hide();

        }

        private void bunifuButton5Test4_Click(object sender, EventArgs e)
        {
            panel1.BackColor = SystemColors.ControlLight;

            label1Test4.Hide();
            label2Test4.Hide();
            label3Test4.Hide();
            label3.Hide();
            textBox1Test4.Hide();

            bunifuButton1Test4.Hide();
            bunifuButton2Test4.Hide();
            bunifuButton3Test4.Hide();
            bunifuButton4Test4.Hide();
            bunifuButton5Test4.Hide();

            bunifuButton1Test5.Show();
            bunifuButton2Test5.Show();

            label1Test5.Show();
            label2Test5.Show();
            textBox1Test5.Show();

        }

        private void bunifuButton1Test5_Click(object sender, EventArgs e)
        {
            if(textBox1Test5.Text == "<h1>London</h1>")
            {
                panel1.BackColor = Color.FromArgb(0xD9, 0xEE, 0xE1);

                label1Test5.Hide();
                label2Test5.Hide();
                label3.Show();

                textBox1Test5.Hide();

                bunifuButton1Test5.Hide();
                bunifuButton2Test5.Hide();
                bunifuButton5Test5.Show();
            }

            else
            {
                panel1.BackColor = Color.FromArgb(0xFF, 0xC0, 0xC7);

                label1Test5.Hide();
                label2Test5.Hide();
                label4.Show();

                textBox1Test5.Hide();

                bunifuButton1Test5.Hide();
                bunifuButton2Test5.Hide();
                bunifuButton3Test5.Show();
            }
        }

        private void bunifuButton3Test5_Click(object sender, EventArgs e)
        {
            textBox1Test5.Text = null;
            panel1.BackColor = SystemColors.ControlLight;

            label1Test5.Show();
            label2Test5.Show();
            label4.Hide();
            textBox1Test5.Show();

            bunifuButton1Test5.Show();
            bunifuButton2Test5.Show();
            bunifuButton3Test5.Hide();

        }

        private void bunifuButton2Test5_Click(object sender, EventArgs e)
        {
            textBox1Test5.Text = "<h1>London</h1>";

            bunifuButton1Test5.Hide();
            bunifuButton2Test5.Hide();
            bunifuButton4Test5.Show();
        }

        private void bunifuButton4Test5_Click(object sender, EventArgs e)
        {
            textBox1Test5.Text = null;

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

