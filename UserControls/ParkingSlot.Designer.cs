
namespace Compound_DB.Resident.UserControls
{
    partial class ParkingSlot
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ParkingSlotTitle = new System.Windows.Forms.Label();
            this.ParkingSlotsGrid = new System.Windows.Forms.DataGridView();
            this.Your_parkingslots = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.RequestP_Date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.confrim_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParkingSlotsGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.ParkingSlotTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 79);
            this.panel1.TabIndex = 9;
            // 
            // ParkingSlotTitle
            // 
            this.ParkingSlotTitle.AutoSize = true;
            this.ParkingSlotTitle.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParkingSlotTitle.ForeColor = System.Drawing.Color.White;
            this.ParkingSlotTitle.Location = new System.Drawing.Point(264, 28);
            this.ParkingSlotTitle.Name = "ParkingSlotTitle";
            this.ParkingSlotTitle.Size = new System.Drawing.Size(167, 27);
            this.ParkingSlotTitle.TabIndex = 5;
            this.ParkingSlotTitle.Text = "Parking Slots";
            // 
            // ParkingSlotsGrid
            // 
            this.ParkingSlotsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(223)))), ((int)(((byte)(186)))));
            this.ParkingSlotsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ParkingSlotsGrid.Location = new System.Drawing.Point(49, 182);
            this.ParkingSlotsGrid.Name = "ParkingSlotsGrid";
            this.ParkingSlotsGrid.Size = new System.Drawing.Size(260, 178);
            this.ParkingSlotsGrid.TabIndex = 10;
            // 
            // Your_parkingslots
            // 
            this.Your_parkingslots.AutoSize = true;
            this.Your_parkingslots.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Your_parkingslots.ForeColor = System.Drawing.Color.Black;
            this.Your_parkingslots.Location = new System.Drawing.Point(67, 132);
            this.Your_parkingslots.Name = "Your_parkingslots";
            this.Your_parkingslots.Size = new System.Drawing.Size(230, 27);
            this.Your_parkingslots.TabIndex = 6;
            this.Your_parkingslots.Text = "Your Parking Slots";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.confrim_btn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.RequestP_Date);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(348, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 352);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Request additonal Parking Slot";
            // 
            // RequestP_Date
            // 
            this.RequestP_Date.Location = new System.Drawing.Point(130, 121);
            this.RequestP_Date.Name = "RequestP_Date";
            this.RequestP_Date.Size = new System.Drawing.Size(200, 22);
            this.RequestP_Date.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Required On";
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
            this.confrim_btn.Location = new System.Drawing.Point(59, 219);
            this.confrim_btn.Name = "confrim_btn";
            this.confrim_btn.Size = new System.Drawing.Size(246, 44);
            this.confrim_btn.TabIndex = 9;
            this.confrim_btn.Text = "Confirm Request";
            this.confrim_btn.UseVisualStyleBackColor = false;
            this.confrim_btn.Click += new System.EventHandler(this.confrim_btn_Click);
            // 
            // ParkingSlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(223)))), ((int)(((byte)(186)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Your_parkingslots);
            this.Controls.Add(this.ParkingSlotsGrid);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ParkingSlot";
            this.Size = new System.Drawing.Size(702, 429);
            this.Load += new System.EventHandler(this.ParkingSlot_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParkingSlotsGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ParkingSlotTitle;
        private System.Windows.Forms.DataGridView ParkingSlotsGrid;
        private System.Windows.Forms.Label Your_parkingslots;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker RequestP_Date;
        private System.Windows.Forms.Button confrim_btn;
    }
}
