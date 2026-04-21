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
    public partial class Formbtnbigger : Form
    {
        public Formbtnbigger()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int height = button1.Height;
            int Width = button1.Width;
            button1.Size = new Size(Width+10, Height+10);
        }
    }
}
