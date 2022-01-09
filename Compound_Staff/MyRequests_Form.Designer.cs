namespace Compound_DB.Compound_Staff
{
    partial class MyRequest_ControlForm
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
            this.myRequestsIdsComboBox = new System.Windows.Forms.ComboBox();
            this.myRequestsGrid = new System.Windows.Forms.DataGridView();
            this.requestCompleted = new System.Windows.Forms.Button();
            this.searchMyRequestsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.showCompletedRequestsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.myRequestsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // myRequestsIdsComboBox
            // 
            this.myRequestsIdsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.myRequestsIdsComboBox.FormattingEnabled = true;
            this.myRequestsIdsComboBox.Location = new System.Drawing.Point(637, 222);
            this.myRequestsIdsComboBox.Name = "myRequestsIdsComboBox";
            this.myRequestsIdsComboBox.Size = new System.Drawing.Size(121, 28);
            this.myRequestsIdsComboBox.TabIndex = 10;
            this.myRequestsIdsComboBox.DropDown += new System.EventHandler(this.myRequestsIdsComboBox_DropDown);
            // 
            // myRequestsGrid
            // 
            this.myRequestsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myRequestsGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myRequestsGrid.Location = new System.Drawing.Point(5, 65);
            this.myRequestsGrid.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.myRequestsGrid.Name = "myRequestsGrid";
            this.myRequestsGrid.ReadOnly = true;
            this.myRequestsGrid.RowHeadersWidth = 51;
            this.myRequestsGrid.RowTemplate.Height = 24;
            this.myRequestsGrid.Size = new System.Drawing.Size(610, 288);
            this.myRequestsGrid.TabIndex = 9;
            // 
            // requestCompleted
            // 
            this.requestCompleted.Location = new System.Drawing.Point(767, 222);
            this.requestCompleted.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.requestCompleted.Name = "requestCompleted";
            this.requestCompleted.Size = new System.Drawing.Size(119, 61);
            this.requestCompleted.TabIndex = 7;
            this.requestCompleted.Text = "Request Completed";
            this.requestCompleted.UseVisualStyleBackColor = true;
            this.requestCompleted.Click += new System.EventHandler(this.requestCompleted_Click);
            // 
            // searchMyRequestsBtn
            // 
            this.searchMyRequestsBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.searchMyRequestsBtn.Location = new System.Drawing.Point(767, 65);
            this.searchMyRequestsBtn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.searchMyRequestsBtn.Name = "searchMyRequestsBtn";
            this.searchMyRequestsBtn.Size = new System.Drawing.Size(119, 61);
            this.searchMyRequestsBtn.TabIndex = 8;
            this.searchMyRequestsBtn.Text = "Search My Requests";
            this.searchMyRequestsBtn.UseVisualStyleBackColor = true;
            this.searchMyRequestsBtn.Click += new System.EventHandler(this.searchMyRequestsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 49);
            this.label1.TabIndex = 6;
            this.label1.Text = "My Requests";
            // 
            // showCompletedRequestsBtn
            // 
            this.showCompletedRequestsBtn.Location = new System.Drawing.Point(767, 143);
            this.showCompletedRequestsBtn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.showCompletedRequestsBtn.Name = "showCompletedRequestsBtn";
            this.showCompletedRequestsBtn.Size = new System.Drawing.Size(119, 61);
            this.showCompletedRequestsBtn.TabIndex = 8;
            this.showCompletedRequestsBtn.Text = "Show Completed";
            this.showCompletedRequestsBtn.UseVisualStyleBackColor = true;
            this.showCompletedRequestsBtn.Click += new System.EventHandler(this.showCompletedRequestsBtn_Click);
            // 
            // MyRequest_ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.myRequestsIdsComboBox);
            this.Controls.Add(this.myRequestsGrid);
            this.Controls.Add(this.requestCompleted);
            this.Controls.Add(this.showCompletedRequestsBtn);
            this.Controls.Add(this.searchMyRequestsBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MyRequest_ControlForm";
            this.Size = new System.Drawing.Size(895, 353);
            ((System.ComponentModel.ISupportInitialize)(this.myRequestsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox myRequestsIdsComboBox;
        private System.Windows.Forms.DataGridView myRequestsGrid;
        private System.Windows.Forms.Button requestCompleted;
        private System.Windows.Forms.Button searchMyRequestsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showCompletedRequestsBtn;
    }
}
