namespace StudentManagement.Presentation
{
    partial class AddStudent
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label imageLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label moduleCodeLabel;
            System.Windows.Forms.Label dOBLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.dOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentManagementDataSet = new StudentManagement.StudentManagementDataSet();
            this.lblExit = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.moduleCodeTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.imageTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.studentTableAdapter = new StudentManagement.StudentManagementDataSetTableAdapters.StudentTableAdapter();
            this.tableAdapterManager = new StudentManagement.StudentManagementDataSetTableAdapters.TableAdapterManager();
            this.moduleTableAdapter = new StudentManagement.StudentManagementDataSetTableAdapters.ModuleTableAdapter();
            this.moduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            nameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            imageLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            moduleCodeLabel = new System.Windows.Forms.Label();
            dOBLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(243, 115);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Name:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(229, 158);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(52, 13);
            surnameLabel.TabIndex = 8;
            surnameLabel.Text = "Surname:";
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Location = new System.Drawing.Point(242, 201);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new System.Drawing.Size(39, 13);
            imageLabel.TabIndex = 9;
            imageLabel.Text = "Image:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(236, 244);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(45, 13);
            genderLabel.TabIndex = 10;
            genderLabel.Text = "Gender:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(240, 287);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 11;
            phoneLabel.Text = "Phone:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(233, 330);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 12;
            addressLabel.Text = "Address:";
            // 
            // moduleCodeLabel
            // 
            moduleCodeLabel.AutoSize = true;
            moduleCodeLabel.Location = new System.Drawing.Point(208, 373);
            moduleCodeLabel.Name = "moduleCodeLabel";
            moduleCodeLabel.Size = new System.Drawing.Size(73, 13);
            moduleCodeLabel.TabIndex = 14;
            moduleCodeLabel.Text = "Module Code:";
            // 
            // dOBLabel
            // 
            dOBLabel.AutoSize = true;
            dOBLabel.Location = new System.Drawing.Point(248, 415);
            dOBLabel.Name = "dOBLabel";
            dOBLabel.Size = new System.Drawing.Size(33, 13);
            dOBLabel.TabIndex = 18;
            dOBLabel.Text = "DOB:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(dOBLabel);
            this.panel1.Controls.Add(this.dOBDateTimePicker);
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(moduleCodeLabel);
            this.panel1.Controls.Add(this.moduleCodeTextBox);
            this.panel1.Controls.Add(addressLabel);
            this.panel1.Controls.Add(this.addressTextBox);
            this.panel1.Controls.Add(phoneLabel);
            this.panel1.Controls.Add(this.phoneTextBox);
            this.panel1.Controls.Add(genderLabel);
            this.panel1.Controls.Add(this.genderTextBox);
            this.panel1.Controls.Add(imageLabel);
            this.panel1.Controls.Add(this.imageTextBox);
            this.panel1.Controls.Add(surnameLabel);
            this.panel1.Controls.Add(this.surnameTextBox);
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(180, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 534);
            this.panel1.TabIndex = 11;
            // 
            // dOBDateTimePicker
            // 
            this.dOBDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentBindingSource, "DOB", true));
            this.dOBDateTimePicker.Location = new System.Drawing.Point(301, 415);
            this.dOBDateTimePicker.Name = "dOBDateTimePicker";
            this.dOBDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dOBDateTimePicker.TabIndex = 19;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.studentManagementDataSet;
            // 
            // studentManagementDataSet
            // 
            this.studentManagementDataSet.DataSetName = "StudentManagementDataSet";
            this.studentManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(682, 5);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(21, 20);
            this.lblExit.TabIndex = 18;
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
            this.btnAdd.Location = new System.Drawing.Point(246, 485);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(203, 27);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add Student";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // moduleCodeTextBox
            // 
            this.moduleCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "ModuleCode", true));
            this.moduleCodeTextBox.Location = new System.Drawing.Point(299, 370);
            this.moduleCodeTextBox.Name = "moduleCodeTextBox";
            this.moduleCodeTextBox.Size = new System.Drawing.Size(200, 20);
            this.moduleCodeTextBox.TabIndex = 15;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(299, 327);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(200, 20);
            this.addressTextBox.TabIndex = 13;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(299, 284);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.phoneTextBox.TabIndex = 12;
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(299, 241);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(200, 20);
            this.genderTextBox.TabIndex = 11;
            // 
            // imageTextBox
            // 
            this.imageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Image", true));
            this.imageTextBox.Location = new System.Drawing.Point(299, 198);
            this.imageTextBox.Name = "imageTextBox";
            this.imageTextBox.Size = new System.Drawing.Size(200, 20);
            this.imageTextBox.TabIndex = 10;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(299, 155);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(200, 20);
            this.surnameTextBox.TabIndex = 9;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(299, 112);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(221, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 42);
            this.label4.TabIndex = 7;
            this.label4.Text = "Add Student";
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ModuleTableAdapter = this.moduleTableAdapter;
            this.tableAdapterManager.ResourceModuleTableAdapter = null;
            this.tableAdapterManager.ResourceTableAdapter = null;
            this.tableAdapterManager.StudentModuleTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = this.studentTableAdapter;
            this.tableAdapterManager.UpdateOrder = StudentManagement.StudentManagementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // moduleTableAdapter
            // 
            this.moduleTableAdapter.ClearBeforeFill = true;
            // 
            // moduleBindingSource
            // 
            this.moduleBindingSource.DataMember = "Module";
            this.moduleBindingSource.DataSource = this.studentManagementDataSet;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentManagement.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1070, 648);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainStudent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private StudentManagementDataSet studentManagementDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private StudentManagementDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private StudentManagementDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox moduleCodeTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox imageTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label lblExit;
        private StudentManagementDataSetTableAdapters.ModuleTableAdapter moduleTableAdapter;
        private System.Windows.Forms.BindingSource moduleBindingSource;
        private System.Windows.Forms.DateTimePicker dOBDateTimePicker;
    }
}