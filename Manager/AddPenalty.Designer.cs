
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
            this.addpenaltyBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invoicedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // viewinvoicesBtn
            // 
            this.viewinvoicesBtn.Font = new System.Drawing.Font("Elephant", 8.25F);
            this.viewinvoicesBtn.Location = new System.Drawing.Point(751, 65);
            this.viewinvoicesBtn.Name = "viewinvoicesBtn";
            this.viewinvoicesBtn.Size = new System.Drawing.Size(111, 62);
            this.viewinvoicesBtn.TabIndex = 0;
            this.viewinvoicesBtn.Text = "View Invoices";
            this.viewinvoicesBtn.UseVisualStyleBackColor = true;
            this.viewinvoicesBtn.Click += new System.EventHandler(this.viewinvoicesBtn_Click);
            // 
            // invoicedataGridView
            // 
            this.invoicedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoicedataGridView.Location = new System.Drawing.Point(12, 65);
            this.invoicedataGridView.Name = "invoicedataGridView";
            this.invoicedataGridView.RowHeadersWidth = 51;
            this.invoicedataGridView.RowTemplate.Height = 24;
            this.invoicedataGridView.Size = new System.Drawing.Size(705, 266);
            this.invoicedataGridView.TabIndex = 1;
            // 
            // showoverdueBtn
            // 
            this.showoverdueBtn.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showoverdueBtn.Location = new System.Drawing.Point(751, 172);
            this.showoverdueBtn.Name = "showoverdueBtn";
            this.showoverdueBtn.Size = new System.Drawing.Size(110, 57);
            this.showoverdueBtn.TabIndex = 2;
            this.showoverdueBtn.Text = "Show Overdue";
            this.showoverdueBtn.UseVisualStyleBackColor = true;
            this.showoverdueBtn.Click += new System.EventHandler(this.showoverdueBtn_Click);
            // 
            // addpenaltyBtn
            // 
            this.addpenaltyBtn.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addpenaltyBtn.Location = new System.Drawing.Point(751, 274);
            this.addpenaltyBtn.Name = "addpenaltyBtn";
            this.addpenaltyBtn.Size = new System.Drawing.Size(111, 57);
            this.addpenaltyBtn.TabIndex = 3;
            this.addpenaltyBtn.Text = "Add Penalty";
            this.addpenaltyBtn.UseVisualStyleBackColor = true;
            this.addpenaltyBtn.Click += new System.EventHandler(this.addpenaltyBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 49);
            this.label1.TabIndex = 4;
            this.label1.Text = "Invoices Panel";
            // 
            // AddPenalty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addpenaltyBtn);
            this.Controls.Add(this.showoverdueBtn);
            this.Controls.Add(this.invoicedataGridView);
            this.Controls.Add(this.viewinvoicesBtn);
            this.Name = "AddPenalty";
            this.Size = new System.Drawing.Size(895, 353);
            ((System.ComponentModel.ISupportInitialize)(this.invoicedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewinvoicesBtn;
        private System.Windows.Forms.DataGridView invoicedataGridView;
        private System.Windows.Forms.Button showoverdueBtn;
        private System.Windows.Forms.Button addpenaltyBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
    }
}
