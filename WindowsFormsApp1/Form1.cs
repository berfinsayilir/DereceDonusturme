using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            textBox2.Text = Convert.ToString(x * 9 / 5 + 32) + " F";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double y = Convert.ToDouble(textBox1.Text);

            textBox2.Text = Convert.ToString((y - 32) * 5 / 9)+ " C";
            
        }
    }
}
