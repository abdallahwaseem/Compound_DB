
namespace Compound_DB.Manager
{
    partial class sellingunitsUserControl
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
            this.sellingunitsdataGrid = new System.Windows.Forms.DataGridView();
            this.addpenaltyBtn = new System.Windows.Forms.Button();
            this.viewinvoicesBtn = new System.Windows.Forms.Button();
            this.sellingresdComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sellingunitsdataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // sellingunitsdataGrid
            // 
            this.sellingunitsdataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellingunitsdataGrid.Location = new System.Drawing.Point(0, 3);
            this.sellingunitsdataGrid.Name = "sellingunitsdataGrid";
            this.sellingunitsdataGrid.RowHeadersWidth = 51;
            this.sellingunitsdataGrid.RowTemplate.Height = 24;
            this.sellingunitsdataGrid.Size = new System.Drawing.Size(729, 204);
            this.sellingunitsdataGrid.TabIndex = 2;
            // 
            // addpenaltyBtn
            // 
            this.addpenaltyBtn.Location = new System.Drawing.Point(458, 241);
            this.addpenaltyBtn.Name = "addpenaltyBtn";
            this.addpenaltyBtn.Size = new System.Drawing.Size(111, 57);
            this.addpenaltyBtn.TabIndex = 6;
            this.addpenaltyBtn.Text = "Accept Request";
            this.addpenaltyBtn.UseVisualStyleBackColor = true;
            this.addpenaltyBtn.Click += new System.EventHandler(this.addpenaltyBtn_Click);
            // 
            // viewinvoicesBtn
            // 
            this.viewinvoicesBtn.Location = new System.Drawing.Point(118, 241);
            this.viewinvoicesBtn.Name = "viewinvoicesBtn";
            this.viewinvoicesBtn.Size = new System.Drawing.Size(142, 57);
            this.viewinvoicesBtn.TabIndex = 4;
            this.viewinvoicesBtn.Text = "View Selling Units";
            this.viewinvoicesBtn.UseVisualStyleBackColor = true;
            this.viewinvoicesBtn.Click += new System.EventHandler(this.viewinvoicesBtn_Click);
            // 
            // sellingresdComboBox
            // 
            this.sellingresdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sellingresdComboBox.FormattingEnabled = true;
            this.sellingresdComboBox.Location = new System.Drawing.Point(308, 258);
            this.sellingresdComboBox.Name = "sellingresdComboBox";
            this.sellingresdComboBox.Size = new System.Drawing.Size(130, 24);
            this.sellingresdComboBox.TabIndex = 53;
            this.sellingresdComboBox.DropDown += new System.EventHandler(this.sellingresdComboBox_DropDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 238);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 54;
            this.label4.Text = "Resident ID";
            // 
            // sellingunitsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sellingresdComboBox);
            this.Controls.Add(this.addpenaltyBtn);
            this.Controls.Add(this.viewinvoicesBtn);
            this.Controls.Add(this.sellingunitsdataGrid);
            this.Name = "sellingunitsUserControl";
            this.Size = new System.Drawing.Size(732, 423);
            ((System.ComponentModel.ISupportInitialize)(this.sellingunitsdataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView sellingunitsdataGrid;
        private System.Windows.Forms.Button addpenaltyBtn;
        private System.Windows.Forms.Button viewinvoicesBtn;
        private System.Windows.Forms.ComboBox sellingresdComboBox;
        private System.Windows.Forms.Label label4;
    }
}
