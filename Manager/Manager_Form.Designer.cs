
namespace Compound_DB.Manager
{
    partial class Manager_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.residenceBtn = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.staffBtn = new System.Windows.Forms.Button();
            this.sellUnitBtn = new System.Windows.Forms.Button();
            this.servicesBtn = new System.Windows.Forms.Button();
            this.addpenaltyBtn = new System.Windows.Forms.Button();
            this.checkinvoiceBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.compoundTitleLabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.settingsButton = new System.Windows.Forms.Button();
            this.sellingunitsUserControl1 = new Compound_DB.Manager.sellingunitsUserControl();
            this.residentcontrol1 = new Compound_DB.Manager.residentcontrol();
            this.staff1 = new Compound_DB.Manager.staff();
            this.services1 = new Compound_DB.Manager.services();
            this.addPenalty1 = new Compound_DB.Manager.AddPenalty();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.settingsButton);
            this.panel1.Controls.Add(this.residenceBtn);
            this.panel1.Controls.Add(this.sidePanel);
            this.panel1.Controls.Add(this.logOutBtn);
            this.panel1.Controls.Add(this.staffBtn);
            this.panel1.Controls.Add(this.sellUnitBtn);
            this.panel1.Controls.Add(this.servicesBtn);
            this.panel1.Controls.Add(this.addpenaltyBtn);
            this.panel1.Controls.Add(this.checkinvoiceBtn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 577);
            this.panel1.TabIndex = 1;
            // 
            // residenceBtn
            // 
            this.residenceBtn.FlatAppearance.BorderSize = 0;
            this.residenceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.residenceBtn.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.residenceBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.residenceBtn.Image = global::Compound_DB.Properties.Resources.Search_Icon;
            this.residenceBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.residenceBtn.Location = new System.Drawing.Point(0, 412);
            this.residenceBtn.Name = "residenceBtn";
            this.residenceBtn.Size = new System.Drawing.Size(246, 44);
            this.residenceBtn.TabIndex = 3;
            this.residenceBtn.Text = "Residence";
            this.residenceBtn.UseVisualStyleBackColor = true;
            this.residenceBtn.Click += new System.EventHandler(this.residenceBtn_Click);
            this.residenceBtn.Leave += new System.EventHandler(this.residenceBtn_Leave);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(172)))), ((int)(((byte)(193)))));
            this.sidePanel.Location = new System.Drawing.Point(3, 222);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(14, 35);
            this.sidePanel.TabIndex = 2;
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.logOutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logOutBtn.FlatAppearance.BorderSize = 0;
            this.logOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutBtn.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.logOutBtn.Image = global::Compound_DB.Properties.Resources.LogOut_Icon;
            this.logOutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutBtn.Location = new System.Drawing.Point(0, 527);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(249, 50);
            this.logOutBtn.TabIndex = 1;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // staffBtn
            // 
            this.staffBtn.FlatAppearance.BorderSize = 0;
            this.staffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffBtn.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.staffBtn.Image = global::Compound_DB.Properties.Resources.Search_Icon;
            this.staffBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.staffBtn.Location = new System.Drawing.Point(0, 362);
            this.staffBtn.Name = "staffBtn";
            this.staffBtn.Size = new System.Drawing.Size(246, 44);
            this.staffBtn.TabIndex = 1;
            this.staffBtn.Text = "Staff";
            this.staffBtn.UseVisualStyleBackColor = true;
            this.staffBtn.Click += new System.EventHandler(this.staffBtn_Click);
            this.staffBtn.Leave += new System.EventHandler(this.staffBtn_Leave);
            // 
            // sellUnitBtn
            // 
            this.sellUnitBtn.FlatAppearance.BorderSize = 0;
            this.sellUnitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellUnitBtn.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellUnitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.sellUnitBtn.Image = global::Compound_DB.Properties.Resources.Search_Icon;
            this.sellUnitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sellUnitBtn.Location = new System.Drawing.Point(0, 311);
            this.sellUnitBtn.Name = "sellUnitBtn";
            this.sellUnitBtn.Size = new System.Drawing.Size(246, 44);
            this.sellUnitBtn.TabIndex = 1;
            this.sellUnitBtn.Text = "Selling Units";
            this.sellUnitBtn.UseVisualStyleBackColor = true;
            this.sellUnitBtn.Click += new System.EventHandler(this.sellUnitBtn_Click);
            this.sellUnitBtn.Leave += new System.EventHandler(this.sellUnitBtn_Leave);
            // 
            // servicesBtn
            // 
            this.servicesBtn.FlatAppearance.BorderSize = 0;
            this.servicesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.servicesBtn.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicesBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.servicesBtn.Image = global::Compound_DB.Properties.Resources.Search_Icon;
            this.servicesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.servicesBtn.Location = new System.Drawing.Point(0, 259);
            this.servicesBtn.Name = "servicesBtn";
            this.servicesBtn.Size = new System.Drawing.Size(246, 44);
            this.servicesBtn.TabIndex = 1;
            this.servicesBtn.Text = "Services";
            this.servicesBtn.UseVisualStyleBackColor = true;
            this.servicesBtn.Click += new System.EventHandler(this.servicesBtn_Click);
            this.servicesBtn.Leave += new System.EventHandler(this.servicesBtn_Leave);
            // 
            // addpenaltyBtn
            // 
            this.addpenaltyBtn.FlatAppearance.BorderSize = 0;
            this.addpenaltyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addpenaltyBtn.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addpenaltyBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addpenaltyBtn.Image = global::Compound_DB.Properties.Resources.Search_Icon;
            this.addpenaltyBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addpenaltyBtn.Location = new System.Drawing.Point(0, 206);
            this.addpenaltyBtn.Name = "addpenaltyBtn";
            this.addpenaltyBtn.Size = new System.Drawing.Size(246, 44);
            this.addpenaltyBtn.TabIndex = 1;
            this.addpenaltyBtn.Text = "Add Penalty";
            this.addpenaltyBtn.UseVisualStyleBackColor = true;
            this.addpenaltyBtn.Click += new System.EventHandler(this.addpenaltyBtn_Click);
            this.addpenaltyBtn.Leave += new System.EventHandler(this.addpenaltyBtn_Leave);
            // 
            // checkinvoiceBtn
            // 
            this.checkinvoiceBtn.FlatAppearance.BorderSize = 0;
            this.checkinvoiceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkinvoiceBtn.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinvoiceBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.checkinvoiceBtn.Image = global::Compound_DB.Properties.Resources.Search_Icon;
            this.checkinvoiceBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkinvoiceBtn.Location = new System.Drawing.Point(0, 155);
            this.checkinvoiceBtn.Name = "checkinvoiceBtn";
            this.checkinvoiceBtn.Size = new System.Drawing.Size(246, 44);
            this.checkinvoiceBtn.TabIndex = 1;
            this.checkinvoiceBtn.Text = "Check Invoices";
            this.checkinvoiceBtn.UseVisualStyleBackColor = true;
            this.checkinvoiceBtn.Click += new System.EventHandler(this.checkinvoiceBtn_Click);
            this.checkinvoiceBtn.Leave += new System.EventHandler(this.checkinvoiceBtn_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel3.Controls.Add(this.userNameLabel);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(249, 148);
            this.panel3.TabIndex = 0;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Elephant", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.userNameLabel.Location = new System.Drawing.Point(105, 9);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(127, 25);
            this.userNameLabel.TabIndex = 1;
            this.userNameLabel.Text = "User Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Compound_DB.Properties.Resources.login_user;
            this.pictureBox2.Location = new System.Drawing.Point(12, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.compoundTitleLabel);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(249, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(901, 148);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 154);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 0);
            this.panel4.TabIndex = 3;
            // 
            // compoundTitleLabel
            // 
            this.compoundTitleLabel.AutoSize = true;
            this.compoundTitleLabel.Font = new System.Drawing.Font("Elephant", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compoundTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.compoundTitleLabel.Location = new System.Drawing.Point(527, 113);
            this.compoundTitleLabel.Name = "compoundTitleLabel";
            this.compoundTitleLabel.Size = new System.Drawing.Size(163, 25);
            this.compoundTitleLabel.TabIndex = 1;
            this.compoundTitleLabel.Text = "Cosmo Houses";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox3.Image = global::Compound_DB.Properties.Resources.house_logo;
            this.pictureBox3.Location = new System.Drawing.Point(551, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(103, 96);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.settingsButton.Image = global::Compound_DB.Properties.Resources.Settings_Icon;
            this.settingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.Location = new System.Drawing.Point(0, 471);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(249, 50);
            this.settingsButton.TabIndex = 8;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = false;
            // 
            // sellingunitsUserControl1
            // 
            this.sellingunitsUserControl1.Location = new System.Drawing.Point(247, 136);
            this.sellingunitsUserControl1.Name = "sellingunitsUserControl1";
            this.sellingunitsUserControl1.Size = new System.Drawing.Size(732, 428);
            this.sellingunitsUserControl1.TabIndex = 7;
            // 
            // residentcontrol1
            // 
            this.residentcontrol1.Location = new System.Drawing.Point(247, 142);
            this.residentcontrol1.Name = "residentcontrol1";
            this.residentcontrol1.Size = new System.Drawing.Size(732, 435);
            this.residentcontrol1.TabIndex = 6;
            // 
            // staff1
            // 
            this.staff1.Location = new System.Drawing.Point(255, 142);
            this.staff1.Name = "staff1";
            this.staff1.Size = new System.Drawing.Size(724, 423);
            this.staff1.TabIndex = 5;
            // 
            // services1
            // 
            this.services1.Location = new System.Drawing.Point(247, 141);
            this.services1.Name = "services1";
            this.services1.Size = new System.Drawing.Size(732, 423);
            this.services1.TabIndex = 4;
            // 
            // addPenalty1
            // 
            this.addPenalty1.Location = new System.Drawing.Point(247, 141);
            this.addPenalty1.Name = "addPenalty1";
            this.addPenalty1.Size = new System.Drawing.Size(735, 433);
            this.addPenalty1.TabIndex = 3;
            // 
            // Manager_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(223)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(1150, 577);
            this.Controls.Add(this.sellingunitsUserControl1);
            this.Controls.Add(this.residentcontrol1);
            this.Controls.Add(this.staff1);
            this.Controls.Add(this.services1);
            this.Controls.Add(this.addPenalty1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manager_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Manager_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button staffBtn;
        private System.Windows.Forms.Button sellUnitBtn;
        private System.Windows.Forms.Button servicesBtn;
        private System.Windows.Forms.Button addpenaltyBtn;
        private System.Windows.Forms.Button checkinvoiceBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label compoundTitleLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button residenceBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel4;
        private AddPenalty addPenalty1;
        private services services1;
        private staff staff1;
        private residentcontrol residentcontrol1;
        private sellingunitsUserControl sellingunitsUserControl1;
        private System.Windows.Forms.Button settingsButton;
    }
}