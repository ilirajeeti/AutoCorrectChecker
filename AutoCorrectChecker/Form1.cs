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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            var htmlTest = new htmlTest();
            htmlTest.Show();
            this.Hide();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            var cssTest = new cssTest();
            cssTest.Show();
            this.Hide();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            var javaScriptTest = new javascriptTest();
            javaScriptTest.Show();
            this.Hide();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            var cSharpTest = new cSharpTest();
            cSharpTest.Show();
            this.Hide();
        }
    }
}
