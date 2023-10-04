using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitaptaplop4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s="phương trinh có nghiệm là";
            float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);
          
            Tính giai = new Tính();
            textBox4.Text = s + giai.Tinhphuongtrinhb1(a,b);
            if (radioButton1.Checked){
                MessageBox.Show(giai.Tinhphuongtrinhb1(a,b));}

           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                textBox3.Enabled = false;
            else
                textBox3.Enabled = true;
            label5.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        { 

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
