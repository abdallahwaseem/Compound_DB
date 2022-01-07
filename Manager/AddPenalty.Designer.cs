
namespace Compound_DB.Manager
{
    partial class AddPenalty
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
            this.viewinvoicesBtn = new System.Windows.Forms.Button();
            this.invoicedataGridView = new System.Windows.Forms.DataGridView();
            this.showoverdueBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.invoicedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // viewinvoicesBtn
            // 
            this.viewinvoicesBtn.Location = new System.Drawing.Point(13, 210);
            this.viewinvoicesBtn.Name = "viewinvoicesBtn";
            this.viewinvoicesBtn.Size = new System.Drawing.Size(100, 50);
            this.viewinvoicesBtn.TabIndex = 0;
            this.viewinvoicesBtn.Text = "View Invoices";
            this.viewinvoicesBtn.UseVisualStyleBackColor = true;
            this.viewinvoicesBtn.Click += new System.EventHandler(this.viewinvoicesBtn_Click);
            // 
            // invoicedataGridView
            // 
            this.invoicedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoicedataGridView.Location = new System.Drawing.Point(0, 0);
            this.invoicedataGridView.Name = "invoicedataGridView";
            this.invoicedataGridView.RowHeadersWidth = 51;
            this.invoicedataGridView.RowTemplate.Height = 24;
            this.invoicedataGridView.Size = new System.Drawing.Size(732, 204);
            this.invoicedataGridView.TabIndex = 1;
            // 
            // showoverdueBtn
            // 
            this.showoverdueBtn.Location = new System.Drawing.Point(143, 210);
            this.showoverdueBtn.Name = "showoverdueBtn";
            this.showoverdueBtn.Size = new System.Drawing.Size(100, 50);
            this.showoverdueBtn.TabIndex = 2;
            this.showoverdueBtn.Text = "Show Overdue";
            this.showoverdueBtn.UseVisualStyleBackColor = true;
            this.showoverdueBtn.Click += new System.EventHandler(this.showoverdueBtn_Click);
            // 
            // AddPenalty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.showoverdueBtn);
            this.Controls.Add(this.invoicedataGridView);
            this.Controls.Add(this.viewinvoicesBtn);
            this.Name = "AddPenalty";
            this.Size = new System.Drawing.Size(732, 423);
            ((System.ComponentModel.ISupportInitialize)(this.invoicedataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewinvoicesBtn;
        private System.Windows.Forms.DataGridView invoicedataGridView;
        private System.Windows.Forms.Button showoverdueBtn;
    }
}
