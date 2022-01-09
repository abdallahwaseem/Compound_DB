namespace Compound_DB.Compound_Staff
{
    partial class ParkingSlotRequests_Form
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
            this.parkingSlotRequestsIdsComboBox = new System.Windows.Forms.ComboBox();
            this.parkingSlotRequestsGrid = new System.Windows.Forms.DataGridView();
            this.searchEmptyParkingSlot = new System.Windows.Forms.Button();
            this.searchParkingSlotRequestsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.assignParkingSlot = new System.Windows.Forms.Button();
            this.emptySlotsIdsComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.parkingSlotRequestsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // parkingSlotRequestsIdsComboBox
            // 
            this.parkingSlotRequestsIdsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parkingSlotRequestsIdsComboBox.FormattingEnabled = true;
            this.parkingSlotRequestsIdsComboBox.Location = new System.Drawing.Point(644, 163);
            this.parkingSlotRequestsIdsComboBox.Name = "parkingSlotRequestsIdsComboBox";
            this.parkingSlotRequestsIdsComboBox.Size = new System.Drawing.Size(121, 28);
            this.parkingSlotRequestsIdsComboBox.TabIndex = 10;
            this.parkingSlotRequestsIdsComboBox.DropDown += new System.EventHandler(this.parkingSlotRequestsIdsComboBox_DropDown);
            // 
            // parkingSlotRequestsGrid
            // 
            this.parkingSlotRequestsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parkingSlotRequestsGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.parkingSlotRequestsGrid.Location = new System.Drawing.Point(5, 65);
            this.parkingSlotRequestsGrid.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.parkingSlotRequestsGrid.Name = "parkingSlotRequestsGrid";
            this.parkingSlotRequestsGrid.ReadOnly = true;
            this.parkingSlotRequestsGrid.RowHeadersWidth = 51;
            this.parkingSlotRequestsGrid.RowTemplate.Height = 24;
            this.parkingSlotRequestsGrid.Size = new System.Drawing.Size(610, 288);
            this.parkingSlotRequestsGrid.TabIndex = 9;
            // 
            // searchEmptyParkingSlot
            // 
            this.searchEmptyParkingSlot.Location = new System.Drawing.Point(770, 163);
            this.searchEmptyParkingSlot.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.searchEmptyParkingSlot.Name = "searchEmptyParkingSlot";
            this.searchEmptyParkingSlot.Size = new System.Drawing.Size(119, 79);
            this.searchEmptyParkingSlot.TabIndex = 7;
            this.searchEmptyParkingSlot.Text = "Search Empty Slot";
            this.searchEmptyParkingSlot.UseVisualStyleBackColor = true;
            this.searchEmptyParkingSlot.Click += new System.EventHandler(this.assignParkingSlotRequest_Click);
            // 
            // searchParkingSlotRequestsBtn
            // 
            this.searchParkingSlotRequestsBtn.Location = new System.Drawing.Point(770, 65);
            this.searchParkingSlotRequestsBtn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.searchParkingSlotRequestsBtn.Name = "searchParkingSlotRequestsBtn";
            this.searchParkingSlotRequestsBtn.Size = new System.Drawing.Size(119, 79);
            this.searchParkingSlotRequestsBtn.TabIndex = 8;
            this.searchParkingSlotRequestsBtn.Text = "Search Parking Requests";
            this.searchParkingSlotRequestsBtn.UseVisualStyleBackColor = true;
            this.searchParkingSlotRequestsBtn.Click += new System.EventHandler(this.searchParkingSlotRequestsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 49);
            this.label1.TabIndex = 6;
            this.label1.Text = "Parking Slot Requests";
            // 
            // assignParkingSlot
            // 
            this.assignParkingSlot.Location = new System.Drawing.Point(770, 250);
            this.assignParkingSlot.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.assignParkingSlot.Name = "assignParkingSlot";
            this.assignParkingSlot.Size = new System.Drawing.Size(119, 79);
            this.assignParkingSlot.TabIndex = 7;
            this.assignParkingSlot.Text = "Assign Parking Slot";
            this.assignParkingSlot.UseVisualStyleBackColor = true;
            this.assignParkingSlot.Click += new System.EventHandler(this.assignParkingSlotRequest_Click);
            // 
            // emptySlotsIdsComboBox
            // 
            this.emptySlotsIdsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.emptySlotsIdsComboBox.FormattingEnabled = true;
            this.emptySlotsIdsComboBox.Location = new System.Drawing.Point(644, 250);
            this.emptySlotsIdsComboBox.Name = "emptySlotsIdsComboBox";
            this.emptySlotsIdsComboBox.Size = new System.Drawing.Size(121, 28);
            this.emptySlotsIdsComboBox.TabIndex = 10;
            this.emptySlotsIdsComboBox.DropDown += new System.EventHandler(this.parkingSlotRequestsIdsComboBox_DropDown);
            // 
            // ParkingSlotRequests_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.emptySlotsIdsComboBox);
            this.Controls.Add(this.parkingSlotRequestsIdsComboBox);
            this.Controls.Add(this.parkingSlotRequestsGrid);
            this.Controls.Add(this.assignParkingSlot);
            this.Controls.Add(this.searchEmptyParkingSlot);
            this.Controls.Add(this.searchParkingSlotRequestsBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ParkingSlotRequests_Form";
            this.Size = new System.Drawing.Size(895, 353);
            ((System.ComponentModel.ISupportInitialize)(this.parkingSlotRequestsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox parkingSlotRequestsIdsComboBox;
        private System.Windows.Forms.DataGridView parkingSlotRequestsGrid;
        private System.Windows.Forms.Button searchEmptyParkingSlot;
        private System.Windows.Forms.Button searchParkingSlotRequestsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button assignParkingSlot;
        private System.Windows.Forms.ComboBox emptySlotsIdsComboBox;
    }
}
