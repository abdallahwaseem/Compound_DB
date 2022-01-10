
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
            this.acceptReqBtn = new System.Windows.Forms.Button();
            this.viewsellingsBtn = new System.Windows.Forms.Button();
            this.sellingresdComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sellingunitsdataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // sellingunitsdataGrid
            // 
            this.sellingunitsdataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellingunitsdataGrid.Location = new System.Drawing.Point(15, 75);
            this.sellingunitsdataGrid.Name = "sellingunitsdataGrid";
            this.sellingunitsdataGrid.RowHeadersWidth = 51;
            this.sellingunitsdataGrid.RowTemplate.Height = 24;
            this.sellingunitsdataGrid.Size = new System.Drawing.Size(648, 261);
            this.sellingunitsdataGrid.TabIndex = 2;
            // 
            // acceptReqBtn
            // 
            this.acceptReqBtn.Font = new System.Drawing.Font("Elephant", 8.25F);
            this.acceptReqBtn.Location = new System.Drawing.Point(726, 236);
            this.acceptReqBtn.Name = "acceptReqBtn";
            this.acceptReqBtn.Size = new System.Drawing.Size(130, 36);
            this.acceptReqBtn.TabIndex = 6;
            this.acceptReqBtn.Text = "Accept Request";
            this.acceptReqBtn.UseVisualStyleBackColor = true;
            this.acceptReqBtn.Click += new System.EventHandler(this.addrequestBtn_Click);
            // 
            // viewsellingsBtn
            // 
            this.viewsellingsBtn.Font = new System.Drawing.Font("Elephant", 8.25F);
            this.viewsellingsBtn.Location = new System.Drawing.Point(726, 88);
            this.viewsellingsBtn.Name = "viewsellingsBtn";
            this.viewsellingsBtn.Size = new System.Drawing.Size(130, 57);
            this.viewsellingsBtn.TabIndex = 4;
            this.viewsellingsBtn.Text = "View Selling Units";
            this.viewsellingsBtn.UseVisualStyleBackColor = true;
            this.viewsellingsBtn.Click += new System.EventHandler(this.viewsellingsBtn_Click);
            // 
            // sellingresdComboBox
            // 
            this.sellingresdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sellingresdComboBox.FormattingEnabled = true;
            this.sellingresdComboBox.Location = new System.Drawing.Point(726, 190);
            this.sellingresdComboBox.Name = "sellingresdComboBox";
            this.sellingresdComboBox.Size = new System.Drawing.Size(130, 24);
            this.sellingresdComboBox.TabIndex = 53;
            this.sellingresdComboBox.DropDown += new System.EventHandler(this.sellingresdComboBox_DropDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 8.25F);
            this.label4.Location = new System.Drawing.Point(723, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 54;
            this.label4.Text = "Resident ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 49);
            this.label1.TabIndex = 55;
            this.label1.Text = "Selling Units";
            // 
            // sellingunitsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sellingresdComboBox);
            this.Controls.Add(this.acceptReqBtn);
            this.Controls.Add(this.viewsellingsBtn);
            this.Controls.Add(this.sellingunitsdataGrid);
            this.Name = "sellingunitsUserControl";
            this.Size = new System.Drawing.Size(895, 353);
            ((System.ComponentModel.ISupportInitialize)(this.sellingunitsdataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView sellingunitsdataGrid;
        private System.Windows.Forms.Button acceptReqBtn;
        private System.Windows.Forms.Button viewsellingsBtn;
        private System.Windows.Forms.ComboBox sellingresdComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}
