
namespace Compound_DB.UserControls
{
    partial class Invoices
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
            this.Invoices_title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Invoices_Grid = new System.Windows.Forms.DataGridView();
            this.paying_Panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.All_Invoices = new System.Windows.Forms.RadioButton();
            this.PendingRadioBtn = new System.Windows.Forms.RadioButton();
            this.PaidRadioBtn = new System.Windows.Forms.RadioButton();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.amount_label = new System.Windows.Forms.Label();
            this.PayLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ClickInstruction = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Invoices_Grid)).BeginInit();
            this.paying_Panel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Invoices_title
            // 
            this.Invoices_title.AutoSize = true;
            this.Invoices_title.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Invoices_title.ForeColor = System.Drawing.Color.White;
            this.Invoices_title.Location = new System.Drawing.Point(262, 25);
            this.Invoices_title.Name = "Invoices_title";
            this.Invoices_title.Size = new System.Drawing.Size(170, 27);
            this.Invoices_title.TabIndex = 2;
            this.Invoices_title.Text = "Your Invoices";
            this.Invoices_title.Click += new System.EventHandler(this.temp_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ClickInstruction);
            this.panel1.Controls.Add(this.Invoices_Grid);
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 227);
            this.panel1.TabIndex = 3;
            // 
            // Invoices_Grid
            // 
            this.Invoices_Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(223)))), ((int)(((byte)(186)))));
            this.Invoices_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Invoices_Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(223)))), ((int)(((byte)(186)))));
            this.Invoices_Grid.Location = new System.Drawing.Point(3, 55);
            this.Invoices_Grid.Name = "Invoices_Grid";
            this.Invoices_Grid.ReadOnly = true;
            this.Invoices_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Invoices_Grid.Size = new System.Drawing.Size(696, 163);
            this.Invoices_Grid.TabIndex = 0;
            this.Invoices_Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Invoices_Grid_CellContentClick);
            this.Invoices_Grid.Click += new System.EventHandler(this.Invoices_Grid_Click);
            // 
            // paying_Panel
            // 
            this.paying_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paying_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(64)))));
            this.paying_Panel.Controls.Add(this.label1);
            this.paying_Panel.Controls.Add(this.All_Invoices);
            this.paying_Panel.Controls.Add(this.PendingRadioBtn);
            this.paying_Panel.Controls.Add(this.PaidRadioBtn);
            this.paying_Panel.Controls.Add(this.ConfirmBtn);
            this.paying_Panel.Controls.Add(this.amount_label);
            this.paying_Panel.Controls.Add(this.PayLabel);
            this.paying_Panel.Location = new System.Drawing.Point(0, 297);
            this.paying_Panel.Name = "paying_Panel";
            this.paying_Panel.Size = new System.Drawing.Size(699, 129);
            this.paying_Panel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filter:";
            // 
            // All_Invoices
            // 
            this.All_Invoices.AutoSize = true;
            this.All_Invoices.ForeColor = System.Drawing.Color.White;
            this.All_Invoices.Location = new System.Drawing.Point(231, 14);
            this.All_Invoices.Name = "All_Invoices";
            this.All_Invoices.Size = new System.Drawing.Size(127, 24);
            this.All_Invoices.TabIndex = 9;
            this.All_Invoices.TabStop = true;
            this.All_Invoices.Text = "All Invoices";
            this.All_Invoices.UseVisualStyleBackColor = true;
            this.All_Invoices.CheckedChanged += new System.EventHandler(this.All_Invoices_CheckedChanged);
            // 
            // PendingRadioBtn
            // 
            this.PendingRadioBtn.AutoSize = true;
            this.PendingRadioBtn.ForeColor = System.Drawing.Color.White;
            this.PendingRadioBtn.Location = new System.Drawing.Point(397, 15);
            this.PendingRadioBtn.Name = "PendingRadioBtn";
            this.PendingRadioBtn.Size = new System.Drawing.Size(96, 24);
            this.PendingRadioBtn.TabIndex = 8;
            this.PendingRadioBtn.TabStop = true;
            this.PendingRadioBtn.Text = "Pending";
            this.PendingRadioBtn.UseVisualStyleBackColor = true;
            this.PendingRadioBtn.CheckedChanged += new System.EventHandler(this.PendingRadioBtn_CheckedChanged);
            // 
            // PaidRadioBtn
            // 
            this.PaidRadioBtn.AutoSize = true;
            this.PaidRadioBtn.ForeColor = System.Drawing.Color.White;
            this.PaidRadioBtn.Location = new System.Drawing.Point(564, 15);
            this.PaidRadioBtn.Name = "PaidRadioBtn";
            this.PaidRadioBtn.Size = new System.Drawing.Size(66, 24);
            this.PaidRadioBtn.TabIndex = 7;
            this.PaidRadioBtn.TabStop = true;
            this.PaidRadioBtn.Text = "Paid";
            this.PaidRadioBtn.UseVisualStyleBackColor = true;
            this.PaidRadioBtn.CheckedChanged += new System.EventHandler(this.PaidRadioBtn_CheckedChanged);
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ConfirmBtn.FlatAppearance.BorderSize = 0;
            this.ConfirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmBtn.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ConfirmBtn.Image = global::Compound_DB.Properties.Resources.invoice6;
            this.ConfirmBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ConfirmBtn.Location = new System.Drawing.Point(440, 71);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(246, 44);
            this.ConfirmBtn.TabIndex = 5;
            this.ConfirmBtn.Text = "Confirm";
            this.ConfirmBtn.UseVisualStyleBackColor = false;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // amount_label
            // 
            this.amount_label.AutoSize = true;
            this.amount_label.ForeColor = System.Drawing.Color.White;
            this.amount_label.Location = new System.Drawing.Point(331, 57);
            this.amount_label.Name = "amount_label";
            this.amount_label.Size = new System.Drawing.Size(0, 20);
            this.amount_label.TabIndex = 4;
            // 
            // PayLabel
            // 
            this.PayLabel.AutoSize = true;
            this.PayLabel.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayLabel.ForeColor = System.Drawing.Color.White;
            this.PayLabel.Location = new System.Drawing.Point(25, 55);
            this.PayLabel.Name = "PayLabel";
            this.PayLabel.Size = new System.Drawing.Size(300, 21);
            this.PayLabel.TabIndex = 3;
            this.PayLabel.Text = "Pay this invoice of total amount : \r\n";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.Invoices_title);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(702, 67);
            this.panel3.TabIndex = 6;
            // 
            // ClickInstruction
            // 
            this.ClickInstruction.AutoSize = true;
            this.ClickInstruction.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClickInstruction.ForeColor = System.Drawing.Color.Black;
            this.ClickInstruction.Location = new System.Drawing.Point(95, 16);
            this.ClickInstruction.Name = "ClickInstruction";
            this.ClickInstruction.Size = new System.Drawing.Size(535, 27);
            this.ClickInstruction.TabIndex = 3;
            this.ClickInstruction.Text = "Click on any Invoice to proceed with payement";
            // 
            // Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(223)))), ((int)(((byte)(186)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.paying_Panel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Elephant", 10.8F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Invoices";
            this.Size = new System.Drawing.Size(702, 429);
            this.Load += new System.EventHandler(this.Invoices_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Invoices_Grid)).EndInit();
            this.paying_Panel.ResumeLayout(false);
            this.paying_Panel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Invoices_title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Invoices_Grid;
        private System.Windows.Forms.Panel paying_Panel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label PayLabel;
        private System.Windows.Forms.Label amount_label;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.RadioButton PendingRadioBtn;
        private System.Windows.Forms.RadioButton PaidRadioBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton All_Invoices;
        private System.Windows.Forms.Label ClickInstruction;
    }
}
