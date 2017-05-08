using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            FormChild f = new FormChild();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }
    }
}
