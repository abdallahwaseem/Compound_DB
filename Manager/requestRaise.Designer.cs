
namespace Compound_DB.Manager
{
    partial class requestRaise
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
            this.raisingreqdataGrid = new System.Windows.Forms.DataGridView();
            this.viewrrequestsBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.raisingstaffComboBox = new System.Windows.Forms.ComboBox();
            this.acceptReqBtn = new System.Windows.Forms.Button();
            this.rejectBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.raisingreqdataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 49);
            this.label1.TabIndex = 5;
            this.label1.Text = "Raises Requests";
            // 
            // raisingreqdataGrid
            // 
            this.raisingreqdataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.raisingreqdataGrid.Location = new System.Drawing.Point(32, 66);
            this.raisingreqdataGrid.Name = "raisingreqdataGrid";
            this.raisingreqdataGrid.RowHeadersWidth = 51;
            this.raisingreqdataGrid.RowTemplate.Height = 24;
            this.raisingreqdataGrid.Size = new System.Drawing.Size(627, 209);
            this.raisingreqdataGrid.TabIndex = 6;
            // 
            // viewrrequestsBtn
            // 
            this.viewrrequestsBtn.Font = new System.Drawing.Font("Elephant", 8.25F);
            this.viewrrequestsBtn.Location = new System.Drawing.Point(704, 85);
            this.viewrrequestsBtn.Name = "viewrrequestsBtn";
            this.viewrrequestsBtn.Size = new System.Drawing.Size(130, 57);
            this.viewrrequestsBtn.TabIndex = 7;
            this.viewrrequestsBtn.Text = "View Raise Requests";
            this.viewrrequestsBtn.UseVisualStyleBackColor = true;
            this.viewrrequestsBtn.Click += new System.EventHandler(this.viewrrequestsBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 8.25F);
            this.label4.Location = new System.Drawing.Point(701, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 57;
            this.label4.Text = "Staff ID";
            // 
            // raisingstaffComboBox
            // 
            this.raisingstaffComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.raisingstaffComboBox.FormattingEnabled = true;
            this.raisingstaffComboBox.Location = new System.Drawing.Point(704, 179);
            this.raisingstaffComboBox.Name = "raisingstaffComboBox";
            this.raisingstaffComboBox.Size = new System.Drawing.Size(130, 24);
            this.raisingstaffComboBox.TabIndex = 56;
            this.raisingstaffComboBox.DropDown += new System.EventHandler(this.raisingstaffComboBox_DropDown);
            // 
            // acceptReqBtn
            // 
            this.acceptReqBtn.Font = new System.Drawing.Font("Elephant", 8.25F);
            this.acceptReqBtn.Location = new System.Drawing.Point(704, 240);
            this.acceptReqBtn.Name = "acceptReqBtn";
            this.acceptReqBtn.Size = new System.Drawing.Size(130, 35);
            this.acceptReqBtn.TabIndex = 55;
            this.acceptReqBtn.Text = "Accept Request";
            this.acceptReqBtn.UseVisualStyleBackColor = true;
            this.acceptReqBtn.Click += new System.EventHandler(this.acceptReqBtn_Click);
            // 
            // rejectBtn
            // 
            this.rejectBtn.Font = new System.Drawing.Font("Elephant", 8.25F);
            this.rejectBtn.Location = new System.Drawing.Point(704, 290);
            this.rejectBtn.Name = "rejectBtn";
            this.rejectBtn.Size = new System.Drawing.Size(130, 38);
            this.rejectBtn.TabIndex = 58;
            this.rejectBtn.Text = "Reject Request";
            this.rejectBtn.UseVisualStyleBackColor = true;
            this.rejectBtn.Click += new System.EventHandler(this.rejectBtn_Click);
            // 
            // requestRaise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rejectBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.raisingstaffComboBox);
            this.Controls.Add(this.acceptReqBtn);
            this.Controls.Add(this.viewrrequestsBtn);
            this.Controls.Add(this.raisingreqdataGrid);
            this.Controls.Add(this.label1);
            this.Name = "requestRaise";
            this.Size = new System.Drawing.Size(895, 353);
            ((System.ComponentModel.ISupportInitialize)(this.raisingreqdataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView raisingreqdataGrid;
        private System.Windows.Forms.Button viewrrequestsBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox raisingstaffComboBox;
        private System.Windows.Forms.Button acceptReqBtn;
        private System.Windows.Forms.Button rejectBtn;
    }
}
