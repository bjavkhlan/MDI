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
        public static string username;
        public static string group;
        private FormLogin formLogin;
        private FormUser formUser;
        private FormAdmin formAdmin;
        private FormManager formManager;
        public FormMain()
        {
            InitializeComponent();
            username = null;
            formLogin = new FormLogin();
            //formLogin.MdiParent = this;
            formLogin.ShowDialog();
            if (username != null)
            {
                if (group == "admin")
                {
                    formAdmin = new FormAdmin();
                    formAdmin.MdiParent = this;
                    formAdmin.Show();
                }
                else if (group == "manager")
                {
                    formManager = new FormManager();
                    formManager.MdiParent = this;
                    formManager.Show();
                }
                else
                {
                    formUser = new FormUser();
                    formUser.MdiParent = this;
                    formUser.Show();
                }

            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
