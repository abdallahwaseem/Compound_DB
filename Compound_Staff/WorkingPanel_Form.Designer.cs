namespace Compound_DB.Compound_Staff
{
    partial class WorkingPanel_ControlForm
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
            this.requestsIdsComboBox = new System.Windows.Forms.ComboBox();
            this.acceptRequest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.requestsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pending Requests";
            // 
            // searchRequestsBtn
            // 
            this.searchRequestsBtn.Location = new System.Drawing.Point(765, 85);
            this.searchRequestsBtn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
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
            this.requestsGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.requestsGrid.Location = new System.Drawing.Point(0, 65);
            this.requestsGrid.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.requestsGrid.Name = "requestsGrid";
            this.requestsGrid.ReadOnly = true;
            this.requestsGrid.RowHeadersWidth = 51;
            this.requestsGrid.RowTemplate.Height = 24;
            this.requestsGrid.Size = new System.Drawing.Size(610, 288);
            this.requestsGrid.TabIndex = 4;
            // 
            // requestsIdsComboBox
            // 
            this.requestsIdsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.requestsIdsComboBox.FormattingEnabled = true;
            this.requestsIdsComboBox.Location = new System.Drawing.Point(632, 202);
            this.requestsIdsComboBox.Name = "requestsIdsComboBox";
            this.requestsIdsComboBox.Size = new System.Drawing.Size(121, 28);
            this.requestsIdsComboBox.TabIndex = 5;
            this.requestsIdsComboBox.DropDown += new System.EventHandler(this.requestsIdsComboBox_DropDown);
            // 
            // acceptRequest
            // 
            this.acceptRequest.Location = new System.Drawing.Point(765, 202);
            this.acceptRequest.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.acceptRequest.Name = "acceptRequest";
            this.acceptRequest.Size = new System.Drawing.Size(119, 61);
            this.acceptRequest.TabIndex = 3;
            this.acceptRequest.Text = "Accept Request";
            this.acceptRequest.UseVisualStyleBackColor = true;
            this.acceptRequest.Click += new System.EventHandler(this.acceptRequest_Click);
            // 
            // WorkingPanel_ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.requestsIdsComboBox);
            this.Controls.Add(this.requestsGrid);
            this.Controls.Add(this.acceptRequest);
            this.Controls.Add(this.searchRequestsBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WorkingPanel_ControlForm";
            this.Size = new System.Drawing.Size(895, 353);
            ((System.ComponentModel.ISupportInitialize)(this.requestsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchRequestsBtn;
        private System.Windows.Forms.DataGridView requestsGrid;
        private System.Windows.Forms.ComboBox requestsIdsComboBox;
        private System.Windows.Forms.Button acceptRequest;
    }
}
