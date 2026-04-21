using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Class_2026
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ClickMe_Click(object sender, EventArgs e)
        {
            if (btn_ClickMe.Text == "按我一下") 
                btn_ClickMe.Text = "我已經被點擊過了";
            else if (btn_ClickMe.Text == "我已經被點擊過了") 
                btn_ClickMe.Text = "按我一下";


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_ChangeLabel_Click(object sender, EventArgs e)
        {
            lab_ChangeLabel.Text="按鈕被按過了";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Counter_Click(object sender, EventArgs e)
        {
            String count = lab_Counter.Text;
            int sum =int.Parse(count)+1;
            lab_Counter.Text = sum.ToString();
        }

        private void btnBigger_Click(object sender, EventArgs e)
        {
            new Formbtnbigger().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            label2.Text = str;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
