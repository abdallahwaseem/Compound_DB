namespace Compound_DB.Manager
{
    partial class Statistics_Form
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
            this.staff_stat_btn = new System.Windows.Forms.Button();
            this.inv_statistics_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // staff_stat_btn
            // 
            this.staff_stat_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staff_stat_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.staff_stat_btn.Font = new System.Drawing.Font("Elephant", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_stat_btn.ForeColor = System.Drawing.Color.Cornsilk;
            this.staff_stat_btn.Location = new System.Drawing.Point(135, 143);
            this.staff_stat_btn.Margin = new System.Windows.Forms.Padding(4);
            this.staff_stat_btn.Name = "staff_stat_btn";
            this.staff_stat_btn.Size = new System.Drawing.Size(210, 61);
            this.staff_stat_btn.TabIndex = 9;
            this.staff_stat_btn.Text = "Staff Statistics";
            this.staff_stat_btn.UseVisualStyleBackColor = false;
            this.staff_stat_btn.Click += new System.EventHandler(this.staff_stat_btn_Click);
            // 
            // inv_statistics_btn
            // 
            this.inv_statistics_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inv_statistics_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(130)))), ((int)(((byte)(143)))));
            this.inv_statistics_btn.Font = new System.Drawing.Font("Elephant", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inv_statistics_btn.ForeColor = System.Drawing.Color.Cornsilk;
            this.inv_statistics_btn.Location = new System.Drawing.Point(135, 251);
            this.inv_statistics_btn.Margin = new System.Windows.Forms.Padding(4);
            this.inv_statistics_btn.Name = "inv_statistics_btn";
            this.inv_statistics_btn.Size = new System.Drawing.Size(210, 61);
            this.inv_statistics_btn.TabIndex = 9;
            this.inv_statistics_btn.Text = "Invoice Statistics";
            this.inv_statistics_btn.UseVisualStyleBackColor = false;
            this.inv_statistics_btn.Click += new System.EventHandler(this.inv_statistics_btn_Click);
            // 
            // Statistics_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(223)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(486, 463);
            this.Controls.Add(this.inv_statistics_btn);
            this.Controls.Add(this.staff_stat_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Statistics_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistics_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button staff_stat_btn;
        private System.Windows.Forms.Button inv_statistics_btn;
    }
}