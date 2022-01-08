
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParkingSlotsGrid)).BeginInit();
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
            this.ParkingSlotsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(64)))));
            this.ParkingSlotsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ParkingSlotsGrid.Location = new System.Drawing.Point(227, 176);
            this.ParkingSlotsGrid.Name = "ParkingSlotsGrid";
            this.ParkingSlotsGrid.Size = new System.Drawing.Size(225, 178);
            this.ParkingSlotsGrid.TabIndex = 10;
            // 
            // Your_parkingslots
            // 
            this.Your_parkingslots.AutoSize = true;
            this.Your_parkingslots.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Your_parkingslots.ForeColor = System.Drawing.Color.Black;
            this.Your_parkingslots.Location = new System.Drawing.Point(222, 136);
            this.Your_parkingslots.Name = "Your_parkingslots";
            this.Your_parkingslots.Size = new System.Drawing.Size(230, 27);
            this.Your_parkingslots.TabIndex = 6;
            this.Your_parkingslots.Text = "Your Parking Slots";
            // 
            // ParkingSlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(223)))), ((int)(((byte)(186)))));
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ParkingSlotTitle;
        private System.Windows.Forms.DataGridView ParkingSlotsGrid;
        private System.Windows.Forms.Label Your_parkingslots;
    }
}
