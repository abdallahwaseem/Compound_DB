
namespace Compound_DB.Resident.UserControls
{
    partial class Entrance_code
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Entrance_code_Title = new System.Windows.Forms.Label();
            this.Visitor_NametxtBox = new System.Windows.Forms.TextBox();
            this.Visit_Datepicker = new System.Windows.Forms.DateTimePicker();
            this.confrim_btn = new System.Windows.Forms.Button();
            this.visitorName = new System.Windows.Forms.Label();
            this.VisitingDate = new System.Windows.Forms.Label();
            this.CodeTxtbox = new System.Windows.Forms.TextBox();
            this.EntranceCode = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.Entrance_code_Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 79);
            this.panel1.TabIndex = 5;
            // 
            // Entrance_code_Title
            // 
            this.Entrance_code_Title.AutoSize = true;
            this.Entrance_code_Title.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entrance_code_Title.ForeColor = System.Drawing.Color.White;
            this.Entrance_code_Title.Location = new System.Drawing.Point(258, 31);
            this.Entrance_code_Title.Name = "Entrance_code_Title";
            this.Entrance_code_Title.Size = new System.Drawing.Size(182, 27);
            this.Entrance_code_Title.TabIndex = 6;
            this.Entrance_code_Title.Text = "Entrance Code";
            // 
            // Visitor_NametxtBox
            // 
            this.Visitor_NametxtBox.Location = new System.Drawing.Point(263, 170);
            this.Visitor_NametxtBox.Name = "Visitor_NametxtBox";
            this.Visitor_NametxtBox.Size = new System.Drawing.Size(236, 22);
            this.Visitor_NametxtBox.TabIndex = 6;
            this.Visitor_NametxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Visitor_NametxtBox_KeyPress);
            // 
            // Visit_Datepicker
            // 
            this.Visit_Datepicker.Location = new System.Drawing.Point(263, 228);
            this.Visit_Datepicker.Name = "Visit_Datepicker";
            this.Visit_Datepicker.Size = new System.Drawing.Size(236, 22);
            this.Visit_Datepicker.TabIndex = 7;
            // 
            // confrim_btn
            // 
            this.confrim_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.confrim_btn.FlatAppearance.BorderSize = 0;
            this.confrim_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confrim_btn.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confrim_btn.ForeColor = System.Drawing.Color.Black;
            this.confrim_btn.Image = global::Compound_DB.Properties.Resources.invoice6;
            this.confrim_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.confrim_btn.Location = new System.Drawing.Point(428, 330);
            this.confrim_btn.Name = "confrim_btn";
            this.confrim_btn.Size = new System.Drawing.Size(246, 44);
            this.confrim_btn.TabIndex = 8;
            this.confrim_btn.Text = "Confirm ";
            this.confrim_btn.UseVisualStyleBackColor = false;
            this.confrim_btn.Click += new System.EventHandler(this.confrim_btn_Click);
            // 
            // visitorName
            // 
            this.visitorName.AutoSize = true;
            this.visitorName.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorName.Location = new System.Drawing.Point(23, 168);
            this.visitorName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.visitorName.Name = "visitorName";
            this.visitorName.Size = new System.Drawing.Size(113, 21);
            this.visitorName.TabIndex = 9;
            this.visitorName.Text = "Visitor Name";
            // 
            // VisitingDate
            // 
            this.VisitingDate.AutoSize = true;
            this.VisitingDate.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisitingDate.Location = new System.Drawing.Point(23, 228);
            this.VisitingDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VisitingDate.Name = "VisitingDate";
            this.VisitingDate.Size = new System.Drawing.Size(112, 21);
            this.VisitingDate.TabIndex = 10;
            this.VisitingDate.Text = "Visiting Date";
            // 
            // CodeTxtbox
            // 
            this.CodeTxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CodeTxtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(223)))), ((int)(((byte)(186)))));
            this.CodeTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CodeTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeTxtbox.ForeColor = System.Drawing.Color.Gray;
            this.CodeTxtbox.Location = new System.Drawing.Point(178, 345);
            this.CodeTxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.CodeTxtbox.Name = "CodeTxtbox";
            this.CodeTxtbox.Size = new System.Drawing.Size(210, 17);
            this.CodeTxtbox.TabIndex = 11;
            this.CodeTxtbox.Text = "code appears here";
            // 
            // EntranceCode
            // 
            this.EntranceCode.AutoSize = true;
            this.EntranceCode.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntranceCode.Location = new System.Drawing.Point(23, 343);
            this.EntranceCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EntranceCode.Name = "EntranceCode";
            this.EntranceCode.Size = new System.Drawing.Size(136, 21);
            this.EntranceCode.TabIndex = 12;
            this.EntranceCode.Text = "Generated Code";
            // 
            // Entrance_code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(223)))), ((int)(((byte)(186)))));
            this.Controls.Add(this.EntranceCode);
            this.Controls.Add(this.CodeTxtbox);
            this.Controls.Add(this.VisitingDate);
            this.Controls.Add(this.visitorName);
            this.Controls.Add(this.confrim_btn);
            this.Controls.Add(this.Visit_Datepicker);
            this.Controls.Add(this.Visitor_NametxtBox);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Entrance_code";
            this.Size = new System.Drawing.Size(702, 429);
            this.Load += new System.EventHandler(this.Entrance_code_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Entrance_code_Title;
        private System.Windows.Forms.TextBox Visitor_NametxtBox;
        private System.Windows.Forms.DateTimePicker Visit_Datepicker;
        private System.Windows.Forms.Button confrim_btn;
        private System.Windows.Forms.Label visitorName;
        private System.Windows.Forms.Label VisitingDate;
        private System.Windows.Forms.TextBox CodeTxtbox;
        private System.Windows.Forms.Label EntranceCode;
    }
}
