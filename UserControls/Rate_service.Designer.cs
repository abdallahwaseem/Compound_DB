
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
            this.Req_Id_txtBox = new System.Windows.Forms.TextBox();
            this.feedback_comboBox = new System.Windows.Forms.ComboBox();
            this.Worker_rate_comboBox = new System.Windows.Forms.ComboBox();
            this.Enter_request_no = new System.Windows.Forms.Label();
            this.confrim_btn = new System.Windows.Forms.Button();
            this.Worker_Rating = new System.Windows.Forms.Label();
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
            // Req_Id_txtBox
            // 
            this.Req_Id_txtBox.Location = new System.Drawing.Point(216, 53);
            this.Req_Id_txtBox.Name = "Req_Id_txtBox";
            this.Req_Id_txtBox.Size = new System.Drawing.Size(240, 22);
            this.Req_Id_txtBox.TabIndex = 3;
            // 
            // feedback_comboBox
            // 
            this.feedback_comboBox.FormattingEnabled = true;
            this.feedback_comboBox.Location = new System.Drawing.Point(216, 111);
            this.feedback_comboBox.Name = "feedback_comboBox";
            this.feedback_comboBox.Size = new System.Drawing.Size(240, 22);
            this.feedback_comboBox.TabIndex = 4;
            // 
            // Worker_rate_comboBox
            // 
            this.Worker_rate_comboBox.FormattingEnabled = true;
            this.Worker_rate_comboBox.Location = new System.Drawing.Point(216, 171);
            this.Worker_rate_comboBox.Name = "Worker_rate_comboBox";
            this.Worker_rate_comboBox.Size = new System.Drawing.Size(240, 22);
            this.Worker_rate_comboBox.TabIndex = 5;
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
            // Rate_service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(223)))), ((int)(((byte)(186)))));
            this.Controls.Add(this.Worker_Rating);
            this.Controls.Add(this.confrim_btn);
            this.Controls.Add(this.Worker_rate_comboBox);
            this.Controls.Add(this.feedback_comboBox);
            this.Controls.Add(this.Req_Id_txtBox);
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
        private System.Windows.Forms.TextBox Req_Id_txtBox;
        private System.Windows.Forms.ComboBox feedback_comboBox;
        private System.Windows.Forms.ComboBox Worker_rate_comboBox;
        private System.Windows.Forms.Label Enter_request_no;
        private System.Windows.Forms.Button confrim_btn;
        private System.Windows.Forms.Label Worker_Rating;
    }
}
