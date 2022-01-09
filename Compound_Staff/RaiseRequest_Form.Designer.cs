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
            this.myRequestsGrid = new System.Windows.Forms.DataGridView();
            this.searchMyRequestsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.raiseAmountTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.myRequestsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // myRequestsGrid
            // 
            this.myRequestsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myRequestsGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myRequestsGrid.Location = new System.Drawing.Point(0, 65);
            this.myRequestsGrid.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.myRequestsGrid.Name = "myRequestsGrid";
            this.myRequestsGrid.ReadOnly = true;
            this.myRequestsGrid.RowHeadersWidth = 51;
            this.myRequestsGrid.RowTemplate.Height = 24;
            this.myRequestsGrid.Size = new System.Drawing.Size(610, 288);
            this.myRequestsGrid.TabIndex = 15;
            // 
            // searchMyRequestsBtn
            // 
            this.searchMyRequestsBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.searchMyRequestsBtn.Location = new System.Drawing.Point(769, 65);
            this.searchMyRequestsBtn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.searchMyRequestsBtn.Name = "searchMyRequestsBtn";
            this.searchMyRequestsBtn.Size = new System.Drawing.Size(119, 77);
            this.searchMyRequestsBtn.TabIndex = 14;
            this.searchMyRequestsBtn.Text = "Show Request State";
            this.searchMyRequestsBtn.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(769, 173);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 77);
            this.button1.TabIndex = 14;
            this.button1.Text = "Submit Raise Request";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // raiseAmountTextBox
            // 
            this.raiseAmountTextBox.Location = new System.Drawing.Point(630, 173);
            this.raiseAmountTextBox.Name = "raiseAmountTextBox";
            this.raiseAmountTextBox.Size = new System.Drawing.Size(105, 27);
            this.raiseAmountTextBox.TabIndex = 16;
            // 
            // RaiseRequest_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.raiseAmountTextBox);
            this.Controls.Add(this.myRequestsGrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchMyRequestsBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RaiseRequest_Form";
            this.Size = new System.Drawing.Size(895, 353);
            ((System.ComponentModel.ISupportInitialize)(this.myRequestsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView myRequestsGrid;
        private System.Windows.Forms.Button searchMyRequestsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox raiseAmountTextBox;
    }
}
