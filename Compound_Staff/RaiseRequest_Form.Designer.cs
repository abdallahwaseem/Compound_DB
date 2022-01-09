namespace Compound_DB.Compound_Staff
{
    partial class RaiseRequest_Form
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
            this.raiseRequestsGrid = new System.Windows.Forms.DataGridView();
            this.showReqStateBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.submitRaiseReqBtn = new System.Windows.Forms.Button();
            this.newSalaryAmountTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.raiseRequestsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // raiseRequestsGrid
            // 
            this.raiseRequestsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.raiseRequestsGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.raiseRequestsGrid.Location = new System.Drawing.Point(0, 65);
            this.raiseRequestsGrid.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.raiseRequestsGrid.Name = "raiseRequestsGrid";
            this.raiseRequestsGrid.ReadOnly = true;
            this.raiseRequestsGrid.RowHeadersWidth = 51;
            this.raiseRequestsGrid.RowTemplate.Height = 24;
            this.raiseRequestsGrid.Size = new System.Drawing.Size(610, 288);
            this.raiseRequestsGrid.TabIndex = 15;
            // 
            // showReqStateBtn
            // 
            this.showReqStateBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.showReqStateBtn.Location = new System.Drawing.Point(769, 65);
            this.showReqStateBtn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.showReqStateBtn.Name = "showReqStateBtn";
            this.showReqStateBtn.Size = new System.Drawing.Size(119, 77);
            this.showReqStateBtn.TabIndex = 14;
            this.showReqStateBtn.Text = "Show Request State";
            this.showReqStateBtn.UseVisualStyleBackColor = true;
            this.showReqStateBtn.Click += new System.EventHandler(this.showReqStateBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 49);
            this.label1.TabIndex = 11;
            this.label1.Text = "Raise Request";
            // 
            // submitRaiseReqBtn
            // 
            this.submitRaiseReqBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.submitRaiseReqBtn.Location = new System.Drawing.Point(769, 173);
            this.submitRaiseReqBtn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.submitRaiseReqBtn.Name = "submitRaiseReqBtn";
            this.submitRaiseReqBtn.Size = new System.Drawing.Size(119, 77);
            this.submitRaiseReqBtn.TabIndex = 14;
            this.submitRaiseReqBtn.Text = "Submit Raise Request";
            this.submitRaiseReqBtn.UseVisualStyleBackColor = true;
            this.submitRaiseReqBtn.Click += new System.EventHandler(this.submitRaiseReqBtn_Click);
            // 
            // newSalaryAmountTextBox
            // 
            this.newSalaryAmountTextBox.Location = new System.Drawing.Point(641, 173);
            this.newSalaryAmountTextBox.Name = "newSalaryAmountTextBox";
            this.newSalaryAmountTextBox.Size = new System.Drawing.Size(105, 27);
            this.newSalaryAmountTextBox.TabIndex = 16;
            // 
            // RaiseRequest_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.newSalaryAmountTextBox);
            this.Controls.Add(this.raiseRequestsGrid);
            this.Controls.Add(this.submitRaiseReqBtn);
            this.Controls.Add(this.showReqStateBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RaiseRequest_Form";
            this.Size = new System.Drawing.Size(895, 353);
            ((System.ComponentModel.ISupportInitialize)(this.raiseRequestsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView raiseRequestsGrid;
        private System.Windows.Forms.Button showReqStateBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitRaiseReqBtn;
        private System.Windows.Forms.TextBox newSalaryAmountTextBox;
    }
}
