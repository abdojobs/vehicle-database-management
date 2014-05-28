using System.Collections.Generic;
namespace JarmuBerlo
{
    partial class JarmuBerloForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        List<object> loanerItems = new List<object>();
        List<object> registrantItems = new List<object>();
        List<object> adminItems = new List<object>();
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

        private void InitializeComponentLists()
        {
            loanerItems.Add(this.lbLoan);
            loanerItems.Add(this.dtpLoanStart);
            loanerItems.Add(this.btnLoan);
            loanerItems.Add(this.dtpLoanEnd);
            loanerItems.Add(this.lbLoanStart);
            loanerItems.Add(this.lbLoanEnd);
            loanerItems.Add(this.btnOccupied);
            loanerItems.Add(this.btnLoanListAdd);
            loanerItems.Add(this.lbLoanList);
            loanerItems.Add(this.dgvLoanList);
            registrantItems.Add(this.btnInsert);
            registrantItems.Add(this.btnDelete);
            registrantItems.Add(this.tbConsumption);
            registrantItems.Add(this.tbPrice);
            registrantItems.Add(this.tbYear);
            registrantItems.Add(this.tbModel);
            registrantItems.Add(this.cbOwners);
            registrantItems.Add(this.cbCategories);
            registrantItems.Add(this.cbMakers);
            registrantItems.Add(this.lbOwner);
            registrantItems.Add(this.lbPrice);
            registrantItems.Add(this.lbConsumption);
            registrantItems.Add(this.lbCategory);
            registrantItems.Add(this.lbYear);
            registrantItems.Add(this.lbModel);
            registrantItems.Add(this.lbMaker);
            registrantItems.Add(this.lbUpdate);
            registrantItems.Add(this.lbXMLExport);
            registrantItems.Add(this.cbExport);
            registrantItems.Add(this.tbFileLocationExport);
            registrantItems.Add(this.btnBrowseExport);
            registrantItems.Add(this.btnExport);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.cbUsers);
            this.Controls.Add(this.lbUsername2);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.tbLicenseNumber);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.tbFullName);
            this.Controls.Add(this.lbLicenseNumber);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.cbUserGroups);
            this.Controls.Add(this.lbUserGroup);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbFullName);
            this.Controls.Add(this.lbPhoneNumber);
            this.Controls.Add(this.lbUsers);
            adminItems.Add(this.btnDeleteUser);
            adminItems.Add(this.cbUsers);
            adminItems.Add(this.lbUsername2);
            adminItems.Add(this.btnAddUser);
            adminItems.Add(this.tbLicenseNumber);
            adminItems.Add(this.tbPhoneNumber);
            adminItems.Add(this.tbFullName);
            adminItems.Add(this.lbLicenseNumber);
            adminItems.Add(this.tbPassword);
            adminItems.Add(this.tbUsername);
            adminItems.Add(this.cbUserGroups);
            adminItems.Add(this.lbUserGroup);
            adminItems.Add(this.lbUsername);
            adminItems.Add(this.lbPassword);
            adminItems.Add(this.lbFullName);
            adminItems.Add(this.lbPhoneNumber);
            adminItems.Add(this.lbUsers);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JarmuBerloForm));
            this.cbCategoryFilter = new System.Windows.Forms.ComboBox();
            this.btnCategoryFilter = new System.Windows.Forms.Button();
            this.dgvVehicles = new System.Windows.Forms.DataGridView();
            this.vehicleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbMakerFilter = new System.Windows.Forms.ComboBox();
            this.lbCategoryFilter = new System.Windows.Forms.Label();
            this.lbMakerFilter = new System.Windows.Forms.Label();
            this.lbLoan = new System.Windows.Forms.Label();
            this.dtpLoanStart = new System.Windows.Forms.DateTimePicker();
            this.btnLoan = new System.Windows.Forms.Button();
            this.dtpLoanEnd = new System.Windows.Forms.DateTimePicker();
            this.lbLoanStart = new System.Windows.Forms.Label();
            this.lbLoanEnd = new System.Windows.Forms.Label();
            this.btnOccupied = new System.Windows.Forms.Button();
            this.lbUpdate = new System.Windows.Forms.Label();
            this.lbMaker = new System.Windows.Forms.Label();
            this.lbModel = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbConsumption = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbOwner = new System.Windows.Forms.Label();
            this.cbMakers = new System.Windows.Forms.ComboBox();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.cbOwners = new System.Windows.Forms.ComboBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbConsumption = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbUsers = new System.Windows.Forms.Label();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.lbFullName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbUserGroup = new System.Windows.Forms.Label();
            this.cbUserGroups = new System.Windows.Forms.ComboBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbLicenseNumber = new System.Windows.Forms.Label();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbLicenseNumber = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lbUsername2 = new System.Windows.Forms.Label();
            this.cbUsers = new System.Windows.Forms.ComboBox();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnLoanListAdd = new System.Windows.Forms.Button();
            this.lbLoanList = new System.Windows.Forms.Label();
            this.dgvLoanList = new System.Windows.Forms.DataGridView();
            this.Vehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbXMLExport = new System.Windows.Forms.Label();
            this.btnBrowseExport = new System.Windows.Forms.Button();
            this.tbFileLocationExport = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.cbExport = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanList)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCategoryFilter
            // 
            this.cbCategoryFilter.FormattingEnabled = true;
            this.cbCategoryFilter.Location = new System.Drawing.Point(335, 24);
            this.cbCategoryFilter.Name = "cbCategoryFilter";
            this.cbCategoryFilter.Size = new System.Drawing.Size(145, 21);
            this.cbCategoryFilter.TabIndex = 1;
            // 
            // btnCategoryFilter
            // 
            this.btnCategoryFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoryFilter.Location = new System.Drawing.Point(518, 23);
            this.btnCategoryFilter.Name = "btnCategoryFilter";
            this.btnCategoryFilter.Size = new System.Drawing.Size(75, 23);
            this.btnCategoryFilter.TabIndex = 2;
            this.btnCategoryFilter.Text = "Szűrés";
            this.btnCategoryFilter.UseVisualStyleBackColor = true;
            this.btnCategoryFilter.Click += new System.EventHandler(this.btnCategoryFilter_Click);
            // 
            // dgvVehicles
            // 
            this.dgvVehicles.AllowUserToAddRows = false;
            this.dgvVehicles.AllowUserToDeleteRows = false;
            this.dgvVehicles.AllowUserToResizeColumns = false;
            this.dgvVehicles.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVehicles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVehicles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleID,
            this.maker,
            this.model,
            this.year,
            this.category,
            this.price,
            this.consumption});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVehicles.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVehicles.Location = new System.Drawing.Point(30, 52);
            this.dgvVehicles.MultiSelect = false;
            this.dgvVehicles.Name = "dgvVehicles";
            this.dgvVehicles.ReadOnly = true;
            this.dgvVehicles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehicles.Size = new System.Drawing.Size(563, 154);
            this.dgvVehicles.TabIndex = 3;
            // 
            // vehicleID
            // 
            this.vehicleID.HeaderText = "JárműID";
            this.vehicleID.Name = "vehicleID";
            this.vehicleID.ReadOnly = true;
            this.vehicleID.Visible = false;
            this.vehicleID.Width = 71;
            // 
            // maker
            // 
            this.maker.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.maker.FillWeight = 40F;
            this.maker.HeaderText = "Gyártó";
            this.maker.MinimumWidth = 117;
            this.maker.Name = "maker";
            this.maker.ReadOnly = true;
            this.maker.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.maker.Width = 117;
            // 
            // model
            // 
            this.model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.model.FillWeight = 40F;
            this.model.HeaderText = "Modell";
            this.model.MinimumWidth = 117;
            this.model.Name = "model";
            this.model.ReadOnly = true;
            this.model.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.model.Width = 117;
            // 
            // year
            // 
            this.year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.year.FillWeight = 40F;
            this.year.HeaderText = "Kiadás éve";
            this.year.MinimumWidth = 70;
            this.year.Name = "year";
            this.year.ReadOnly = true;
            this.year.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.year.Width = 70;
            // 
            // category
            // 
            this.category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.category.FillWeight = 1F;
            this.category.HeaderText = "Kategória";
            this.category.MinimumWidth = 77;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.category.Width = 77;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.price.FillWeight = 40F;
            this.price.HeaderText = "Napidíj";
            this.price.MinimumWidth = 50;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.price.Width = 50;
            // 
            // consumption
            // 
            this.consumption.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.consumption.FillWeight = 40F;
            this.consumption.HeaderText = "Fogyasztás";
            this.consumption.MinimumWidth = 70;
            this.consumption.Name = "consumption";
            this.consumption.ReadOnly = true;
            this.consumption.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.consumption.Width = 70;
            // 
            // cbMakerFilter
            // 
            this.cbMakerFilter.FormattingEnabled = true;
            this.cbMakerFilter.Location = new System.Drawing.Point(74, 24);
            this.cbMakerFilter.Name = "cbMakerFilter";
            this.cbMakerFilter.Size = new System.Drawing.Size(145, 21);
            this.cbMakerFilter.TabIndex = 0;
            // 
            // lbCategoryFilter
            // 
            this.lbCategoryFilter.AutoSize = true;
            this.lbCategoryFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoryFilter.Location = new System.Drawing.Point(266, 27);
            this.lbCategoryFilter.Name = "lbCategoryFilter";
            this.lbCategoryFilter.Size = new System.Drawing.Size(63, 15);
            this.lbCategoryFilter.TabIndex = 4444;
            this.lbCategoryFilter.Text = "Kategória:";
            // 
            // lbMakerFilter
            // 
            this.lbMakerFilter.AutoSize = true;
            this.lbMakerFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMakerFilter.Location = new System.Drawing.Point(27, 27);
            this.lbMakerFilter.Name = "lbMakerFilter";
            this.lbMakerFilter.Size = new System.Drawing.Size(45, 15);
            this.lbMakerFilter.TabIndex = 4444;
            this.lbMakerFilter.Text = "Gyártó:";
            // 
            // lbLoan
            // 
            this.lbLoan.AutoSize = true;
            this.lbLoan.Enabled = false;
            this.lbLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoan.Location = new System.Drawing.Point(38, 213);
            this.lbLoan.Name = "lbLoan";
            this.lbLoan.Size = new System.Drawing.Size(48, 15);
            this.lbLoan.TabIndex = 4445;
            this.lbLoan.Text = "Bérlés";
            // 
            // dtpLoanStart
            // 
            this.dtpLoanStart.Checked = false;
            this.dtpLoanStart.Enabled = false;
            this.dtpLoanStart.Location = new System.Drawing.Point(139, 235);
            this.dtpLoanStart.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtpLoanStart.MinDate = new System.DateTime(2013, 4, 23, 0, 0, 0, 0);
            this.dtpLoanStart.Name = "dtpLoanStart";
            this.dtpLoanStart.Size = new System.Drawing.Size(91, 20);
            this.dtpLoanStart.TabIndex = 4;
            this.dtpLoanStart.ValueChanged += new System.EventHandler(this.dtpLoanStart_ValueChanged);
            // 
            // btnLoan
            // 
            this.btnLoan.Enabled = false;
            this.btnLoan.Location = new System.Drawing.Point(217, 287);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(60, 23);
            this.btnLoan.TabIndex = 7;
            this.btnLoan.Text = "Bérlés";
            this.btnLoan.UseVisualStyleBackColor = true;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // dtpLoanEnd
            // 
            this.dtpLoanEnd.Checked = false;
            this.dtpLoanEnd.Enabled = false;
            this.dtpLoanEnd.Location = new System.Drawing.Point(139, 261);
            this.dtpLoanEnd.Name = "dtpLoanEnd";
            this.dtpLoanEnd.Size = new System.Drawing.Size(91, 20);
            this.dtpLoanEnd.TabIndex = 5;
            // 
            // lbLoanStart
            // 
            this.lbLoanStart.AutoSize = true;
            this.lbLoanStart.Enabled = false;
            this.lbLoanStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoanStart.Location = new System.Drawing.Point(42, 235);
            this.lbLoanStart.Name = "lbLoanStart";
            this.lbLoanStart.Size = new System.Drawing.Size(91, 15);
            this.lbLoanStart.TabIndex = 4447;
            this.lbLoanStart.Text = "Bérlés kezdete:";
            // 
            // lbLoanEnd
            // 
            this.lbLoanEnd.AutoSize = true;
            this.lbLoanEnd.Enabled = false;
            this.lbLoanEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoanEnd.Location = new System.Drawing.Point(42, 261);
            this.lbLoanEnd.Name = "lbLoanEnd";
            this.lbLoanEnd.Size = new System.Drawing.Size(74, 15);
            this.lbLoanEnd.TabIndex = 4448;
            this.lbLoanEnd.Text = "Bérlés vége:";
            // 
            // btnOccupied
            // 
            this.btnOccupied.Enabled = false;
            this.btnOccupied.Location = new System.Drawing.Point(146, 287);
            this.btnOccupied.Name = "btnOccupied";
            this.btnOccupied.Size = new System.Drawing.Size(65, 23);
            this.btnOccupied.TabIndex = 6;
            this.btnOccupied.Text = "Foglaltság";
            this.btnOccupied.UseVisualStyleBackColor = true;
            this.btnOccupied.Click += new System.EventHandler(this.btnOccupied_Click);
            // 
            // lbUpdate
            // 
            this.lbUpdate.AutoSize = true;
            this.lbUpdate.Enabled = false;
            this.lbUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUpdate.Location = new System.Drawing.Point(305, 333);
            this.lbUpdate.Name = "lbUpdate";
            this.lbUpdate.Size = new System.Drawing.Size(73, 15);
            this.lbUpdate.TabIndex = 4449;
            this.lbUpdate.Text = "Módosítás";
            // 
            // lbMaker
            // 
            this.lbMaker.AutoSize = true;
            this.lbMaker.Enabled = false;
            this.lbMaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaker.Location = new System.Drawing.Point(307, 359);
            this.lbMaker.Name = "lbMaker";
            this.lbMaker.Size = new System.Drawing.Size(45, 15);
            this.lbMaker.TabIndex = 4450;
            this.lbMaker.Text = "Gyártó:";
            // 
            // lbModel
            // 
            this.lbModel.AutoSize = true;
            this.lbModel.Enabled = false;
            this.lbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModel.Location = new System.Drawing.Point(307, 385);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(48, 15);
            this.lbModel.TabIndex = 4451;
            this.lbModel.Text = "Modell:";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Enabled = false;
            this.lbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYear.Location = new System.Drawing.Point(307, 411);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(70, 15);
            this.lbYear.TabIndex = 4452;
            this.lbYear.Text = "Kiadás éve:";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Enabled = false;
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.Location = new System.Drawing.Point(307, 437);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(63, 15);
            this.lbCategory.TabIndex = 4453;
            this.lbCategory.Text = "Kategória:";
            // 
            // lbConsumption
            // 
            this.lbConsumption.AutoSize = true;
            this.lbConsumption.Enabled = false;
            this.lbConsumption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsumption.Location = new System.Drawing.Point(307, 489);
            this.lbConsumption.Name = "lbConsumption";
            this.lbConsumption.Size = new System.Drawing.Size(71, 15);
            this.lbConsumption.TabIndex = 4454;
            this.lbConsumption.Text = "Fogyasztás:";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Enabled = false;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(307, 463);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(49, 15);
            this.lbPrice.TabIndex = 4455;
            this.lbPrice.Text = "Napidíj:";
            // 
            // lbOwner
            // 
            this.lbOwner.AutoSize = true;
            this.lbOwner.Enabled = false;
            this.lbOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOwner.Location = new System.Drawing.Point(307, 515);
            this.lbOwner.Name = "lbOwner";
            this.lbOwner.Size = new System.Drawing.Size(71, 15);
            this.lbOwner.TabIndex = 4456;
            this.lbOwner.Text = "Tulajdonos:";
            // 
            // cbMakers
            // 
            this.cbMakers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMakers.Enabled = false;
            this.cbMakers.FormattingEnabled = true;
            this.cbMakers.Location = new System.Drawing.Point(392, 357);
            this.cbMakers.Name = "cbMakers";
            this.cbMakers.Size = new System.Drawing.Size(120, 21);
            this.cbMakers.TabIndex = 15;
            // 
            // cbCategories
            // 
            this.cbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategories.Enabled = false;
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(392, 436);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(120, 21);
            this.cbCategories.TabIndex = 18;
            // 
            // cbOwners
            // 
            this.cbOwners.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOwners.Enabled = false;
            this.cbOwners.FormattingEnabled = true;
            this.cbOwners.Location = new System.Drawing.Point(393, 514);
            this.cbOwners.Name = "cbOwners";
            this.cbOwners.Size = new System.Drawing.Size(119, 21);
            this.cbOwners.TabIndex = 21;
            // 
            // tbModel
            // 
            this.tbModel.Enabled = false;
            this.tbModel.Location = new System.Drawing.Point(393, 385);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(119, 20);
            this.tbModel.TabIndex = 16;
            // 
            // tbYear
            // 
            this.tbYear.Enabled = false;
            this.tbYear.Location = new System.Drawing.Point(393, 410);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(119, 20);
            this.tbYear.TabIndex = 17;
            this.tbYear.TextChanged += new System.EventHandler(this.tbYear_TextChanged);
            // 
            // tbPrice
            // 
            this.tbPrice.Enabled = false;
            this.tbPrice.Location = new System.Drawing.Point(393, 463);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(119, 20);
            this.tbPrice.TabIndex = 19;
            this.tbPrice.TextChanged += new System.EventHandler(this.tbPrice_TextChanged);
            // 
            // tbConsumption
            // 
            this.tbConsumption.Enabled = false;
            this.tbConsumption.Location = new System.Drawing.Point(393, 489);
            this.tbConsumption.Name = "tbConsumption";
            this.tbConsumption.Size = new System.Drawing.Size(119, 20);
            this.tbConsumption.TabIndex = 20;
            this.tbConsumption.TabStop = false;
            this.tbConsumption.TextChanged += new System.EventHandler(this.tbConsumption_TextChanged);
            // 
            // btnInsert
            // 
            this.btnInsert.Enabled = false;
            this.btnInsert.Location = new System.Drawing.Point(330, 550);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 22;
            this.btnInsert.Text = "Hozzáadás";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(421, 550);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Törlés";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbUsers
            // 
            this.lbUsers.AutoSize = true;
            this.lbUsers.Enabled = false;
            this.lbUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsers.Location = new System.Drawing.Point(41, 333);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(92, 15);
            this.lbUsers.TabIndex = 4457;
            this.lbUsers.Text = "Felhasználók";
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Enabled = false;
            this.lbPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoneNumber.Location = new System.Drawing.Point(44, 515);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(81, 15);
            this.lbPhoneNumber.TabIndex = 4458;
            this.lbPhoneNumber.Text = "Telefonszám:";
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Enabled = false;
            this.lbFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFullName.Location = new System.Drawing.Point(44, 491);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(65, 15);
            this.lbFullName.TabIndex = 4459;
            this.lbFullName.Text = "Teljes név:";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Enabled = false;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(44, 467);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(45, 15);
            this.lbPassword.TabIndex = 4460;
            this.lbPassword.Text = "Jelszó:";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Enabled = false;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(44, 443);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(96, 15);
            this.lbUsername.TabIndex = 4461;
            this.lbUsername.Text = "Felhasználónév:";
            // 
            // lbUserGroup
            // 
            this.lbUserGroup.AutoSize = true;
            this.lbUserGroup.Enabled = false;
            this.lbUserGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserGroup.Location = new System.Drawing.Point(44, 419);
            this.lbUserGroup.Name = "lbUserGroup";
            this.lbUserGroup.Size = new System.Drawing.Size(52, 15);
            this.lbUserGroup.TabIndex = 4462;
            this.lbUserGroup.Text = "Csoport:";
            // 
            // cbUserGroups
            // 
            this.cbUserGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserGroups.Enabled = false;
            this.cbUserGroups.FormattingEnabled = true;
            this.cbUserGroups.Location = new System.Drawing.Point(160, 419);
            this.cbUserGroups.Name = "cbUserGroups";
            this.cbUserGroups.Size = new System.Drawing.Size(117, 21);
            this.cbUserGroups.TabIndex = 8;
            this.cbUserGroups.SelectedIndexChanged += new System.EventHandler(this.cbUserGroups_SelectedIndexChanged);
            // 
            // tbUsername
            // 
            this.tbUsername.Enabled = false;
            this.tbUsername.Location = new System.Drawing.Point(160, 443);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(117, 20);
            this.tbUsername.TabIndex = 9;
            // 
            // tbPassword
            // 
            this.tbPassword.Enabled = false;
            this.tbPassword.Location = new System.Drawing.Point(160, 467);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(117, 20);
            this.tbPassword.TabIndex = 10;
            // 
            // lbLicenseNumber
            // 
            this.lbLicenseNumber.AutoSize = true;
            this.lbLicenseNumber.Enabled = false;
            this.lbLicenseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicenseNumber.Location = new System.Drawing.Point(44, 539);
            this.lbLicenseNumber.Name = "lbLicenseNumber";
            this.lbLicenseNumber.Size = new System.Drawing.Size(103, 15);
            this.lbLicenseNumber.TabIndex = 4463;
            this.lbLicenseNumber.Text = "Jogosítványszám:";
            // 
            // tbFullName
            // 
            this.tbFullName.Enabled = false;
            this.tbFullName.Location = new System.Drawing.Point(160, 491);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(117, 20);
            this.tbFullName.TabIndex = 11;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Enabled = false;
            this.tbPhoneNumber.Location = new System.Drawing.Point(160, 515);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(117, 20);
            this.tbPhoneNumber.TabIndex = 12;
            this.tbPhoneNumber.TextChanged += new System.EventHandler(this.tbPhoneNumber_TextChanged);
            // 
            // tbLicenseNumber
            // 
            this.tbLicenseNumber.Enabled = false;
            this.tbLicenseNumber.Location = new System.Drawing.Point(160, 539);
            this.tbLicenseNumber.Name = "tbLicenseNumber";
            this.tbLicenseNumber.Size = new System.Drawing.Size(117, 20);
            this.tbLicenseNumber.TabIndex = 13;
            this.tbLicenseNumber.TextChanged += new System.EventHandler(this.tbLicenseNumber_TextChanged);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Enabled = false;
            this.btnAddUser.Location = new System.Drawing.Point(101, 568);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(135, 23);
            this.btnAddUser.TabIndex = 14;
            this.btnAddUser.Text = "Felhasználó hozzáadása";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // lbUsername2
            // 
            this.lbUsername2.AutoSize = true;
            this.lbUsername2.Enabled = false;
            this.lbUsername2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername2.Location = new System.Drawing.Point(44, 357);
            this.lbUsername2.Name = "lbUsername2";
            this.lbUsername2.Size = new System.Drawing.Size(96, 15);
            this.lbUsername2.TabIndex = 4464;
            this.lbUsername2.Text = "Felhasználónév:";
            // 
            // cbUsers
            // 
            this.cbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsers.Enabled = false;
            this.cbUsers.FormattingEnabled = true;
            this.cbUsers.Location = new System.Drawing.Point(160, 356);
            this.cbUsers.Name = "cbUsers";
            this.cbUsers.Size = new System.Drawing.Size(117, 21);
            this.cbUsers.TabIndex = 4465;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Enabled = false;
            this.btnDeleteUser.Location = new System.Drawing.Point(101, 383);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(135, 23);
            this.btnDeleteUser.TabIndex = 4466;
            this.btnDeleteUser.Text = "Felhasználó törlése";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnLoanListAdd
            // 
            this.btnLoanListAdd.Enabled = false;
            this.btnLoanListAdd.Location = new System.Drawing.Point(41, 287);
            this.btnLoanListAdd.Name = "btnLoanListAdd";
            this.btnLoanListAdd.Size = new System.Drawing.Size(99, 23);
            this.btnLoanListAdd.TabIndex = 4467;
            this.btnLoanListAdd.Text = "Bérlési listához ad";
            this.btnLoanListAdd.UseVisualStyleBackColor = true;
            this.btnLoanListAdd.Click += new System.EventHandler(this.btnLoanListAdd_Click);
            // 
            // lbLoanList
            // 
            this.lbLoanList.AutoSize = true;
            this.lbLoanList.Enabled = false;
            this.lbLoanList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoanList.Location = new System.Drawing.Point(305, 213);
            this.lbLoanList.Name = "lbLoanList";
            this.lbLoanList.Size = new System.Drawing.Size(83, 15);
            this.lbLoanList.TabIndex = 4469;
            this.lbLoanList.Text = "Bérlési lista";
            // 
            // dgvLoanList
            // 
            this.dgvLoanList.AllowUserToAddRows = false;
            this.dgvLoanList.AllowUserToDeleteRows = false;
            this.dgvLoanList.AllowUserToResizeColumns = false;
            this.dgvLoanList.AllowUserToResizeRows = false;
            this.dgvLoanList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoanList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLoanList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoanList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vehicle,
            this.StartDate,
            this.EndDate});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoanList.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLoanList.Enabled = false;
            this.dgvLoanList.Location = new System.Drawing.Point(293, 235);
            this.dgvLoanList.MultiSelect = false;
            this.dgvLoanList.Name = "dgvLoanList";
            this.dgvLoanList.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoanList.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLoanList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvLoanList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoanList.Size = new System.Drawing.Size(300, 90);
            this.dgvLoanList.TabIndex = 4470;
            // 
            // Vehicle
            // 
            this.Vehicle.HeaderText = "Jármű";
            this.Vehicle.Name = "Vehicle";
            this.Vehicle.ReadOnly = true;
            this.Vehicle.Width = 60;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Bérlés kezdete";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            this.StartDate.Width = 102;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "Bérlés vége";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            this.EndDate.Width = 88;
            // 
            // lbXMLExport
            // 
            this.lbXMLExport.AutoSize = true;
            this.lbXMLExport.Enabled = false;
            this.lbXMLExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXMLExport.Location = new System.Drawing.Point(41, 603);
            this.lbXMLExport.Name = "lbXMLExport";
            this.lbXMLExport.Size = new System.Drawing.Size(107, 15);
            this.lbXMLExport.TabIndex = 4471;
            this.lbXMLExport.Text = "XML exportálás";
            // 
            // btnBrowseExport
            // 
            this.btnBrowseExport.Enabled = false;
            this.btnBrowseExport.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowseExport.Image")));
            this.btnBrowseExport.Location = new System.Drawing.Point(370, 624);
            this.btnBrowseExport.Name = "btnBrowseExport";
            this.btnBrowseExport.Size = new System.Drawing.Size(29, 23);
            this.btnBrowseExport.TabIndex = 4472;
            this.btnBrowseExport.UseVisualStyleBackColor = true;
            this.btnBrowseExport.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tbFileLocationExport
            // 
            this.tbFileLocationExport.Enabled = false;
            this.tbFileLocationExport.Location = new System.Drawing.Point(158, 626);
            this.tbFileLocationExport.Name = "tbFileLocationExport";
            this.tbFileLocationExport.Size = new System.Drawing.Size(210, 20);
            this.tbFileLocationExport.TabIndex = 4473;
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.Location = new System.Drawing.Point(421, 624);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 4474;
            this.btnExport.Text = "Exportálás";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // cbExport
            // 
            this.cbExport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExport.Enabled = false;
            this.cbExport.FormattingEnabled = true;
            this.cbExport.Location = new System.Drawing.Point(45, 625);
            this.cbExport.Name = "cbExport";
            this.cbExport.Size = new System.Drawing.Size(107, 21);
            this.cbExport.TabIndex = 4475;
            // 
            // JarmuBerloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 673);
            this.Controls.Add(this.cbExport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.tbFileLocationExport);
            this.Controls.Add(this.btnBrowseExport);
            this.Controls.Add(this.lbXMLExport);
            this.Controls.Add(this.dgvLoanList);
            this.Controls.Add(this.lbLoanList);
            this.Controls.Add(this.btnLoanListAdd);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.cbUsers);
            this.Controls.Add(this.lbUsername2);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.tbLicenseNumber);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.tbFullName);
            this.Controls.Add(this.lbLicenseNumber);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.cbUserGroups);
            this.Controls.Add(this.lbUserGroup);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbFullName);
            this.Controls.Add(this.lbPhoneNumber);
            this.Controls.Add(this.lbUsers);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbConsumption);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.cbOwners);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.cbMakers);
            this.Controls.Add(this.lbOwner);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbConsumption);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.lbModel);
            this.Controls.Add(this.lbMaker);
            this.Controls.Add(this.lbUpdate);
            this.Controls.Add(this.btnOccupied);
            this.Controls.Add(this.lbLoanEnd);
            this.Controls.Add(this.lbLoanStart);
            this.Controls.Add(this.dtpLoanEnd);
            this.Controls.Add(this.btnLoan);
            this.Controls.Add(this.dtpLoanStart);
            this.Controls.Add(this.lbLoan);
            this.Controls.Add(this.lbMakerFilter);
            this.Controls.Add(this.lbCategoryFilter);
            this.Controls.Add(this.cbMakerFilter);
            this.Controls.Add(this.dgvVehicles);
            this.Controls.Add(this.btnCategoryFilter);
            this.Controls.Add(this.cbCategoryFilter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "JarmuBerloForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Jármű bérlés";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.JarmuBerloForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCategoryFilter;
        private System.Windows.Forms.Button btnCategoryFilter;
        private System.Windows.Forms.DataGridView dgvVehicles;
        private System.Windows.Forms.ComboBox cbMakerFilter;
        private System.Windows.Forms.Label lbCategoryFilter;
        private System.Windows.Forms.Label lbMakerFilter;
        private System.Windows.Forms.Label lbLoan;
        private System.Windows.Forms.DateTimePicker dtpLoanStart;
        private System.Windows.Forms.Button btnLoan;
        private System.Windows.Forms.DateTimePicker dtpLoanEnd;
        private System.Windows.Forms.Label lbLoanStart;
        private System.Windows.Forms.Label lbLoanEnd;
        private System.Windows.Forms.Button btnOccupied;
        private System.Windows.Forms.Label lbUpdate;
        private System.Windows.Forms.Label lbMaker;
        private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbConsumption;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbOwner;
        private System.Windows.Forms.ComboBox cbMakers;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.ComboBox cbOwners;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbConsumption;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lbUsers;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbUserGroup;
        private System.Windows.Forms.ComboBox cbUserGroups;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbLicenseNumber;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbLicenseNumber;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lbUsername2;
        private System.Windows.Forms.ComboBox cbUsers;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnLoanListAdd;
        private System.Windows.Forms.Label lbLoanList;
        private System.Windows.Forms.DataGridView dgvLoanList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn maker;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumption;
        private System.Windows.Forms.Label lbXMLExport;
        private System.Windows.Forms.Button btnBrowseExport;
        private System.Windows.Forms.TextBox tbFileLocationExport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ComboBox cbExport;
    }
}

