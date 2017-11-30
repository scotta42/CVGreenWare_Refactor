namespace CVGreenWare
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.dsInventory = new System.Data.DataSet();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.ClientInsurance = new System.Windows.Forms.TextBox();
            this.ClientAge = new System.Windows.Forms.TextBox();
            this.ClientEmail = new System.Windows.Forms.TextBox();
            this.ClientLName = new System.Windows.Forms.TextBox();
            this.ClientFName = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonInventory = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonExport = new System.Windows.Forms.Button();
            this.tblInventoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgInventory = new System.Windows.Forms.DataGridView();
            this.ButtonReadExcel = new System.Windows.Forms.Button();
            this.textFileName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OpenFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tblPrescriptionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseDatabaseDataSet = new CVGreenWare.WarehouseDatabaseDataSet();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insuranceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new CVGreenWare.WarehouseDatabaseDataSetTableAdapters.TableAdapterManager();
            this.tblInventoryTableAdapter = new CVGreenWare.WarehouseDatabaseDataSetTableAdapters.tblInventoryTableAdapter();
            this.tblInventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCustomerTableAdapter = new CVGreenWare.WarehouseDatabaseDataSetTableAdapters.tblCustomerTableAdapter();
            this.tblPrescriptionsTableAdapter = new CVGreenWare.WarehouseDatabaseDataSetTableAdapters.tblPrescriptionsTableAdapter();
            this.EditColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsInventory)).BeginInit();
            this.tabPage8.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblInventoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventory)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPrescriptionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblInventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(942, 38);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.Text = "LOGOUT";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // dsInventory
            // 
            this.dsInventory.DataSetName = "NewDataSet";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.button2);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(1108, 483);
            this.tabPage8.TabIndex = 5;
            this.tabPage8.Text = "Hard Code";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Check For New Patients";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.button3);
            this.tabPage6.Controls.Add(this.ClientInsurance);
            this.tabPage6.Controls.Add(this.ClientAge);
            this.tabPage6.Controls.Add(this.ClientEmail);
            this.tabPage6.Controls.Add(this.ClientLName);
            this.tabPage6.Controls.Add(this.ClientFName);
            this.tabPage6.Controls.Add(this.label20);
            this.tabPage6.Controls.Add(this.label19);
            this.tabPage6.Controls.Add(this.label18);
            this.tabPage6.Controls.Add(this.label17);
            this.tabPage6.Controls.Add(this.label16);
            this.tabPage6.Controls.Add(this.label6);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1108, 483);
            this.tabPage6.TabIndex = 4;
            this.tabPage6.Text = "Client Use";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(88, 165);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Submit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ClientInsurance
            // 
            this.ClientInsurance.Location = new System.Drawing.Point(88, 139);
            this.ClientInsurance.Name = "ClientInsurance";
            this.ClientInsurance.Size = new System.Drawing.Size(100, 20);
            this.ClientInsurance.TabIndex = 10;
            this.ClientInsurance.Text = "default";
            // 
            // ClientAge
            // 
            this.ClientAge.Location = new System.Drawing.Point(88, 113);
            this.ClientAge.Name = "ClientAge";
            this.ClientAge.Size = new System.Drawing.Size(100, 20);
            this.ClientAge.TabIndex = 8;
            this.ClientAge.Text = "178";
            // 
            // ClientEmail
            // 
            this.ClientEmail.Location = new System.Drawing.Point(88, 87);
            this.ClientEmail.Name = "ClientEmail";
            this.ClientEmail.Size = new System.Drawing.Size(100, 20);
            this.ClientEmail.TabIndex = 3;
            this.ClientEmail.Text = "default.com";
            // 
            // ClientLName
            // 
            this.ClientLName.Location = new System.Drawing.Point(88, 61);
            this.ClientLName.Name = "ClientLName";
            this.ClientLName.Size = new System.Drawing.Size(100, 20);
            this.ClientLName.TabIndex = 2;
            this.ClientLName.Text = "default";
            // 
            // ClientFName
            // 
            this.ClientFName.Location = new System.Drawing.Point(88, 32);
            this.ClientFName.Name = "ClientFName";
            this.ClientFName.Size = new System.Drawing.Size(100, 20);
            this.ClientFName.TabIndex = 1;
            this.ClientFName.Text = "default";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(28, 142);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 13);
            this.label20.TabIndex = 9;
            this.label20.Text = "Insurance";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(56, 116);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(26, 13);
            this.label19.TabIndex = 7;
            this.label19.Text = "Age";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(50, 90);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "Email";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(24, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "Last Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "First Name";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1108, 483);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Patient Record";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.insuranceDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblCustomerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1002, 241);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1108, 483);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Register";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "P.O.S. stuff here";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1108, 483);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Perscription";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.buttonInventory);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.buttonExport);
            this.tabPage2.Controls.Add(this.tblInventoryDataGridView);
            this.tabPage2.Controls.Add(this.dgInventory);
            this.tabPage2.Controls.Add(this.ButtonReadExcel);
            this.tabPage2.Controls.Add(this.textFileName);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.OpenFile);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1108, 483);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Warehouse";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonInventory
            // 
            this.buttonInventory.BackColor = System.Drawing.Color.Cyan;
            this.buttonInventory.Location = new System.Drawing.Point(179, 367);
            this.buttonInventory.Name = "buttonInventory";
            this.buttonInventory.Size = new System.Drawing.Size(239, 70);
            this.buttonInventory.TabIndex = 16;
            this.buttonInventory.Text = "View Current Inventory";
            this.buttonInventory.UseVisualStyleBackColor = false;
            this.buttonInventory.Click += new System.EventHandler(this.buttonInventory_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(750, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(264, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Edit any errors in within Window A before hitting Export";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(695, 440);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(389, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "for project purpose only stored in \'bin > debug > WarehouseDatabase\' temporarily";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(726, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(276, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "When all Excel data is gathered click Export to Database";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(695, 241);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Window B";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(695, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Window A";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(171, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(284, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Read Excel Sheet again until all files imported in window A.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(171, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(289, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "after clicking Read Excel Sheet open the new file and click ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(171, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(276, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Click Read Excel Sheet to read file. If more than one file, ";
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(796, 209);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(170, 23);
            this.buttonExport.TabIndex = 7;
            this.buttonExport.Text = "Export to Database";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // tblInventoryDataGridView
            // 
            this.tblInventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblInventoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tblInventoryDataGridView.Location = new System.Drawing.Point(689, 257);
            this.tblInventoryDataGridView.Name = "tblInventoryDataGridView";
            this.tblInventoryDataGridView.Size = new System.Drawing.Size(373, 171);
            this.tblInventoryDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Warehouse ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Warehouse ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Medicine Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Medicine Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Expiration";
            this.dataGridViewTextBoxColumn3.HeaderText = "Expiration";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dgInventory
            // 
            this.dgInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInventory.Location = new System.Drawing.Point(689, 55);
            this.dgInventory.Name = "dgInventory";
            this.dgInventory.Size = new System.Drawing.Size(373, 129);
            this.dgInventory.TabIndex = 6;
            // 
            // ButtonReadExcel
            // 
            this.ButtonReadExcel.Location = new System.Drawing.Point(179, 303);
            this.ButtonReadExcel.Name = "ButtonReadExcel";
            this.ButtonReadExcel.Size = new System.Drawing.Size(239, 23);
            this.ButtonReadExcel.TabIndex = 5;
            this.ButtonReadExcel.Text = "Read Excel Sheet";
            this.ButtonReadExcel.UseVisualStyleBackColor = true;
            this.ButtonReadExcel.Click += new System.EventHandler(this.ButtonReadExcel_Click);
            // 
            // textFileName
            // 
            this.textFileName.Location = new System.Drawing.Point(179, 248);
            this.textFileName.Name = "textFileName";
            this.textFileName.Size = new System.Drawing.Size(239, 20);
            this.textFileName.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(318, 199);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(179, 197);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(104, 23);
            this.OpenFile.TabIndex = 2;
            this.OpenFile.Text = "Open File";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Open Excel File below";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1108, 483);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pharmacy";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Check for New Prescriptions";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Location = new System.Drawing.Point(12, 92);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1116, 509);
            this.tabControl1.TabIndex = 0;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditColumn});
            this.dataGridView3.Location = new System.Drawing.Point(34, 21);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(848, 332);
            this.dataGridView3.TabIndex = 1;
            // 
            // tblPrescriptionsBindingSource
            // 
            this.tblPrescriptionsBindingSource.DataMember = "tblPrescriptions";
            this.tblPrescriptionsBindingSource.DataSource = this.warehouseDatabaseDataSet;
            // 
            // warehouseDatabaseDataSet
            // 
            this.warehouseDatabaseDataSet.DataSetName = "WarehouseDatabaseDataSet";
            this.warehouseDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // insuranceDataGridViewTextBoxColumn
            // 
            this.insuranceDataGridViewTextBoxColumn.DataPropertyName = "Insurance";
            this.insuranceDataGridViewTextBoxColumn.HeaderText = "Insurance";
            this.insuranceDataGridViewTextBoxColumn.Name = "insuranceDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // tblCustomerBindingSource
            // 
            this.tblCustomerBindingSource.DataMember = "tblCustomer";
            this.tblCustomerBindingSource.DataSource = this.warehouseDatabaseDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblCustomerTableAdapter = null;
            this.tableAdapterManager.tblInventoryTableAdapter = this.tblInventoryTableAdapter;
            this.tableAdapterManager.tblMedicineBatchTableAdapter = null;
            this.tableAdapterManager.tblMedicineTableAdapter = null;
            this.tableAdapterManager.tblPrescriptionsTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CVGreenWare.WarehouseDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblInventoryTableAdapter
            // 
            this.tblInventoryTableAdapter.ClearBeforeFill = true;
            // 
            // tblInventoryBindingSource
            // 
            this.tblInventoryBindingSource.DataMember = "tblInventory";
            this.tblInventoryBindingSource.DataSource = this.warehouseDatabaseDataSet;
            // 
            // tblCustomerTableAdapter
            // 
            this.tblCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // tblPrescriptionsTableAdapter
            // 
            this.tblPrescriptionsTableAdapter.ClearBeforeFill = true;
            // 
            // EditColumn
            // 
            this.EditColumn.DataPropertyName = "EditText";
            this.EditColumn.HeaderText = "";
            this.EditColumn.Name = "EditColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 613);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "CVGreen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsInventory)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblInventoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventory)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPrescriptionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblInventoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonLogout;
        private WarehouseDatabaseDataSet warehouseDatabaseDataSet;
        private WarehouseDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private WarehouseDatabaseDataSetTableAdapters.tblInventoryTableAdapter tblInventoryTableAdapter;
        private System.Windows.Forms.BindingSource tblInventoryBindingSource;
        private System.Data.DataSet dsInventory;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource;
        private WarehouseDatabaseDataSetTableAdapters.tblCustomerTableAdapter tblCustomerTableAdapter;
        private System.Windows.Forms.BindingSource tblPrescriptionsBindingSource;
        private WarehouseDatabaseDataSetTableAdapters.tblPrescriptionsTableAdapter tblPrescriptionsTableAdapter;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox ClientInsurance;
        private System.Windows.Forms.TextBox ClientAge;
        private System.Windows.Forms.TextBox ClientEmail;
        private System.Windows.Forms.TextBox ClientLName;
        private System.Windows.Forms.TextBox ClientFName;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insuranceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonInventory;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.DataGridView tblInventoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView dgInventory;
        private System.Windows.Forms.Button ButtonReadExcel;
        private System.Windows.Forms.TextBox textFileName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewButtonColumn EditColumn;
    }
}

