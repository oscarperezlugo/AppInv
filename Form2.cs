using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppInv
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            string m1 = textBox1.ToString();
        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
            string m2 = textBox1.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myForm = new Form1();
            myForm.Show();
            //this.Close();
        }
    }
}
