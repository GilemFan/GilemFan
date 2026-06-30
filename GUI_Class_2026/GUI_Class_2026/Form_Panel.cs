using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GUI_Class_2026
{
    public partial class Form_Panel : Form
    {
        public Form_Panel()
        {
            InitializeComponent();
            if (!File.Exists("OrderData.csv"))
                File.WriteAllText("OrderData.csv", "時間,主食,配菜,飲品,甜點\n", Encoding.UTF8);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime currenDate = DateTime.Now;
            string formattedDateTime = currenDate.ToString("yyyyy/MM/dd HH:MM:ss");
            string food = "", sideFood = "", drink = "", dessert = "";

            foreach (Control c in panel1.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;

                    if (temp.Checked)
                    {
                        food += " " + temp.Text;

                    }
                }
            }


            foreach (Control c in panel2.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;

                    if (temp.Checked)
                    {
                        sideFood += " " + temp.Text;
                    }
                }
            }


            foreach (Control c in panel3.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;

                    if (temp.Checked)
                    {
                        dessert += " " + temp.Text;
                    }
                }
            }


            foreach (Control c in panel4.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;

                    if (temp.Checked)
                    {
                        drink += " " + temp.Text;
                    }
                }
            }
            MessageBox.Show("主食：" + food + "\n配菜：" + sideFood + "\n甜點：" + dessert + "\n飲料：" + drink);



            File.AppendAllText("OrderData.csv", formattedDateTime + "," + food + "," + sideFood + "," + dessert + "," + drink+"\n");


            {

            }
        }
    }
}
