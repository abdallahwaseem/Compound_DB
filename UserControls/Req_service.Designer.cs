
namespace Compound_DB.Resident.UserControls
{
    partial class Req_service
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
            this.Select_Required_Service = new System.Windows.Forms.Label();
            this.service_required_on = new System.Windows.Forms.Label();
            this.Service_NameTxtbox = new System.Windows.Forms.ComboBox();
            this.Request_Date = new System.Windows.Forms.DateTimePicker();
            this.confrim_btn = new System.Windows.Forms.Button();
            this.RequestID = new System.Windows.Forms.TextBox();
            this.RequestNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Select_Required_Service
            // 
            this.Select_Required_Service.AutoSize = true;
            this.Select_Required_Service.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_Required_Service.Location = new System.Drawing.Point(4, 66);
            this.Select_Required_Service.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Select_Required_Service.Name = "Select_Required_Service";
            this.Select_Required_Service.Size = new System.Drawing.Size(196, 21);
            this.Select_Required_Service.TabIndex = 1;
            this.Select_Required_Service.Text = "Select Required Service";
            // 
            // service_required_on
            // 
            this.service_required_on.AutoSize = true;
            this.service_required_on.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.service_required_on.Location = new System.Drawing.Point(4, 120);
            this.service_required_on.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.service_required_on.Name = "service_required_on";
            this.service_required_on.Size = new System.Drawing.Size(173, 21);
            this.service_required_on.TabIndex = 2;
            this.service_required_on.Text = "Service Required on:";
            // 
            // Service_NameTxtbox
            // 
            this.Service_NameTxtbox.FormattingEnabled = true;
            this.Service_NameTxtbox.Items.AddRange(new object[] {
            "Maintainance",
            "Electricity",
            "Pluming"});
            this.Service_NameTxtbox.Location = new System.Drawing.Point(225, 65);
            this.Service_NameTxtbox.Name = "Service_NameTxtbox";
            this.Service_NameTxtbox.Size = new System.Drawing.Size(182, 22);
            this.Service_NameTxtbox.TabIndex = 3;
            // 
            // Request_Date
            // 
            this.Request_Date.Location = new System.Drawing.Point(207, 120);
            this.Request_Date.Name = "Request_Date";
            this.Request_Date.Size = new System.Drawing.Size(200, 22);
            this.Request_Date.TabIndex = 4;
            // 
            // confrim_btn
            // 
            this.confrim_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.confrim_btn.FlatAppearance.BorderSize = 0;
            this.confrim_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confrim_btn.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confrim_btn.ForeColor = System.Drawing.Color.Black;
            this.confrim_btn.Image = global::Compound_DB.Properties.Resources.invoice6;
            this.confrim_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.confrim_btn.Location = new System.Drawing.Point(424, 209);
            this.confrim_btn.Name = "confrim_btn";
            this.confrim_btn.Size = new System.Drawing.Size(246, 44);
            this.confrim_btn.TabIndex = 5;
            this.confrim_btn.Text = "Confirm Request";
            this.confrim_btn.UseVisualStyleBackColor = false;
            this.confrim_btn.Click += new System.EventHandler(this.confrim_btn_Click);
            // 
            // RequestID
            // 
            this.RequestID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RequestID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(223)))), ((int)(((byte)(186)))));
            this.RequestID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RequestID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestID.ForeColor = System.Drawing.Color.Gray;
            this.RequestID.Location = new System.Drawing.Point(197, 222);
            this.RequestID.Margin = new System.Windows.Forms.Padding(4);
            this.RequestID.Name = "RequestID";
            this.RequestID.Size = new System.Drawing.Size(210, 17);
            this.RequestID.TabIndex = 12;
            this.RequestID.Text = "Request ID appears here";
            // 
            // RequestNum
            // 
            this.RequestNum.AutoSize = true;
            this.RequestNum.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestNum.Location = new System.Drawing.Point(4, 220);
            this.RequestNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RequestNum.Name = "RequestNum";
            this.RequestNum.Size = new System.Drawing.Size(172, 21);
            this.RequestNum.TabIndex = 13;
            this.RequestNum.Text = "Request ID Number";
            // 
            // Req_service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(223)))), ((int)(((byte)(186)))));
            this.Controls.Add(this.RequestNum);
            this.Controls.Add(this.RequestID);
            this.Controls.Add(this.confrim_btn);
            this.Controls.Add(this.Request_Date);
            this.Controls.Add(this.Service_NameTxtbox);
            this.Controls.Add(this.service_required_on);
            this.Controls.Add(this.Select_Required_Service);
            this.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Req_service";
            this.Size = new System.Drawing.Size(702, 291);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Select_Required_Service;
        private System.Windows.Forms.Label service_required_on;
        private System.Windows.Forms.ComboBox Service_NameTxtbox;
        private System.Windows.Forms.DateTimePicker Request_Date;
        private System.Windows.Forms.Button confrim_btn;
        private System.Windows.Forms.TextBox RequestID;
        private System.Windows.Forms.Label RequestNum;
    }
}
