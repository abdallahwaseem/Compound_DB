
namespace Compound_DB.Resident.UserControls
{
    partial class Rate_service
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
            this.Feedback = new System.Windows.Forms.Label();
            this.feedback_comboBox = new System.Windows.Forms.ComboBox();
            this.Enter_request_no = new System.Windows.Forms.Label();
            this.confrim_btn = new System.Windows.Forms.Button();
            this.Worker_Rating = new System.Windows.Forms.Label();
            this.Star1 = new System.Windows.Forms.RadioButton();
            this.Star5 = new System.Windows.Forms.RadioButton();
            this.Star2 = new System.Windows.Forms.RadioButton();
            this.Star3 = new System.Windows.Forms.RadioButton();
            this.Star4 = new System.Windows.Forms.RadioButton();
            this.req_listsComcobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Feedback
            // 
            this.Feedback.AutoSize = true;
            this.Feedback.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Feedback.Location = new System.Drawing.Point(15, 112);
            this.Feedback.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Feedback.Name = "Feedback";
            this.Feedback.Size = new System.Drawing.Size(149, 21);
            this.Feedback.TabIndex = 2;
            this.Feedback.Text = "Overall Feedback";
            // 
            // feedback_comboBox
            // 
            this.feedback_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.feedback_comboBox.FormattingEnabled = true;
            this.feedback_comboBox.Items.AddRange(new object[] {
            "Excellent",
            "Very Good",
            "Good",
            "Satisfactory",
            "Bad"});
            this.feedback_comboBox.Location = new System.Drawing.Point(216, 111);
            this.feedback_comboBox.Name = "feedback_comboBox";
            this.feedback_comboBox.Size = new System.Drawing.Size(240, 22);
            this.feedback_comboBox.TabIndex = 4;
            // 
            // Enter_request_no
            // 
            this.Enter_request_no.AutoSize = true;
            this.Enter_request_no.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter_request_no.Location = new System.Drawing.Point(15, 54);
            this.Enter_request_no.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Enter_request_no.Name = "Enter_request_no";
            this.Enter_request_no.Size = new System.Drawing.Size(194, 21);
            this.Enter_request_no.TabIndex = 1;
            this.Enter_request_no.Text = "Enter Request Number";
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
            this.confrim_btn.Location = new System.Drawing.Point(421, 214);
            this.confrim_btn.Name = "confrim_btn";
            this.confrim_btn.Size = new System.Drawing.Size(246, 44);
            this.confrim_btn.TabIndex = 6;
            this.confrim_btn.Text = "Confirm Rating";
            this.confrim_btn.UseVisualStyleBackColor = false;
            this.confrim_btn.Click += new System.EventHandler(this.confrim_btn_Click);
            // 
            // Worker_Rating
            // 
            this.Worker_Rating.AutoSize = true;
            this.Worker_Rating.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Worker_Rating.Location = new System.Drawing.Point(15, 172);
            this.Worker_Rating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Worker_Rating.Name = "Worker_Rating";
            this.Worker_Rating.Size = new System.Drawing.Size(142, 21);
            this.Worker_Rating.TabIndex = 7;
            this.Worker_Rating.Text = "Rate the Worker";
            // 
            // Star1
            // 
            this.Star1.AutoSize = true;
            this.Star1.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Star1.Location = new System.Drawing.Point(174, 172);
            this.Star1.Name = "Star1";
            this.Star1.Size = new System.Drawing.Size(73, 24);
            this.Star1.TabIndex = 9;
            this.Star1.TabStop = true;
            this.Star1.Text = "1 Star";
            this.Star1.UseVisualStyleBackColor = true;
            // 
            // Star5
            // 
            this.Star5.AutoSize = true;
            this.Star5.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Star5.Location = new System.Drawing.Point(520, 172);
            this.Star5.Name = "Star5";
            this.Star5.Size = new System.Drawing.Size(82, 24);
            this.Star5.TabIndex = 10;
            this.Star5.TabStop = true;
            this.Star5.Text = "5 Stars";
            this.Star5.UseVisualStyleBackColor = true;
            // 
            // Star2
            // 
            this.Star2.AutoSize = true;
            this.Star2.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Star2.Location = new System.Drawing.Point(253, 172);
            this.Star2.Name = "Star2";
            this.Star2.Size = new System.Drawing.Size(83, 24);
            this.Star2.TabIndex = 11;
            this.Star2.TabStop = true;
            this.Star2.Text = "2 Stars";
            this.Star2.UseVisualStyleBackColor = true;
            // 
            // Star3
            // 
            this.Star3.AutoSize = true;
            this.Star3.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Star3.Location = new System.Drawing.Point(344, 172);
            this.Star3.Name = "Star3";
            this.Star3.Size = new System.Drawing.Size(83, 24);
            this.Star3.TabIndex = 12;
            this.Star3.TabStop = true;
            this.Star3.Text = "3 Stars";
            this.Star3.UseVisualStyleBackColor = true;
            // 
            // Star4
            // 
            this.Star4.AutoSize = true;
            this.Star4.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Star4.Location = new System.Drawing.Point(432, 172);
            this.Star4.Name = "Star4";
            this.Star4.Size = new System.Drawing.Size(82, 24);
            this.Star4.TabIndex = 13;
            this.Star4.TabStop = true;
            this.Star4.Text = "4 Stars";
            this.Star4.UseVisualStyleBackColor = true;
            // 
            // req_listsComcobox
            // 
            this.req_listsComcobox.BackColor = System.Drawing.Color.White;
            this.req_listsComcobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.req_listsComcobox.FormattingEnabled = true;
            this.req_listsComcobox.Location = new System.Drawing.Point(216, 56);
            this.req_listsComcobox.Name = "req_listsComcobox";
            this.req_listsComcobox.Size = new System.Drawing.Size(240, 22);
            this.req_listsComcobox.TabIndex = 14;
            // 
            // Rate_service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(223)))), ((int)(((byte)(186)))));
            this.Controls.Add(this.req_listsComcobox);
            this.Controls.Add(this.Star4);
            this.Controls.Add(this.Star3);
            this.Controls.Add(this.Star2);
            this.Controls.Add(this.Star5);
            this.Controls.Add(this.Star1);
            this.Controls.Add(this.Worker_Rating);
            this.Controls.Add(this.confrim_btn);
            this.Controls.Add(this.feedback_comboBox);
            this.Controls.Add(this.Feedback);
            this.Controls.Add(this.Enter_request_no);
            this.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Rate_service";
            this.Size = new System.Drawing.Size(702, 291);
            this.Load += new System.EventHandler(this.Rate_service_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Feedback;
        private System.Windows.Forms.ComboBox feedback_comboBox;
        private System.Windows.Forms.Label Enter_request_no;
        private System.Windows.Forms.Button confrim_btn;
        private System.Windows.Forms.Label Worker_Rating;
        private System.Windows.Forms.RadioButton Star1;
        private System.Windows.Forms.RadioButton Star5;
        private System.Windows.Forms.RadioButton Star2;
        private System.Windows.Forms.RadioButton Star3;
        private System.Windows.Forms.RadioButton Star4;
        private System.Windows.Forms.ComboBox req_listsComcobox;
    }
}
