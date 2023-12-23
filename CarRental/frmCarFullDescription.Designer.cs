namespace CarRental
{
    partial class frmCarFullDescription
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dtpModelYear = new System.Windows.Forms.DateTimePicker();
            this.lblModelYear = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.lblCarName = new System.Windows.Forms.Label();
            this.txtCarName = new System.Windows.Forms.TextBox();
            this.txtPlateNumber = new System.Windows.Forms.TextBox();
            this.lblPlateNumber = new System.Windows.Forms.Label();
            this.lblCarType = new System.Windows.Forms.Label();
            this.txtCarType = new System.Windows.Forms.TextBox();
            this.ptbCarPhoto = new System.Windows.Forms.PictureBox();
            this.lblCarStatus = new System.Windows.Forms.Label();
            this.txtCarStatus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCarPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(388, 405);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(215, 30);
            this.txtLocation.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 69;
            this.label1.Text = "Location";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 492);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(91, 32);
            this.btnBack.TabIndex = 68;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dtpModelYear
            // 
            this.dtpModelYear.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpModelYear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpModelYear.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpModelYear.Location = new System.Drawing.Point(388, 323);
            this.dtpModelYear.Name = "dtpModelYear";
            this.dtpModelYear.Size = new System.Drawing.Size(125, 30);
            this.dtpModelYear.TabIndex = 66;
            // 
            // lblModelYear
            // 
            this.lblModelYear.AutoSize = true;
            this.lblModelYear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelYear.Location = new System.Drawing.Point(384, 298);
            this.lblModelYear.Name = "lblModelYear";
            this.lblModelYear.Size = new System.Drawing.Size(103, 22);
            this.lblModelYear.TabIndex = 65;
            this.lblModelYear.Text = "Model Year";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(86, 298);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(114, 22);
            this.lblCapacity.TabIndex = 62;
            this.lblCapacity.Text = "Car Capacity";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacity.Location = new System.Drawing.Point(90, 323);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.ReadOnly = true;
            this.txtCapacity.Size = new System.Drawing.Size(215, 30);
            this.txtCapacity.TabIndex = 61;
            // 
            // lblCarName
            // 
            this.lblCarName.AutoSize = true;
            this.lblCarName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarName.Location = new System.Drawing.Point(86, 217);
            this.lblCarName.Name = "lblCarName";
            this.lblCarName.Size = new System.Drawing.Size(90, 22);
            this.lblCarName.TabIndex = 60;
            this.lblCarName.Text = "Car Name";
            // 
            // txtCarName
            // 
            this.txtCarName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarName.Location = new System.Drawing.Point(90, 242);
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.ReadOnly = true;
            this.txtCarName.Size = new System.Drawing.Size(215, 30);
            this.txtCarName.TabIndex = 59;
            // 
            // txtPlateNumber
            // 
            this.txtPlateNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlateNumber.Location = new System.Drawing.Point(90, 405);
            this.txtPlateNumber.Name = "txtPlateNumber";
            this.txtPlateNumber.ReadOnly = true;
            this.txtPlateNumber.Size = new System.Drawing.Size(215, 30);
            this.txtPlateNumber.TabIndex = 58;
            // 
            // lblPlateNumber
            // 
            this.lblPlateNumber.AutoSize = true;
            this.lblPlateNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlateNumber.Location = new System.Drawing.Point(86, 380);
            this.lblPlateNumber.Name = "lblPlateNumber";
            this.lblPlateNumber.Size = new System.Drawing.Size(152, 22);
            this.lblPlateNumber.TabIndex = 57;
            this.lblPlateNumber.Text = "Car Plate Number";
            // 
            // lblCarType
            // 
            this.lblCarType.AutoSize = true;
            this.lblCarType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarType.Location = new System.Drawing.Point(384, 217);
            this.lblCarType.Name = "lblCarType";
            this.lblCarType.Size = new System.Drawing.Size(83, 22);
            this.lblCarType.TabIndex = 64;
            this.lblCarType.Text = "Car Type";
            // 
            // txtCarType
            // 
            this.txtCarType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarType.Location = new System.Drawing.Point(388, 242);
            this.txtCarType.Name = "txtCarType";
            this.txtCarType.ReadOnly = true;
            this.txtCarType.Size = new System.Drawing.Size(215, 30);
            this.txtCarType.TabIndex = 63;
            // 
            // ptbCarPhoto
            // 
            this.ptbCarPhoto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ptbCarPhoto.Location = new System.Drawing.Point(173, 35);
            this.ptbCarPhoto.Name = "ptbCarPhoto";
            this.ptbCarPhoto.Size = new System.Drawing.Size(302, 152);
            this.ptbCarPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbCarPhoto.TabIndex = 71;
            this.ptbCarPhoto.TabStop = false;
            // 
            // lblCarStatus
            // 
            this.lblCarStatus.AutoSize = true;
            this.lblCarStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarStatus.Location = new System.Drawing.Point(384, 453);
            this.lblCarStatus.Name = "lblCarStatus";
            this.lblCarStatus.Size = new System.Drawing.Size(91, 22);
            this.lblCarStatus.TabIndex = 72;
            this.lblCarStatus.Text = "Car Status";
            // 
            // txtCarStatus
            // 
            this.txtCarStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarStatus.Location = new System.Drawing.Point(388, 478);
            this.txtCarStatus.Name = "txtCarStatus";
            this.txtCarStatus.ReadOnly = true;
            this.txtCarStatus.Size = new System.Drawing.Size(167, 30);
            this.txtCarStatus.TabIndex = 73;
            // 
            // frmCarFullDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(653, 536);
            this.Controls.Add(this.txtCarStatus);
            this.Controls.Add(this.lblCarStatus);
            this.Controls.Add(this.ptbCarPhoto);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dtpModelYear);
            this.Controls.Add(this.lblModelYear);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.lblCarName);
            this.Controls.Add(this.txtCarName);
            this.Controls.Add(this.txtPlateNumber);
            this.Controls.Add(this.lblPlateNumber);
            this.Controls.Add(this.lblCarType);
            this.Controls.Add(this.txtCarType);
            this.Name = "frmCarFullDescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car\'s Full Description";
            this.Load += new System.EventHandler(this.frmCarFullDescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCarPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ptbCarPhoto;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker dtpModelYear;
        private System.Windows.Forms.Label lblModelYear;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label lblCarName;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.TextBox txtPlateNumber;
        private System.Windows.Forms.Label lblPlateNumber;
        private System.Windows.Forms.Label lblCarType;
        private System.Windows.Forms.TextBox txtCarType;
        private System.Windows.Forms.Label lblCarStatus;
        private System.Windows.Forms.TextBox txtCarStatus;
    }
}