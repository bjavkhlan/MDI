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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mdiDataSet);

        }
        
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mdiDataSet.groups' table. You can move, or remove it, as needed.
            this.groupsTableAdapter.Fill(this.mdiDataSet.groups);
            // TODO: This line of code loads data into the 'mdiDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.mdiDataSet.users);

        }

        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            usersTableAdapter.Update(mdiDataSet.users);
            groupsTableAdapter.Update(mdiDataSet.groups);
        }
    }
}
