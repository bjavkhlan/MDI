namespace MDI
{
    partial class FormManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManager));
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label fnameLabel;
            System.Windows.Forms.Label lnameLabel;
            System.Windows.Forms.Label dateofbirthLabel;
            System.Windows.Forms.Label passwrdLabel;
            System.Windows.Forms.Label groupsLabel;
            this.mdiDataSet = new MDI.mdiDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new MDI.mdiDataSetTableAdapters.usersTableAdapter();
            this.tableAdapterManager = new MDI.mdiDataSetTableAdapters.TableAdapterManager();
            this.usersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.usersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.fnameTextBox = new System.Windows.Forms.TextBox();
            this.lnameTextBox = new System.Windows.Forms.TextBox();
            this.dateofbirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.passwrdTextBox = new System.Windows.Forms.TextBox();
            this.groupsTextBox = new System.Windows.Forms.TextBox();
            usernameLabel = new System.Windows.Forms.Label();
            fnameLabel = new System.Windows.Forms.Label();
            lnameLabel = new System.Windows.Forms.Label();
            dateofbirthLabel = new System.Windows.Forms.Label();
            passwrdLabel = new System.Windows.Forms.Label();
            groupsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mdiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingNavigator)).BeginInit();
            this.usersBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // mdiDataSet
            // 
            this.mdiDataSet.DataSetName = "mdiDataSet";
            this.mdiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.mdiDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.groupsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MDI.mdiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = this.usersTableAdapter;
            // 
            // usersBindingNavigator
            // 
            this.usersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.usersBindingNavigator.BindingSource = this.usersBindingSource;
            this.usersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.usersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.usersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.usersBindingNavigatorSaveItem});
            this.usersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.usersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.usersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.usersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.usersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.usersBindingNavigator.Name = "usersBindingNavigator";
            this.usersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.usersBindingNavigator.Size = new System.Drawing.Size(446, 25);
            this.usersBindingNavigator.TabIndex = 0;
            this.usersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // usersBindingNavigatorSaveItem
            // 
            this.usersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.usersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("usersBindingNavigatorSaveItem.Image")));
            this.usersBindingNavigatorSaveItem.Name = "usersBindingNavigatorSaveItem";
            this.usersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.usersBindingNavigatorSaveItem.Text = "Save Data";
            this.usersBindingNavigatorSaveItem.Click += new System.EventHandler(this.usersBindingNavigatorSaveItem_Click_1);
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(13, 47);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(56, 13);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "username:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(79, 44);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(200, 20);
            this.usernameTextBox.TabIndex = 2;
            // 
            // fnameLabel
            // 
            fnameLabel.AutoSize = true;
            fnameLabel.Location = new System.Drawing.Point(13, 73);
            fnameLabel.Name = "fnameLabel";
            fnameLabel.Size = new System.Drawing.Size(39, 13);
            fnameLabel.TabIndex = 3;
            fnameLabel.Text = "fname:";
            // 
            // fnameTextBox
            // 
            this.fnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "fname", true));
            this.fnameTextBox.Location = new System.Drawing.Point(79, 70);
            this.fnameTextBox.Name = "fnameTextBox";
            this.fnameTextBox.Size = new System.Drawing.Size(200, 20);
            this.fnameTextBox.TabIndex = 4;
            // 
            // lnameLabel
            // 
            lnameLabel.AutoSize = true;
            lnameLabel.Location = new System.Drawing.Point(13, 99);
            lnameLabel.Name = "lnameLabel";
            lnameLabel.Size = new System.Drawing.Size(38, 13);
            lnameLabel.TabIndex = 5;
            lnameLabel.Text = "lname:";
            // 
            // lnameTextBox
            // 
            this.lnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "lname", true));
            this.lnameTextBox.Location = new System.Drawing.Point(79, 96);
            this.lnameTextBox.Name = "lnameTextBox";
            this.lnameTextBox.Size = new System.Drawing.Size(200, 20);
            this.lnameTextBox.TabIndex = 6;
            // 
            // dateofbirthLabel
            // 
            dateofbirthLabel.AutoSize = true;
            dateofbirthLabel.Location = new System.Drawing.Point(13, 126);
            dateofbirthLabel.Name = "dateofbirthLabel";
            dateofbirthLabel.Size = new System.Drawing.Size(60, 13);
            dateofbirthLabel.TabIndex = 7;
            dateofbirthLabel.Text = "dateofbirth:";
            // 
            // dateofbirthDateTimePicker
            // 
            this.dateofbirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.usersBindingSource, "dateofbirth", true));
            this.dateofbirthDateTimePicker.Location = new System.Drawing.Point(79, 122);
            this.dateofbirthDateTimePicker.Name = "dateofbirthDateTimePicker";
            this.dateofbirthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateofbirthDateTimePicker.TabIndex = 8;
            // 
            // passwrdLabel
            // 
            passwrdLabel.AutoSize = true;
            passwrdLabel.Location = new System.Drawing.Point(13, 151);
            passwrdLabel.Name = "passwrdLabel";
            passwrdLabel.Size = new System.Drawing.Size(49, 13);
            passwrdLabel.TabIndex = 9;
            passwrdLabel.Text = "passwrd:";
            // 
            // passwrdTextBox
            // 
            this.passwrdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "passwrd", true));
            this.passwrdTextBox.Location = new System.Drawing.Point(79, 148);
            this.passwrdTextBox.Name = "passwrdTextBox";
            this.passwrdTextBox.Size = new System.Drawing.Size(200, 20);
            this.passwrdTextBox.TabIndex = 10;
            // 
            // groupsLabel
            // 
            groupsLabel.AutoSize = true;
            groupsLabel.Location = new System.Drawing.Point(13, 177);
            groupsLabel.Name = "groupsLabel";
            groupsLabel.Size = new System.Drawing.Size(42, 13);
            groupsLabel.TabIndex = 11;
            groupsLabel.Text = "groups:";
            // 
            // groupsTextBox
            // 
            this.groupsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "groups", true));
            this.groupsTextBox.Location = new System.Drawing.Point(79, 174);
            this.groupsTextBox.Name = "groupsTextBox";
            this.groupsTextBox.Size = new System.Drawing.Size(200, 20);
            this.groupsTextBox.TabIndex = 12;
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 317);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(fnameLabel);
            this.Controls.Add(this.fnameTextBox);
            this.Controls.Add(lnameLabel);
            this.Controls.Add(this.lnameTextBox);
            this.Controls.Add(dateofbirthLabel);
            this.Controls.Add(this.dateofbirthDateTimePicker);
            this.Controls.Add(passwrdLabel);
            this.Controls.Add(this.passwrdTextBox);
            this.Controls.Add(groupsLabel);
            this.Controls.Add(this.groupsTextBox);
            this.Controls.Add(this.usersBindingNavigator);
            this.Name = "FormManager";
            this.Text = "Manager Form";
            this.Load += new System.EventHandler(this.FormManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mdiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingNavigator)).EndInit();
            this.usersBindingNavigator.ResumeLayout(false);
            this.usersBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private mdiDataSet mdiDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private mdiDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private mdiDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator usersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton usersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox fnameTextBox;
        private System.Windows.Forms.TextBox lnameTextBox;
        private System.Windows.Forms.DateTimePicker dateofbirthDateTimePicker;
        private System.Windows.Forms.TextBox passwrdTextBox;
        private System.Windows.Forms.TextBox groupsTextBox;
    }
}