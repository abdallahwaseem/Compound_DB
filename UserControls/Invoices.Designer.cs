
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Invoices_Grid)).BeginInit();
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
            this.Invoices_Grid.Location = new System.Drawing.Point(3, 13);
            this.Invoices_Grid.Name = "Invoices_Grid";
            this.Invoices_Grid.Size = new System.Drawing.Size(696, 205);
            this.Invoices_Grid.TabIndex = 0;
            // 
            // paying_Panel
            // 
            this.paying_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paying_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(64)))));
            this.paying_Panel.Location = new System.Drawing.Point(0, 297);
            this.paying_Panel.Name = "paying_Panel";
            this.paying_Panel.Size = new System.Drawing.Size(699, 129);
            this.paying_Panel.TabIndex = 4;
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
            ((System.ComponentModel.ISupportInitialize)(this.Invoices_Grid)).EndInit();
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
    }
}
