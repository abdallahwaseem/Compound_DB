
namespace Compound_DB.Manager
{
    partial class residentcontrol
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.unitidcomboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.resdpasswordTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BuildingIDComboBox = new System.Windows.Forms.ComboBox();
            this.femaleRadioBtn = new System.Windows.Forms.RadioButton();
            this.maleRadioBtn = new System.Windows.Forms.RadioButton();
            this.resdBdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.resdusernameTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.resdphonenumTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resdnameTextbox = new System.Windows.Forms.TextBox();
            this.insertresdButton = new System.Windows.Forms.Button();
            this.updateresdBtn = new System.Windows.Forms.Button();
            this.resdnewphonenumTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.insertanoccupantBtn = new System.Windows.Forms.Button();
            this.occupantresidentComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.occupantnameTextbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.relationshipComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.updateresdnamecomboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.unitidcomboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.resdpasswordTextbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BuildingIDComboBox);
            this.groupBox1.Controls.Add(this.femaleRadioBtn);
            this.groupBox1.Controls.Add(this.maleRadioBtn);
            this.groupBox1.Controls.Add(this.resdBdateTimePicker);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.resdusernameTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.resdphonenumTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.resdnameTextbox);
            this.groupBox1.Controls.Add(this.insertresdButton);
            this.groupBox1.Font = new System.Drawing.Font("Elephant", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(16, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 280);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resident Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 52;
            this.label2.Text = "Unit ID";
            // 
            // unitidcomboBox
            // 
            this.unitidcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitidcomboBox.FormattingEnabled = true;
            this.unitidcomboBox.Location = new System.Drawing.Point(164, 165);
            this.unitidcomboBox.Name = "unitidcomboBox";
            this.unitidcomboBox.Size = new System.Drawing.Size(122, 26);
            this.unitidcomboBox.TabIndex = 51;
            this.unitidcomboBox.DropDown += new System.EventHandler(this.unitidcomboBox_DropDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 50;
            this.label5.Text = "Password";
            // 
            // resdpasswordTextbox
            // 
            this.resdpasswordTextbox.Location = new System.Drawing.Point(17, 137);
            this.resdpasswordTextbox.Name = "resdpasswordTextbox";
            this.resdpasswordTextbox.Size = new System.Drawing.Size(122, 25);
            this.resdpasswordTextbox.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 48;
            this.label3.Text = "User Name";
            // 
            // BuildingIDComboBox
            // 
            this.BuildingIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BuildingIDComboBox.FormattingEnabled = true;
            this.BuildingIDComboBox.Location = new System.Drawing.Point(164, 101);
            this.BuildingIDComboBox.Name = "BuildingIDComboBox";
            this.BuildingIDComboBox.Size = new System.Drawing.Size(122, 26);
            this.BuildingIDComboBox.TabIndex = 47;
            this.BuildingIDComboBox.DropDown += new System.EventHandler(this.BuildingIDComboBox_DropDown);
            // 
            // femaleRadioBtn
            // 
            this.femaleRadioBtn.AutoSize = true;
            this.femaleRadioBtn.Location = new System.Drawing.Point(77, 186);
            this.femaleRadioBtn.Name = "femaleRadioBtn";
            this.femaleRadioBtn.Size = new System.Drawing.Size(80, 22);
            this.femaleRadioBtn.TabIndex = 37;
            this.femaleRadioBtn.TabStop = true;
            this.femaleRadioBtn.Text = "Female";
            this.femaleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // maleRadioBtn
            // 
            this.maleRadioBtn.AutoSize = true;
            this.maleRadioBtn.Location = new System.Drawing.Point(12, 186);
            this.maleRadioBtn.Name = "maleRadioBtn";
            this.maleRadioBtn.Size = new System.Drawing.Size(64, 22);
            this.maleRadioBtn.TabIndex = 36;
            this.maleRadioBtn.TabStop = true;
            this.maleRadioBtn.Text = "Male";
            this.maleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // resdBdateTimePicker
            // 
            this.resdBdateTimePicker.Location = new System.Drawing.Point(170, 39);
            this.resdBdateTimePicker.MaxDate = new System.DateTime(2006, 12, 31, 0, 0, 0, 0);
            this.resdBdateTimePicker.Name = "resdBdateTimePicker";
            this.resdBdateTimePicker.Size = new System.Drawing.Size(182, 25);
            this.resdBdateTimePicker.TabIndex = 35;
            this.resdBdateTimePicker.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(168, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 18);
            this.label14.TabIndex = 31;
            this.label14.Text = "Building ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 18);
            this.label11.TabIndex = 27;
            this.label11.Text = "Gender";
            // 
            // resdusernameTextBox
            // 
            this.resdusernameTextBox.Location = new System.Drawing.Point(17, 89);
            this.resdusernameTextBox.Name = "resdusernameTextBox";
            this.resdusernameTextBox.Size = new System.Drawing.Size(122, 25);
            this.resdusernameTextBox.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(168, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 18);
            this.label9.TabIndex = 23;
            this.label9.Text = "Date of Birth";
            // 
            // resdphonenumTextBox
            // 
            this.resdphonenumTextBox.Location = new System.Drawing.Point(17, 230);
            this.resdphonenumTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.resdphonenumTextBox.Name = "resdphonenumTextBox";
            this.resdphonenumTextBox.Size = new System.Drawing.Size(122, 25);
            this.resdphonenumTextBox.TabIndex = 8;
            this.resdphonenumTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.resdphonenumTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 211);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // resdnameTextbox
            // 
            this.resdnameTextbox.Location = new System.Drawing.Point(17, 39);
            this.resdnameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.resdnameTextbox.Name = "resdnameTextbox";
            this.resdnameTextbox.Size = new System.Drawing.Size(122, 25);
            this.resdnameTextbox.TabIndex = 1;
            this.resdnameTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.resdnameTextbox_KeyPress);
            // 
            // insertresdButton
            // 
            this.insertresdButton.Location = new System.Drawing.Point(164, 211);
            this.insertresdButton.Margin = new System.Windows.Forms.Padding(4);
            this.insertresdButton.Name = "insertresdButton";
            this.insertresdButton.Size = new System.Drawing.Size(182, 44);
            this.insertresdButton.TabIndex = 0;
            this.insertresdButton.Text = "Insert a new resident";
            this.insertresdButton.UseVisualStyleBackColor = true;
            this.insertresdButton.Click += new System.EventHandler(this.insertresdButton_Click);
            // 
            // updateresdBtn
            // 
            this.updateresdBtn.Location = new System.Drawing.Point(26, 165);
            this.updateresdBtn.Margin = new System.Windows.Forms.Padding(4);
            this.updateresdBtn.Name = "updateresdBtn";
            this.updateresdBtn.Size = new System.Drawing.Size(147, 44);
            this.updateresdBtn.TabIndex = 38;
            this.updateresdBtn.Text = "Update Resident\'s Number";
            this.updateresdBtn.UseVisualStyleBackColor = true;
            this.updateresdBtn.Click += new System.EventHandler(this.updateresdBtn_Click);
            // 
            // resdnewphonenumTextbox
            // 
            this.resdnewphonenumTextbox.Location = new System.Drawing.Point(26, 129);
            this.resdnewphonenumTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.resdnewphonenumTextbox.Name = "resdnewphonenumTextbox";
            this.resdnewphonenumTextbox.Size = new System.Drawing.Size(147, 25);
            this.resdnewphonenumTextbox.TabIndex = 39;
            this.resdnewphonenumTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.resdnewphonenumTextbox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 18);
            this.label6.TabIndex = 40;
            this.label6.Text = "New Phone Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 18);
            this.label7.TabIndex = 53;
            this.label7.Text = "User Name";
            // 
            // insertanoccupantBtn
            // 
            this.insertanoccupantBtn.Location = new System.Drawing.Point(10, 202);
            this.insertanoccupantBtn.Margin = new System.Windows.Forms.Padding(4);
            this.insertanoccupantBtn.Name = "insertanoccupantBtn";
            this.insertanoccupantBtn.Size = new System.Drawing.Size(147, 44);
            this.insertanoccupantBtn.TabIndex = 54;
            this.insertanoccupantBtn.Text = "Insert an Occupant";
            this.insertanoccupantBtn.UseVisualStyleBackColor = true;
            this.insertanoccupantBtn.Click += new System.EventHandler(this.insertanoccupantBtn_Click);
            // 
            // occupantresidentComboBox
            // 
            this.occupantresidentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.occupantresidentComboBox.FormattingEnabled = true;
            this.occupantresidentComboBox.Location = new System.Drawing.Point(6, 44);
            this.occupantresidentComboBox.Name = "occupantresidentComboBox";
            this.occupantresidentComboBox.Size = new System.Drawing.Size(147, 26);
            this.occupantresidentComboBox.TabIndex = 55;
            this.occupantresidentComboBox.DropDown += new System.EventHandler(this.occupantresidentComboBox_DropDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 24);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 18);
            this.label8.TabIndex = 56;
            this.label8.Text = "User Name";
            // 
            // occupantnameTextbox
            // 
            this.occupantnameTextbox.Location = new System.Drawing.Point(6, 92);
            this.occupantnameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.occupantnameTextbox.Name = "occupantnameTextbox";
            this.occupantnameTextbox.Size = new System.Drawing.Size(147, 25);
            this.occupantnameTextbox.TabIndex = 57;
            this.occupantnameTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.occupantnameTextbox_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 71);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 18);
            this.label10.TabIndex = 58;
            this.label10.Text = "Occupant Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 131);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 18);
            this.label12.TabIndex = 59;
            this.label12.Text = "Relationship";
            // 
            // relationshipComboBox
            // 
            this.relationshipComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.relationshipComboBox.FormattingEnabled = true;
            this.relationshipComboBox.Location = new System.Drawing.Point(6, 156);
            this.relationshipComboBox.Name = "relationshipComboBox";
            this.relationshipComboBox.Size = new System.Drawing.Size(147, 26);
            this.relationshipComboBox.TabIndex = 60;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.insertanoccupantBtn);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.relationshipComboBox);
            this.groupBox2.Controls.Add(this.occupantresidentComboBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.occupantnameTextbox);
            this.groupBox2.Font = new System.Drawing.Font("Elephant", 8.25F);
            this.groupBox2.Location = new System.Drawing.Point(408, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 280);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Insert an Occupant";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.updateresdnamecomboBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.updateresdBtn);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.resdnewphonenumTextbox);
            this.groupBox3.Font = new System.Drawing.Font("Elephant", 8.25F);
            this.groupBox3.Location = new System.Drawing.Point(630, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 280);
            this.groupBox3.TabIndex = 62;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update Details";
            // 
            // updateresdnamecomboBox
            // 
            this.updateresdnamecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updateresdnamecomboBox.FormattingEnabled = true;
            this.updateresdnamecomboBox.Location = new System.Drawing.Point(26, 74);
            this.updateresdnamecomboBox.Name = "updateresdnamecomboBox";
            this.updateresdnamecomboBox.Size = new System.Drawing.Size(147, 26);
            this.updateresdnamecomboBox.TabIndex = 54;
            this.updateresdnamecomboBox.Click += new System.EventHandler(this.updateresdcomboBox_DropDown);
            // 
            // residentcontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "residentcontrol";
            this.Size = new System.Drawing.Size(895, 353);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox resdpasswordTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox BuildingIDComboBox;
        private System.Windows.Forms.RadioButton femaleRadioBtn;
        private System.Windows.Forms.RadioButton maleRadioBtn;
        private System.Windows.Forms.DateTimePicker resdBdateTimePicker;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox resdusernameTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox resdphonenumTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resdnameTextbox;
        private System.Windows.Forms.Button insertresdButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox unitidcomboBox;
        private System.Windows.Forms.Button updateresdBtn;
        private System.Windows.Forms.TextBox resdnewphonenumTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button insertanoccupantBtn;
        private System.Windows.Forms.ComboBox occupantresidentComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox occupantnameTextbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox relationshipComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ComboBox updateresdnamecomboBox;
    }
}
