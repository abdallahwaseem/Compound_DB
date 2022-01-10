
namespace Compound_DB.Manager
{
    partial class staff
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DeptIDComboBox = new System.Windows.Forms.ComboBox();
            this.femaleRadioBtn = new System.Windows.Forms.RadioButton();
            this.maleRadioBtn = new System.Windows.Forms.RadioButton();
            this.BdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.phonenumTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.staffmemberTextbox = new System.Windows.Forms.TextBox();
            this.insertstaffButton = new System.Windows.Forms.Button();
            this.deletestaffBtn = new System.Windows.Forms.Button();
            this.staffidcomboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.updatephoneBtn = new System.Windows.Forms.Button();
            this.updatestaffnamecomboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.newphonenumtextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.updsalaryBtn = new System.Windows.Forms.Button();
            this.newsalaryTextbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.newDeptIDcomboBox = new System.Windows.Forms.ComboBox();
            this.updatedeptBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.passwordTextbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DeptIDComboBox);
            this.groupBox1.Controls.Add(this.femaleRadioBtn);
            this.groupBox1.Controls.Add(this.maleRadioBtn);
            this.groupBox1.Controls.Add(this.BdateTimePicker);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.usernameTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.phonenumTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.salaryTextBox);
            this.groupBox1.Controls.Add(this.staffmemberTextbox);
            this.groupBox1.Controls.Add(this.insertstaffButton);
            this.groupBox1.Location = new System.Drawing.Point(3, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 260);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Staff Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 50;
            this.label5.Text = "Password";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(263, 132);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(182, 22);
            this.passwordTextbox.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "User Name";
            // 
            // DeptIDComboBox
            // 
            this.DeptIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeptIDComboBox.FormattingEnabled = true;
            this.DeptIDComboBox.Location = new System.Drawing.Point(17, 181);
            this.DeptIDComboBox.Name = "DeptIDComboBox";
            this.DeptIDComboBox.Size = new System.Drawing.Size(194, 24);
            this.DeptIDComboBox.TabIndex = 47;
            this.DeptIDComboBox.DropDown += new System.EventHandler(this.DeptIDComboBox_DropDown);
            // 
            // femaleRadioBtn
            // 
            this.femaleRadioBtn.AutoSize = true;
            this.femaleRadioBtn.Location = new System.Drawing.Point(102, 130);
            this.femaleRadioBtn.Name = "femaleRadioBtn";
            this.femaleRadioBtn.Size = new System.Drawing.Size(75, 21);
            this.femaleRadioBtn.TabIndex = 37;
            this.femaleRadioBtn.TabStop = true;
            this.femaleRadioBtn.Text = "Female";
            this.femaleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // maleRadioBtn
            // 
            this.maleRadioBtn.AutoSize = true;
            this.maleRadioBtn.Location = new System.Drawing.Point(19, 130);
            this.maleRadioBtn.Name = "maleRadioBtn";
            this.maleRadioBtn.Size = new System.Drawing.Size(59, 21);
            this.maleRadioBtn.TabIndex = 36;
            this.maleRadioBtn.TabStop = true;
            this.maleRadioBtn.Text = "Male";
            this.maleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // BdateTimePicker
            // 
            this.BdateTimePicker.Location = new System.Drawing.Point(19, 85);
            this.BdateTimePicker.MaxDate = new System.DateTime(2006, 12, 31, 0, 0, 0, 0);
            this.BdateTimePicker.Name = "BdateTimePicker";
            this.BdateTimePicker.Size = new System.Drawing.Size(192, 22);
            this.BdateTimePicker.TabIndex = 35;
            this.BdateTimePicker.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 154);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 17);
            this.label14.TabIndex = 31;
            this.label14.Text = "Department ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "Gender";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(263, 87);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(182, 22);
            this.usernameTextBox.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Date of Birth";
            // 
            // phonenumTextBox
            // 
            this.phonenumTextBox.Location = new System.Drawing.Point(263, 39);
            this.phonenumTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.phonenumTextBox.Name = "phonenumTextBox";
            this.phonenumTextBox.Size = new System.Drawing.Size(182, 22);
            this.phonenumTextBox.TabIndex = 8;
            this.phonenumTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phonenumTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 209);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Salary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Staff Name";
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(17, 230);
            this.salaryTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(182, 22);
            this.salaryTextBox.TabIndex = 2;
            this.salaryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salaryTextBox_KeyPress);
            // 
            // staffmemberTextbox
            // 
            this.staffmemberTextbox.Location = new System.Drawing.Point(19, 39);
            this.staffmemberTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.staffmemberTextbox.Name = "staffmemberTextbox";
            this.staffmemberTextbox.Size = new System.Drawing.Size(192, 22);
            this.staffmemberTextbox.TabIndex = 1;
            this.staffmemberTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.staffmemberTextbox_KeyPress);
            // 
            // insertstaffButton
            // 
            this.insertstaffButton.Location = new System.Drawing.Point(263, 182);
            this.insertstaffButton.Margin = new System.Windows.Forms.Padding(4);
            this.insertstaffButton.Name = "insertstaffButton";
            this.insertstaffButton.Size = new System.Drawing.Size(147, 44);
            this.insertstaffButton.TabIndex = 0;
            this.insertstaffButton.Text = "Insert a staff member";
            this.insertstaffButton.UseVisualStyleBackColor = true;
            this.insertstaffButton.Click += new System.EventHandler(this.insertstaffButton_Click);
            // 
            // deletestaffBtn
            // 
            this.deletestaffBtn.Location = new System.Drawing.Point(521, 126);
            this.deletestaffBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deletestaffBtn.Name = "deletestaffBtn";
            this.deletestaffBtn.Size = new System.Drawing.Size(147, 44);
            this.deletestaffBtn.TabIndex = 37;
            this.deletestaffBtn.Text = "Delete a staff member";
            this.deletestaffBtn.UseVisualStyleBackColor = true;
            this.deletestaffBtn.Click += new System.EventHandler(this.deletestaffBtn_Click);
            // 
            // staffidcomboBox
            // 
            this.staffidcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.staffidcomboBox.FormattingEnabled = true;
            this.staffidcomboBox.Location = new System.Drawing.Point(498, 77);
            this.staffidcomboBox.Name = "staffidcomboBox";
            this.staffidcomboBox.Size = new System.Drawing.Size(194, 24);
            this.staffidcomboBox.TabIndex = 48;
            this.staffidcomboBox.DropDown += new System.EventHandler(this.staffidcomboBox_DropDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(509, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 49;
            this.label6.Text = "Staff ID";
            // 
            // updatephoneBtn
            // 
            this.updatephoneBtn.Location = new System.Drawing.Point(157, 333);
            this.updatephoneBtn.Margin = new System.Windows.Forms.Padding(4);
            this.updatephoneBtn.Name = "updatephoneBtn";
            this.updatephoneBtn.Size = new System.Drawing.Size(166, 38);
            this.updatephoneBtn.TabIndex = 50;
            this.updatephoneBtn.Text = "Update Phone Number";
            this.updatephoneBtn.UseVisualStyleBackColor = true;
            this.updatephoneBtn.Click += new System.EventHandler(this.updatephoneBtn_Click);
            // 
            // updatestaffnamecomboBox
            // 
            this.updatestaffnamecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updatestaffnamecomboBox.FormattingEnabled = true;
            this.updatestaffnamecomboBox.Location = new System.Drawing.Point(7, 303);
            this.updatestaffnamecomboBox.Name = "updatestaffnamecomboBox";
            this.updatestaffnamecomboBox.Size = new System.Drawing.Size(131, 24);
            this.updatestaffnamecomboBox.TabIndex = 51;
            this.updatestaffnamecomboBox.DropDown += new System.EventHandler(this.updatestaffnamecomboBox_DropDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 52;
            this.label7.Text = "Staff User Name";
            // 
            // newphonenumtextBox
            // 
            this.newphonenumtextBox.Location = new System.Drawing.Point(173, 303);
            this.newphonenumtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.newphonenumtextBox.Name = "newphonenumtextBox";
            this.newphonenumtextBox.Size = new System.Drawing.Size(131, 22);
            this.newphonenumtextBox.TabIndex = 53;
            this.newphonenumtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newphonenumtextBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(170, 282);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 17);
            this.label8.TabIndex = 54;
            this.label8.Text = "New Phone Number";
            // 
            // updsalaryBtn
            // 
            this.updsalaryBtn.Location = new System.Drawing.Point(342, 333);
            this.updsalaryBtn.Margin = new System.Windows.Forms.Padding(4);
            this.updsalaryBtn.Name = "updsalaryBtn";
            this.updsalaryBtn.Size = new System.Drawing.Size(131, 38);
            this.updsalaryBtn.TabIndex = 55;
            this.updsalaryBtn.Text = "Update Salary";
            this.updsalaryBtn.UseVisualStyleBackColor = true;
            this.updsalaryBtn.Click += new System.EventHandler(this.updsalaryBtn_Click);
            // 
            // newsalaryTextbox
            // 
            this.newsalaryTextbox.Location = new System.Drawing.Point(342, 303);
            this.newsalaryTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.newsalaryTextbox.Name = "newsalaryTextbox";
            this.newsalaryTextbox.Size = new System.Drawing.Size(131, 22);
            this.newsalaryTextbox.TabIndex = 56;
            this.newsalaryTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newsalaryTextbox_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(339, 282);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 17);
            this.label10.TabIndex = 57;
            this.label10.Text = "New Salary";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(495, 282);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 17);
            this.label12.TabIndex = 58;
            this.label12.Text = "New Department";
            // 
            // newDeptIDcomboBox
            // 
            this.newDeptIDcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newDeptIDcomboBox.FormattingEnabled = true;
            this.newDeptIDcomboBox.Location = new System.Drawing.Point(498, 303);
            this.newDeptIDcomboBox.Name = "newDeptIDcomboBox";
            this.newDeptIDcomboBox.Size = new System.Drawing.Size(194, 24);
            this.newDeptIDcomboBox.TabIndex = 59;
            this.newDeptIDcomboBox.DropDown += new System.EventHandler(this.newDeptIDcomboBox_DropDown);
            // 
            // updatedeptBtn
            // 
            this.updatedeptBtn.Location = new System.Drawing.Point(498, 334);
            this.updatedeptBtn.Margin = new System.Windows.Forms.Padding(4);
            this.updatedeptBtn.Name = "updatedeptBtn";
            this.updatedeptBtn.Size = new System.Drawing.Size(146, 37);
            this.updatedeptBtn.TabIndex = 60;
            this.updatedeptBtn.Text = "Update Department";
            this.updatedeptBtn.UseVisualStyleBackColor = true;
            this.updatedeptBtn.Click += new System.EventHandler(this.updatedeptBtn_Click);
            // 
            // staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.updatedeptBtn);
            this.Controls.Add(this.newDeptIDcomboBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.newsalaryTextbox);
            this.Controls.Add(this.updsalaryBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.newphonenumtextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.updatestaffnamecomboBox);
            this.Controls.Add(this.updatephoneBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.staffidcomboBox);
            this.Controls.Add(this.deletestaffBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "staff";
            this.Size = new System.Drawing.Size(732, 423);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DeptIDComboBox;
        private System.Windows.Forms.RadioButton femaleRadioBtn;
        private System.Windows.Forms.RadioButton maleRadioBtn;
        private System.Windows.Forms.DateTimePicker BdateTimePicker;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox phonenumTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox staffmemberTextbox;
        private System.Windows.Forms.Button insertstaffButton;
        private System.Windows.Forms.Button deletestaffBtn;
        private System.Windows.Forms.ComboBox staffidcomboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button updatephoneBtn;
        private System.Windows.Forms.ComboBox updatestaffnamecomboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox newphonenumtextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button updsalaryBtn;
        private System.Windows.Forms.TextBox newsalaryTextbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox newDeptIDcomboBox;
        private System.Windows.Forms.Button updatedeptBtn;
    }
}
