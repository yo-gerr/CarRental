namespace CarRental
{
    partial class frmCarRental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarRental));
            this.fpnlMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.lblMyProfile = new System.Windows.Forms.Label();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.pnlAddLesseeCar = new System.Windows.Forms.Panel();
            this.btnAddLesseeCar = new System.Windows.Forms.Button();
            this.pnlUpdateLesseeCar = new System.Windows.Forms.Panel();
            this.btnUpdateLesseeCar = new System.Windows.Forms.Button();
            this.pnlRemoveLesseeCar = new System.Windows.Forms.Panel();
            this.btnRemoveLesseeCar = new System.Windows.Forms.Button();
            this.pnlRent = new System.Windows.Forms.Panel();
            this.btnRent = new System.Windows.Forms.Button();
            this.pnlUpdateRent = new System.Windows.Forms.Panel();
            this.btnUpdateRent = new System.Windows.Forms.Button();
            this.pnlCancelRent = new System.Windows.Forms.Panel();
            this.btnCancelRent = new System.Windows.Forms.Button();
            this.pnlView = new System.Windows.Forms.Panel();
            this.rdbRentCars = new System.Windows.Forms.RadioButton();
            this.rdbLesseeCars = new System.Windows.Forms.RadioButton();
            this.lblView = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnlCategory = new System.Windows.Forms.Panel();
            this.rdbLocation = new System.Windows.Forms.RadioButton();
            this.rdbCarType = new System.Windows.Forms.RadioButton();
            this.rdbCapacity = new System.Windows.Forms.RadioButton();
            this.rdbCarName = new System.Windows.Forms.RadioButton();
            this.lblCategory = new System.Windows.Forms.Label();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.lblViewLeesseCar = new System.Windows.Forms.Label();
            this.lblViewRentedCar = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.fpnlMenu.SuspendLayout();
            this.pnlProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            this.pnlAddLesseeCar.SuspendLayout();
            this.pnlUpdateLesseeCar.SuspendLayout();
            this.pnlRemoveLesseeCar.SuspendLayout();
            this.pnlRent.SuspendLayout();
            this.pnlUpdateRent.SuspendLayout();
            this.pnlCancelRent.SuspendLayout();
            this.pnlView.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlCategory.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            this.SuspendLayout();
            // 
            // fpnlMenu
            // 
            this.fpnlMenu.AutoScroll = true;
            this.fpnlMenu.BackColor = System.Drawing.SystemColors.Info;
            this.fpnlMenu.Controls.Add(this.pnlProfile);
            this.fpnlMenu.Controls.Add(this.pnlAddLesseeCar);
            this.fpnlMenu.Controls.Add(this.pnlUpdateLesseeCar);
            this.fpnlMenu.Controls.Add(this.pnlRemoveLesseeCar);
            this.fpnlMenu.Controls.Add(this.pnlRent);
            this.fpnlMenu.Controls.Add(this.pnlUpdateRent);
            this.fpnlMenu.Controls.Add(this.pnlCancelRent);
            this.fpnlMenu.Controls.Add(this.pnlView);
            this.fpnlMenu.Controls.Add(this.pnlSearch);
            this.fpnlMenu.Controls.Add(this.pnlCategory);
            this.fpnlMenu.Controls.Add(this.pnlStatus);
            this.fpnlMenu.Location = new System.Drawing.Point(0, 0);
            this.fpnlMenu.Name = "fpnlMenu";
            this.fpnlMenu.Size = new System.Drawing.Size(246, 500);
            this.fpnlMenu.TabIndex = 1;
            // 
            // pnlProfile
            // 
            this.pnlProfile.Controls.Add(this.lblMyProfile);
            this.pnlProfile.Controls.Add(this.pbProfile);
            this.pnlProfile.Location = new System.Drawing.Point(3, 3);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(216, 116);
            this.pnlProfile.TabIndex = 3;
            // 
            // lblMyProfile
            // 
            this.lblMyProfile.AutoSize = true;
            this.lblMyProfile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyProfile.Location = new System.Drawing.Point(59, 71);
            this.lblMyProfile.Name = "lblMyProfile";
            this.lblMyProfile.Size = new System.Drawing.Size(96, 22);
            this.lblMyProfile.TabIndex = 2;
            this.lblMyProfile.Text = "My Profile";
            // 
            // pbProfile
            // 
            this.pbProfile.Image = ((System.Drawing.Image)(resources.GetObject("pbProfile.Image")));
            this.pbProfile.Location = new System.Drawing.Point(0, 0);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(213, 93);
            this.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbProfile.TabIndex = 1;
            this.pbProfile.TabStop = false;
            this.pbProfile.Click += new System.EventHandler(this.pbProfile_Click);
            // 
            // pnlAddLesseeCar
            // 
            this.pnlAddLesseeCar.Controls.Add(this.btnAddLesseeCar);
            this.pnlAddLesseeCar.Location = new System.Drawing.Point(3, 125);
            this.pnlAddLesseeCar.Name = "pnlAddLesseeCar";
            this.pnlAddLesseeCar.Size = new System.Drawing.Size(216, 35);
            this.pnlAddLesseeCar.TabIndex = 4;
            this.pnlAddLesseeCar.Visible = false;
            // 
            // btnAddLesseeCar
            // 
            this.btnAddLesseeCar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLesseeCar.Location = new System.Drawing.Point(0, 0);
            this.btnAddLesseeCar.Name = "btnAddLesseeCar";
            this.btnAddLesseeCar.Size = new System.Drawing.Size(216, 34);
            this.btnAddLesseeCar.TabIndex = 3;
            this.btnAddLesseeCar.Text = "Add to Lessee Car";
            this.btnAddLesseeCar.UseVisualStyleBackColor = true;
            this.btnAddLesseeCar.Click += new System.EventHandler(this.btnAddLesseeCar_Click);
            // 
            // pnlUpdateLesseeCar
            // 
            this.pnlUpdateLesseeCar.Controls.Add(this.btnUpdateLesseeCar);
            this.pnlUpdateLesseeCar.Location = new System.Drawing.Point(3, 166);
            this.pnlUpdateLesseeCar.Name = "pnlUpdateLesseeCar";
            this.pnlUpdateLesseeCar.Size = new System.Drawing.Size(216, 34);
            this.pnlUpdateLesseeCar.TabIndex = 10;
            this.pnlUpdateLesseeCar.Visible = false;
            // 
            // btnUpdateLesseeCar
            // 
            this.btnUpdateLesseeCar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateLesseeCar.Location = new System.Drawing.Point(0, 0);
            this.btnUpdateLesseeCar.Name = "btnUpdateLesseeCar";
            this.btnUpdateLesseeCar.Size = new System.Drawing.Size(216, 34);
            this.btnUpdateLesseeCar.TabIndex = 4;
            this.btnUpdateLesseeCar.Text = "Update Lessee Car";
            this.btnUpdateLesseeCar.UseVisualStyleBackColor = true;
            this.btnUpdateLesseeCar.Click += new System.EventHandler(this.btnUpdateLesseeCar_Click);
            // 
            // pnlRemoveLesseeCar
            // 
            this.pnlRemoveLesseeCar.Controls.Add(this.btnRemoveLesseeCar);
            this.pnlRemoveLesseeCar.Location = new System.Drawing.Point(3, 206);
            this.pnlRemoveLesseeCar.Name = "pnlRemoveLesseeCar";
            this.pnlRemoveLesseeCar.Size = new System.Drawing.Size(216, 34);
            this.pnlRemoveLesseeCar.TabIndex = 7;
            this.pnlRemoveLesseeCar.Visible = false;
            // 
            // btnRemoveLesseeCar
            // 
            this.btnRemoveLesseeCar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveLesseeCar.Location = new System.Drawing.Point(0, 0);
            this.btnRemoveLesseeCar.Name = "btnRemoveLesseeCar";
            this.btnRemoveLesseeCar.Size = new System.Drawing.Size(216, 34);
            this.btnRemoveLesseeCar.TabIndex = 4;
            this.btnRemoveLesseeCar.Text = "Remove to Lessee Car";
            this.btnRemoveLesseeCar.UseVisualStyleBackColor = true;
            this.btnRemoveLesseeCar.Click += new System.EventHandler(this.btnRemoveLesseeCar_Click);
            // 
            // pnlRent
            // 
            this.pnlRent.Controls.Add(this.btnRent);
            this.pnlRent.Location = new System.Drawing.Point(3, 246);
            this.pnlRent.Name = "pnlRent";
            this.pnlRent.Size = new System.Drawing.Size(216, 34);
            this.pnlRent.TabIndex = 8;
            this.pnlRent.Visible = false;
            // 
            // btnRent
            // 
            this.btnRent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRent.Location = new System.Drawing.Point(0, 0);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(216, 34);
            this.btnRent.TabIndex = 0;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // pnlUpdateRent
            // 
            this.pnlUpdateRent.Controls.Add(this.btnUpdateRent);
            this.pnlUpdateRent.Location = new System.Drawing.Point(3, 286);
            this.pnlUpdateRent.Name = "pnlUpdateRent";
            this.pnlUpdateRent.Size = new System.Drawing.Size(216, 34);
            this.pnlUpdateRent.TabIndex = 10;
            this.pnlUpdateRent.Visible = false;
            // 
            // btnUpdateRent
            // 
            this.btnUpdateRent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRent.Location = new System.Drawing.Point(0, 0);
            this.btnUpdateRent.Name = "btnUpdateRent";
            this.btnUpdateRent.Size = new System.Drawing.Size(216, 34);
            this.btnUpdateRent.TabIndex = 0;
            this.btnUpdateRent.Text = "Update Rent";
            this.btnUpdateRent.UseVisualStyleBackColor = true;
            this.btnUpdateRent.Click += new System.EventHandler(this.btnUpdateRent_Click);
            // 
            // pnlCancelRent
            // 
            this.pnlCancelRent.Controls.Add(this.btnCancelRent);
            this.pnlCancelRent.Location = new System.Drawing.Point(3, 326);
            this.pnlCancelRent.Name = "pnlCancelRent";
            this.pnlCancelRent.Size = new System.Drawing.Size(216, 34);
            this.pnlCancelRent.TabIndex = 11;
            this.pnlCancelRent.Visible = false;
            // 
            // btnCancelRent
            // 
            this.btnCancelRent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelRent.Location = new System.Drawing.Point(0, 0);
            this.btnCancelRent.Name = "btnCancelRent";
            this.btnCancelRent.Size = new System.Drawing.Size(216, 34);
            this.btnCancelRent.TabIndex = 0;
            this.btnCancelRent.Text = "Cancel Rent";
            this.btnCancelRent.UseVisualStyleBackColor = true;
            this.btnCancelRent.Click += new System.EventHandler(this.btnCancelRent_Click);
            // 
            // pnlView
            // 
            this.pnlView.Controls.Add(this.rdbRentCars);
            this.pnlView.Controls.Add(this.rdbLesseeCars);
            this.pnlView.Controls.Add(this.lblView);
            this.pnlView.Location = new System.Drawing.Point(3, 366);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(216, 115);
            this.pnlView.TabIndex = 10;
            this.pnlView.Visible = false;
            // 
            // rdbRentCars
            // 
            this.rdbRentCars.AutoSize = true;
            this.rdbRentCars.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRentCars.Location = new System.Drawing.Point(13, 76);
            this.rdbRentCars.Name = "rdbRentCars";
            this.rdbRentCars.Size = new System.Drawing.Size(128, 26);
            this.rdbRentCars.TabIndex = 6;
            this.rdbRentCars.TabStop = true;
            this.rdbRentCars.Text = "Rented Cars";
            this.rdbRentCars.UseVisualStyleBackColor = true;
            this.rdbRentCars.CheckedChanged += new System.EventHandler(this.rdbRentCars_CheckedChanged);
            // 
            // rdbLesseeCars
            // 
            this.rdbLesseeCars.AutoSize = true;
            this.rdbLesseeCars.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbLesseeCars.Location = new System.Drawing.Point(13, 44);
            this.rdbLesseeCars.Name = "rdbLesseeCars";
            this.rdbLesseeCars.Size = new System.Drawing.Size(127, 26);
            this.rdbLesseeCars.TabIndex = 5;
            this.rdbLesseeCars.TabStop = true;
            this.rdbLesseeCars.Text = "Lessee Cars";
            this.rdbLesseeCars.UseVisualStyleBackColor = true;
            this.rdbLesseeCars.CheckedChanged += new System.EventHandler(this.rdbLesseeCars_CheckedChanged);
            // 
            // lblView
            // 
            this.lblView.AutoSize = true;
            this.lblView.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblView.Location = new System.Drawing.Point(9, 12);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(52, 22);
            this.lblView.TabIndex = 4;
            this.lblView.Text = "View";
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Location = new System.Drawing.Point(3, 487);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(216, 85);
            this.pnlSearch.TabIndex = 6;
            this.pnlSearch.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(9, 37);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(188, 30);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(9, 12);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(64, 22);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search";
            // 
            // pnlCategory
            // 
            this.pnlCategory.Controls.Add(this.rdbLocation);
            this.pnlCategory.Controls.Add(this.rdbCarType);
            this.pnlCategory.Controls.Add(this.rdbCapacity);
            this.pnlCategory.Controls.Add(this.rdbCarName);
            this.pnlCategory.Controls.Add(this.lblCategory);
            this.pnlCategory.Location = new System.Drawing.Point(3, 578);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(216, 179);
            this.pnlCategory.TabIndex = 9;
            this.pnlCategory.Visible = false;
            // 
            // rdbLocation
            // 
            this.rdbLocation.AutoSize = true;
            this.rdbLocation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbLocation.Location = new System.Drawing.Point(13, 140);
            this.rdbLocation.Name = "rdbLocation";
            this.rdbLocation.Size = new System.Drawing.Size(100, 26);
            this.rdbLocation.TabIndex = 8;
            this.rdbLocation.TabStop = true;
            this.rdbLocation.Text = "Location";
            this.rdbLocation.UseVisualStyleBackColor = true;
            this.rdbLocation.CheckedChanged += new System.EventHandler(this.rdbLocation_CheckedChanged);
            // 
            // rdbCarType
            // 
            this.rdbCarType.AutoSize = true;
            this.rdbCarType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCarType.Location = new System.Drawing.Point(13, 108);
            this.rdbCarType.Name = "rdbCarType";
            this.rdbCarType.Size = new System.Drawing.Size(104, 26);
            this.rdbCarType.TabIndex = 7;
            this.rdbCarType.TabStop = true;
            this.rdbCarType.Text = "Car Type";
            this.rdbCarType.UseVisualStyleBackColor = true;
            this.rdbCarType.CheckedChanged += new System.EventHandler(this.rdbCarType_CheckedChanged);
            // 
            // rdbCapacity
            // 
            this.rdbCapacity.AutoSize = true;
            this.rdbCapacity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCapacity.Location = new System.Drawing.Point(13, 76);
            this.rdbCapacity.Name = "rdbCapacity";
            this.rdbCapacity.Size = new System.Drawing.Size(101, 26);
            this.rdbCapacity.TabIndex = 6;
            this.rdbCapacity.TabStop = true;
            this.rdbCapacity.Text = "Capacity";
            this.rdbCapacity.UseVisualStyleBackColor = true;
            this.rdbCapacity.CheckedChanged += new System.EventHandler(this.rdbCapacity_CheckedChanged);
            // 
            // rdbCarName
            // 
            this.rdbCarName.AutoSize = true;
            this.rdbCarName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCarName.Location = new System.Drawing.Point(13, 44);
            this.rdbCarName.Name = "rdbCarName";
            this.rdbCarName.Size = new System.Drawing.Size(111, 26);
            this.rdbCarName.TabIndex = 5;
            this.rdbCarName.TabStop = true;
            this.rdbCarName.Text = "Car Name";
            this.rdbCarName.UseVisualStyleBackColor = true;
            this.rdbCarName.CheckedChanged += new System.EventHandler(this.rdbCarName_CheckedChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(9, 12);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(140, 22);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Search Category";
            // 
            // pnlStatus
            // 
            this.pnlStatus.Controls.Add(this.cbStatus);
            this.pnlStatus.Controls.Add(this.lblStatus);
            this.pnlStatus.Location = new System.Drawing.Point(3, 763);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(213, 85);
            this.pnlStatus.TabIndex = 8;
            this.pnlStatus.Visible = false;
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "All",
            "Available",
            "Rented"});
            this.cbStatus.Location = new System.Drawing.Point(9, 37);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(188, 30);
            this.cbStatus.TabIndex = 0;
            this.cbStatus.TextChanged += new System.EventHandler(this.cbStatus_TextChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(9, 12);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(57, 22);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status";
            // 
            // dgvCars
            // 
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars.Location = new System.Drawing.Point(252, 60);
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.RowHeadersWidth = 51;
            this.dgvCars.RowTemplate.Height = 24;
            this.dgvCars.Size = new System.Drawing.Size(536, 399);
            this.dgvCars.TabIndex = 2;
            this.dgvCars.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCars_RowHeaderMouseDoubleClick);
            // 
            // lblViewLeesseCar
            // 
            this.lblViewLeesseCar.AutoSize = true;
            this.lblViewLeesseCar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewLeesseCar.Location = new System.Drawing.Point(252, 24);
            this.lblViewLeesseCar.Name = "lblViewLeesseCar";
            this.lblViewLeesseCar.Size = new System.Drawing.Size(106, 22);
            this.lblViewLeesseCar.TabIndex = 5;
            this.lblViewLeesseCar.Text = "Lessee Cars";
            this.lblViewLeesseCar.Visible = false;
            // 
            // lblViewRentedCar
            // 
            this.lblViewRentedCar.AutoSize = true;
            this.lblViewRentedCar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewRentedCar.Location = new System.Drawing.Point(252, 24);
            this.lblViewRentedCar.Name = "lblViewRentedCar";
            this.lblViewRentedCar.Size = new System.Drawing.Size(107, 22);
            this.lblViewRentedCar.TabIndex = 6;
            this.lblViewRentedCar.Text = "Rented Cars";
            this.lblViewRentedCar.Visible = false;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.Location = new System.Drawing.Point(671, 472);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(117, 28);
            this.btnSignOut.TabIndex = 14;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // frmCarRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.lblViewRentedCar);
            this.Controls.Add(this.lblViewLeesseCar);
            this.Controls.Add(this.fpnlMenu);
            this.Controls.Add(this.dgvCars);
            this.Name = "frmCarRental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Rental";
            this.Load += new System.EventHandler(this.frmCarRental_Load);
            this.fpnlMenu.ResumeLayout(false);
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            this.pnlAddLesseeCar.ResumeLayout(false);
            this.pnlUpdateLesseeCar.ResumeLayout(false);
            this.pnlRemoveLesseeCar.ResumeLayout(false);
            this.pnlRent.ResumeLayout(false);
            this.pnlUpdateRent.ResumeLayout(false);
            this.pnlCancelRent.ResumeLayout(false);
            this.pnlView.ResumeLayout(false);
            this.pnlView.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlCategory.ResumeLayout(false);
            this.pnlCategory.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbProfile;
        private System.Windows.Forms.FlowLayoutPanel fpnlMenu;
        private System.Windows.Forms.DataGridView dgvCars;
        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.Panel pnlAddLesseeCar;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnAddLesseeCar;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblMyProfile;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel pnlCategory;
        private System.Windows.Forms.RadioButton rdbCarName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.RadioButton rdbCarType;
        private System.Windows.Forms.RadioButton rdbCapacity;
        private System.Windows.Forms.RadioButton rdbLocation;
        private System.Windows.Forms.Button btnRemoveLesseeCar;
        private System.Windows.Forms.Panel pnlRemoveLesseeCar;
        private System.Windows.Forms.Panel pnlUpdateLesseeCar;
        private System.Windows.Forms.Button btnUpdateLesseeCar;
        private System.Windows.Forms.Panel pnlRent;
        private System.Windows.Forms.Panel pnlUpdateRent;
        private System.Windows.Forms.Button btnUpdateRent;
        private System.Windows.Forms.Panel pnlCancelRent;
        private System.Windows.Forms.Button btnCancelRent;
        private System.Windows.Forms.RadioButton rdbRentCars;
        private System.Windows.Forms.RadioButton rdbLesseeCars;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.Label lblViewLeesseCar;
        private System.Windows.Forms.Label lblViewRentedCar;
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.Button btnSignOut;
    }
}