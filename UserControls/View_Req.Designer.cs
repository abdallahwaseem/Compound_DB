
namespace Compound_DB.UserControls
{
    partial class View_Req
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
            this.Req_Grid = new System.Windows.Forms.DataGridView();
            this.Your_Requests = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Req_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Req_Grid
            // 
            this.Req_Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(223)))), ((int)(((byte)(186)))));
            this.Req_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Req_Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(223)))), ((int)(((byte)(186)))));
            this.Req_Grid.Location = new System.Drawing.Point(53, 75);
            this.Req_Grid.Name = "Req_Grid";
            this.Req_Grid.Size = new System.Drawing.Size(600, 150);
            this.Req_Grid.TabIndex = 0;
            this.Req_Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Req_Grid_CellContentClick);
            // 
            // Your_Requests
            // 
            this.Your_Requests.AutoSize = true;
            this.Your_Requests.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Your_Requests.Location = new System.Drawing.Point(289, 39);
            this.Your_Requests.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Your_Requests.Name = "Your_Requests";
            this.Your_Requests.Size = new System.Drawing.Size(130, 21);
            this.Your_Requests.TabIndex = 2;
            this.Your_Requests.Text = "Your_Requests";
            // 
            // View_Req
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(223)))), ((int)(((byte)(190)))));
            this.Controls.Add(this.Your_Requests);
            this.Controls.Add(this.Req_Grid);
            this.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "View_Req";
            this.Size = new System.Drawing.Size(702, 291);
            this.Load += new System.EventHandler(this.View_Req_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Req_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Req_Grid;
        private System.Windows.Forms.Label Your_Requests;
    }
}
