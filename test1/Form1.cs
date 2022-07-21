using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 5;
            int b = 10;
            this.label1.Text = a.ToString();
            this.label2.Text = b.ToString();
            this.label3.Text = (a + b).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = "5";
            string b = "10";
            this.label1.Text = a;
            this.label2.Text = b;
            this.label3.Text = a + b;

        }
    }
}
