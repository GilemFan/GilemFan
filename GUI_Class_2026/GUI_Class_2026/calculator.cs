using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Class_2026
{
    public partial class calculator : Component
    {
        public calculator()
        {
            InitializeComponent();
        }

        public calculator(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
