using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AUTO_OOP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Auto auto;
       
        private void button1_Click(object sender, EventArgs e)
        {
            auto.Rozjed();
            MessageBox.Show(auto.ToString());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            auto.Zastav(Convert.ToInt32(textBox3.Text));
            MessageBox.Show(auto.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            auto = new Auto(textBox1.Text, Convert.ToDouble(textBox2.Text));
        }
    }
}
