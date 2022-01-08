namespace Compound_DB.Compound_Staff
{
    partial class WorkingPanel_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.requestsGrid = new System.Windows.Forms.DataGridView();
            this.searchRequestsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.requestsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(558, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Working Panel";
            // 
            // requestsGrid
            // 
            this.requestsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestsGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.requestsGrid.Location = new System.Drawing.Point(0, 0);
            this.requestsGrid.Name = "requestsGrid";
            this.requestsGrid.RowHeadersWidth = 51;
            this.requestsGrid.RowTemplate.Height = 24;
            this.requestsGrid.Size = new System.Drawing.Size(534, 400);
            this.requestsGrid.TabIndex = 1;
            // 
            // searchRequestsBtn
            // 
            this.searchRequestsBtn.Location = new System.Drawing.Point(663, 104);
            this.searchRequestsBtn.Name = "searchRequestsBtn";
            this.searchRequestsBtn.Size = new System.Drawing.Size(119, 61);
            this.searchRequestsBtn.TabIndex = 2;
            this.searchRequestsBtn.Text = "Search Requests";
            this.searchRequestsBtn.UseVisualStyleBackColor = true;
            // 
            // WorkingPanel_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 400);
            this.Controls.Add(this.searchRequestsBtn);
            this.Controls.Add(this.requestsGrid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkingPanel_Form";
            this.Text = "WorkingPanel_Form";
            ((System.ComponentModel.ISupportInitialize)(this.requestsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView requestsGrid;
        private System.Windows.Forms.Button searchRequestsBtn;
    }
}