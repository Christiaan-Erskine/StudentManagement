namespace StudentManagement.Presentation
{
    partial class AddModule
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
            System.Windows.Forms.Label moduleCodeLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label descriptionLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.moduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentManagementDataSet = new StudentManagement.StudentManagementDataSet();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.moduleCodeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.moduleTableAdapter = new StudentManagement.StudentManagementDataSetTableAdapters.ModuleTableAdapter();
            this.tableAdapterManager = new StudentManagement.StudentManagementDataSetTableAdapters.TableAdapterManager();
            moduleCodeLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // moduleCodeLabel
            // 
            moduleCodeLabel.AutoSize = true;
            moduleCodeLabel.Location = new System.Drawing.Point(105, 124);
            moduleCodeLabel.Name = "moduleCodeLabel";
            moduleCodeLabel.Size = new System.Drawing.Size(73, 13);
            moduleCodeLabel.TabIndex = 7;
            moduleCodeLabel.Text = "Module Code:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(140, 162);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Name:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(115, 201);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 9;
            descriptionLabel.Text = "Description:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(descriptionLabel);
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(moduleCodeLabel);
            this.panel1.Controls.Add(this.moduleCodeTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(322, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 412);
            this.panel1.TabIndex = 12;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(362, 6);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(21, 20);
            this.lblExit.TabIndex = 21;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(170)))), ((int)(((byte)(219)))));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(104, 300);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(181, 32);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add Module";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moduleBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(184, 198);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionTextBox.TabIndex = 10;
            // 
            // moduleBindingSource
            // 
            this.moduleBindingSource.DataMember = "Module";
            this.moduleBindingSource.DataSource = this.studentManagementDataSet;
            // 
            // studentManagementDataSet
            // 
            this.studentManagementDataSet.DataSetName = "StudentManagementDataSet";
            this.studentManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moduleBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(184, 159);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 9;
            // 
            // moduleCodeTextBox
            // 
            this.moduleCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moduleBindingSource, "ModuleCode", true));
            this.moduleCodeTextBox.Location = new System.Drawing.Point(184, 121);
            this.moduleCodeTextBox.Name = "moduleCodeTextBox";
            this.moduleCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.moduleCodeTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 42);
            this.label4.TabIndex = 7;
            this.label4.Text = "Add Module";
            // 
            // moduleTableAdapter
            // 
            this.moduleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ModuleTableAdapter = this.moduleTableAdapter;
            this.tableAdapterManager.ResourceModuleTableAdapter = null;
            this.tableAdapterManager.ResourceTableAdapter = null;
            this.tableAdapterManager.StudentModuleTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = StudentManagement.StudentManagementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // AddModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentManagement.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1035, 589);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainModule";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddModule_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagementDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private StudentManagementDataSet studentManagementDataSet;
        private System.Windows.Forms.BindingSource moduleBindingSource;
        private StudentManagementDataSetTableAdapters.ModuleTableAdapter moduleTableAdapter;
        private StudentManagementDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox moduleCodeTextBox;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblExit;
    }
}