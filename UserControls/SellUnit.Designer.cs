
namespace Compound_DB.Resident.UserControls
{
    partial class SellUnit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellUnit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TransferOwnership = new System.Windows.Forms.Label();
            this.confrim_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.TransferOwnership);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 79);
            this.panel1.TabIndex = 9;
            // 
            // TransferOwnership
            // 
            this.TransferOwnership.AutoSize = true;
            this.TransferOwnership.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransferOwnership.ForeColor = System.Drawing.Color.White;
            this.TransferOwnership.Location = new System.Drawing.Point(168, 28);
            this.TransferOwnership.Name = "TransferOwnership";
            this.TransferOwnership.Size = new System.Drawing.Size(344, 27);
            this.TransferOwnership.TabIndex = 5;
            this.TransferOwnership.Text = "Transfer Ownership Request";
            // 
            // confrim_btn
            // 
            this.confrim_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.confrim_btn.FlatAppearance.BorderSize = 0;
            this.confrim_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confrim_btn.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confrim_btn.ForeColor = System.Drawing.Color.Black;
            //this.confrim_btn.Image = global::Compound_DB.Properties.Resources.invoice6;
            this.confrim_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.confrim_btn.Location = new System.Drawing.Point(206, 296);
            this.confrim_btn.Name = "confrim_btn";
            this.confrim_btn.Size = new System.Drawing.Size(284, 44);
            this.confrim_btn.TabIndex = 10;
            this.confrim_btn.Text = "Confirm Selling Request";
            this.confrim_btn.UseVisualStyleBackColor = false;
            this.confrim_btn.Click += new System.EventHandler(this.confrim_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(301, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Instructions !";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(665, 85);
            this.label2.TabIndex = 12;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // SellUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(223)))), ((int)(((byte)(186)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confrim_btn);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SellUnit";
            this.Size = new System.Drawing.Size(702, 429);
            this.Load += new System.EventHandler(this.SellUnit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TransferOwnership;
        private System.Windows.Forms.Button confrim_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
