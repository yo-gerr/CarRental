namespace CarRental
{
    partial class frmUpdateRentCar
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
            this.dtpDropOff = new System.Windows.Forms.DateTimePicker();
            this.lblDropOff = new System.Windows.Forms.Label();
            this.dtpPickUp = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpDropOff
            // 
            this.dtpDropOff.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDropOff.CustomFormat = "MM\'/\'dd\'/\'yyyy hh\':\'mm tt";
            this.dtpDropOff.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDropOff.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDropOff.Location = new System.Drawing.Point(326, 100);
            this.dtpDropOff.Name = "dtpDropOff";
            this.dtpDropOff.Size = new System.Drawing.Size(207, 30);
            this.dtpDropOff.TabIndex = 84;
            // 
            // lblDropOff
            // 
            this.lblDropOff.AutoSize = true;
            this.lblDropOff.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDropOff.Location = new System.Drawing.Point(325, 75);
            this.lblDropOff.Name = "lblDropOff";
            this.lblDropOff.Size = new System.Drawing.Size(204, 22);
            this.lblDropOff.TabIndex = 83;
            this.lblDropOff.Text = "Drop-Off Date and Time";
            // 
            // dtpPickUp
            // 
            this.dtpPickUp.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPickUp.CustomFormat = "MM\'/\'dd\'/\'yyyy hh\':\'mm tt";
            this.dtpPickUp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPickUp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPickUp.Location = new System.Drawing.Point(36, 100);
            this.dtpPickUp.Name = "dtpPickUp";
            this.dtpPickUp.Size = new System.Drawing.Size(205, 30);
            this.dtpPickUp.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 22);
            this.label2.TabIndex = 81;
            this.label2.Text = "Pick-Up Date and Time";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(12, 223);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 28);
            this.btnCancel.TabIndex = 86;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(469, 223);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 28);
            this.btnUpdate.TabIndex = 85;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmUpdateRentCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(570, 263);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dtpDropOff);
            this.Controls.Add(this.lblDropOff);
            this.Controls.Add(this.dtpPickUp);
            this.Controls.Add(this.label2);
            this.Name = "frmUpdateRentCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUpdateRentCar";
            this.Load += new System.EventHandler(this.frmUpdateRentCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDropOff;
        private System.Windows.Forms.Label lblDropOff;
        private System.Windows.Forms.DateTimePicker dtpPickUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
    }
}