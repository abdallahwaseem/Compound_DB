
namespace Compound_DB.Manager
{
    partial class services
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
            this.sernameTextbox = new System.Windows.Forms.TextBox();
            this.priTextbox = new System.Windows.Forms.TextBox();
            this.deptIDcomboBox = new System.Windows.Forms.ComboBox();
            this.serviceTextbox = new System.Windows.Forms.Label();
            this.priceTextbox = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addservicesBtn = new System.Windows.Forms.Button();
            this.updatePrice = new System.Windows.Forms.GroupBox();
            this.updatepriceBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.updatepriceTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sernamecomboBox = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.updatePrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // sernameTextbox
            // 
            this.sernameTextbox.Location = new System.Drawing.Point(40, 49);
            this.sernameTextbox.Name = "sernameTextbox";
            this.sernameTextbox.Size = new System.Drawing.Size(121, 22);
            this.sernameTextbox.TabIndex = 0;
            // 
            // priTextbox
            // 
            this.priTextbox.Location = new System.Drawing.Point(40, 94);
            this.priTextbox.Name = "priTextbox";
            this.priTextbox.Size = new System.Drawing.Size(121, 22);
            this.priTextbox.TabIndex = 1;
            // 
            // deptIDcomboBox
            // 
            this.deptIDcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deptIDcomboBox.FormattingEnabled = true;
            this.deptIDcomboBox.Location = new System.Drawing.Point(40, 159);
            this.deptIDcomboBox.Name = "deptIDcomboBox";
            this.deptIDcomboBox.Size = new System.Drawing.Size(121, 24);
            this.deptIDcomboBox.TabIndex = 2;
            this.deptIDcomboBox.DropDown += new System.EventHandler(this.deptIDcomboBox_DropDown);
            // 
            // serviceTextbox
            // 
            this.serviceTextbox.AutoSize = true;
            this.serviceTextbox.Location = new System.Drawing.Point(37, 29);
            this.serviceTextbox.Name = "serviceTextbox";
            this.serviceTextbox.Size = new System.Drawing.Size(96, 17);
            this.serviceTextbox.TabIndex = 3;
            this.serviceTextbox.Text = "Service Name";
            // 
            // priceTextbox
            // 
            this.priceTextbox.AutoSize = true;
            this.priceTextbox.Location = new System.Drawing.Point(37, 74);
            this.priceTextbox.Name = "priceTextbox";
            this.priceTextbox.Size = new System.Drawing.Size(40, 17);
            this.priceTextbox.TabIndex = 4;
            this.priceTextbox.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Department ID";
            // 
            // addservicesBtn
            // 
            this.addservicesBtn.Location = new System.Drawing.Point(40, 220);
            this.addservicesBtn.Name = "addservicesBtn";
            this.addservicesBtn.Size = new System.Drawing.Size(121, 40);
            this.addservicesBtn.TabIndex = 6;
            this.addservicesBtn.Text = "Add Service";
            this.addservicesBtn.UseVisualStyleBackColor = true;
            this.addservicesBtn.Click += new System.EventHandler(this.addservicesBtn_Click);
            // 
            // updatePrice
            // 
            this.updatePrice.Controls.Add(this.updatepriceBtn);
            this.updatePrice.Controls.Add(this.label2);
            this.updatePrice.Controls.Add(this.updatepriceTextbox);
            this.updatePrice.Controls.Add(this.label1);
            this.updatePrice.Controls.Add(this.sernamecomboBox);
            this.updatePrice.Location = new System.Drawing.Point(227, 49);
            this.updatePrice.Name = "updatePrice";
            this.updatePrice.Size = new System.Drawing.Size(436, 211);
            this.updatePrice.TabIndex = 7;
            this.updatePrice.TabStop = false;
            this.updatePrice.Text = "Update Service\'s Price";
            // 
            // updatepriceBtn
            // 
            this.updatepriceBtn.Location = new System.Drawing.Point(23, 154);
            this.updatepriceBtn.Name = "updatepriceBtn";
            this.updatepriceBtn.Size = new System.Drawing.Size(121, 40);
            this.updatepriceBtn.TabIndex = 7;
            this.updatepriceBtn.Text = "Update";
            this.updatepriceBtn.UseVisualStyleBackColor = true;
            this.updatepriceBtn.Click += new System.EventHandler(this.updatepriceBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Price";
            // 
            // updatepriceTextbox
            // 
            this.updatepriceTextbox.Location = new System.Drawing.Point(23, 110);
            this.updatepriceTextbox.Name = "updatepriceTextbox";
            this.updatepriceTextbox.Size = new System.Drawing.Size(121, 22);
            this.updatepriceTextbox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Service Name";
            // 
            // sernamecomboBox
            // 
            this.sernamecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sernamecomboBox.FormattingEnabled = true;
            this.sernamecomboBox.Location = new System.Drawing.Point(23, 56);
            this.sernamecomboBox.Name = "sernamecomboBox";
            this.sernamecomboBox.Size = new System.Drawing.Size(121, 24);
            this.sernamecomboBox.TabIndex = 3;
            this.sernamecomboBox.DropDown += new System.EventHandler(this.sernamecomboBox_DropDown);
            // 
            // services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.updatePrice);
            this.Controls.Add(this.addservicesBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.priceTextbox);
            this.Controls.Add(this.serviceTextbox);
            this.Controls.Add(this.deptIDcomboBox);
            this.Controls.Add(this.priTextbox);
            this.Controls.Add(this.sernameTextbox);
            this.Name = "services";
            this.Size = new System.Drawing.Size(732, 423);
            this.updatePrice.ResumeLayout(false);
            this.updatePrice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sernameTextbox;
        private System.Windows.Forms.TextBox priTextbox;
        private System.Windows.Forms.ComboBox deptIDcomboBox;
        private System.Windows.Forms.Label serviceTextbox;
        private System.Windows.Forms.Label priceTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addservicesBtn;
        private System.Windows.Forms.GroupBox updatePrice;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button updatepriceBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox updatepriceTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sernamecomboBox;
    }
}
