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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.searchRequestsBtn = new System.Windows.Forms.Button();
            this.requestsGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.requestsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Working Panel";
            // 
            // searchRequestsBtn
            // 
            this.searchRequestsBtn.Location = new System.Drawing.Point(531, 166);
            this.searchRequestsBtn.Name = "searchRequestsBtn";
            this.searchRequestsBtn.Size = new System.Drawing.Size(119, 61);
            this.searchRequestsBtn.TabIndex = 3;
            this.searchRequestsBtn.Text = "Search Requests";
            this.searchRequestsBtn.UseVisualStyleBackColor = true;
            this.searchRequestsBtn.Click += new System.EventHandler(this.searchRequestsBtn_Click);
            // 
            // requestsGrid
            // 
            this.requestsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestsGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.requestsGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.requestsGrid.Location = new System.Drawing.Point(0, 0);
            this.requestsGrid.Name = "requestsGrid";
            this.requestsGrid.RowHeadersWidth = 51;
            this.requestsGrid.RowTemplate.Height = 24;
            this.requestsGrid.Size = new System.Drawing.Size(458, 353);
            this.requestsGrid.TabIndex = 4;
            // 
            // WorkingPanel_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.requestsGrid);
            this.Controls.Add(this.searchRequestsBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "WorkingPanel_Form";
            this.Size = new System.Drawing.Size(700, 353);
            ((System.ComponentModel.ISupportInitialize)(this.requestsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchRequestsBtn;
        private System.Windows.Forms.DataGridView requestsGrid;
    }
}
