using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//added
// we can treat the file as a database 
using System.Data.OleDb;
using System.Data.SqlClient;

namespace CVGreenWare
{
    public partial class Form1 : Form
    {
        #region FormLoad/Close
        public Form1()
        {
            InitializeComponent();
            PrescriptionJoinTableHandler();
        }

        public Form1(int I)
        {
            InitializeComponent();
            HideTabs(I);
            PrescriptionJoinTableHandler();
        }

        private void tblInventoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblInventoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.warehouseDatabaseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'warehouseDatabaseDataSet.tblPrescriptions' table. You can move, or remove it, as needed.
            this.tblPrescriptionsTableAdapter.Fill(this.warehouseDatabaseDataSet.tblPrescriptions);
            // TODO: This line of code loads data into the 'warehouseDatabaseDataSet.tblCustomer' table. You can move, or remove it, as needed.
            this.tblCustomerTableAdapter.Fill(this.warehouseDatabaseDataSet.tblCustomer);
            // TODO: This line of code loads data into the 'warehouseDatabaseDataSet.tblInventory' table. You can move, or remove it, as needed.
            this.tblInventoryTableAdapter.Fill(this.warehouseDatabaseDataSet.tblInventory);

        }

        private void HideTabs(int I)
        {
            // TODO: This is reversed logic, it needs to show tabs instead of hide them so that the default login can be a customer login which reveals no tabs other than the customer form
            switch (I)
            {
                case 1:
                    // Hides Tabs that Administrators don't need
                    AdministratorTabs();
                    break;
                case 2:
                    // Hides Tabs that Pharmacists don't need
                    PharmacistTabs();
                    break;
                case 3:
                    // Hides Tabs that Financial Managers don't need
                    FinanceTabs();
                    break;
                case 4:
                    // Hides Tabs that Customers don't need
                    CustomerTabs();
                    break;
                default:
                    // Hides No Tabs
                    break;
            }
        }

        private void AdministratorTabs()
        {
            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Remove(tabPage5);
            tabControl1.TabPages.Remove(tabPage6);
        }

        private void PharmacistTabs()
        {
            tabControl1.TabPages.Remove(tabPage4);
            tabControl1.TabPages.Remove(tabPage6);
        }

        private void FinanceTabs()
        {
            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Remove(tabPage4);
            tabControl1.TabPages.Remove(tabPage5);
            tabControl1.TabPages.Remove(tabPage6);
            tabControl1.TabPages.Remove(tabPage8);
        }

        private void CustomerTabs()
        {
            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Remove(tabPage4);
            tabControl1.TabPages.Remove(tabPage5);
            tabControl1.TabPages.Remove(tabPage8);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            // TODO: we shouldn't create a new form because the old form already exists, we should create a deconstructor that fires an event, add a listener onto
            //       the starting login_form that shows it again after this one finishes closing
            Login_Form login = new Login_Form();
            login.Show();
            this.Hide();
        }

        #endregion

        #region Pharmacy
        /// <summary>
        /// This region is for Pharmacist and Administrator users to access local pharmacy functionallity
        /// such as viewing Inventory and ordering medicines fro the local inventory
        /// </summary>

        #endregion

        #region Warehouse
        /// <summary>
        /// This region is for Pharmacist and Administrator users to access warehouse functionallity
        /// such as viewing Inventory and ordering medicines from the warehouse
        /// </summary>

        // allow to open a file from directory chosen
        OpenFileDialog ofd = new OpenFileDialog();

        private void OpenFile_Click(object sender, EventArgs e)
        {
            // will only allow for the xlsx filetype
            ofd.Filter = "XLSX|*.xlsx";
            // will only continue with code if you select the file and click open
            // if you cancel it wont continue 
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // will show directory with file name.
                textFileName.Text = ofd.FileName;
                // will show the safe file name in second box 
                textBox1.Text = ofd.SafeFileName;
            }
        }

        private void ButtonReadExcel_Click(object sender, EventArgs e)
        {
            // connectionless data 
            //create container
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = " + textFileName.Text + ";Extended Properties=Excel 12.0");
            // bridge between file and application
            // will bring whatever data demanded and store in application
            // sheet1$ will pull from first sheet
            OleDbDataAdapter da = new OleDbDataAdapter("select * from [Sheet1$]", con);
            // when run all data from file will be loadedt to application
            da.Fill(dsInventory);

            // might need https://www.microsoft.com/en-in/download/details.aspx?id=13255 if ACE error
            // display data using messagebox
            // 0 first table of data
            //           MessageBox.Show(dsContacts.Tables[0].Rows.Count.ToString());
            dgInventory.DataSource = dsInventory.Tables[0];

        }


        private void buttonExport_Click(object sender, EventArgs e)
        {
            // read one row at a time and store in r
            foreach (DataRow r in dsInventory.Tables[0].Rows)
            {
                DataRow dr = warehouseDatabaseDataSet.tblInventory.NewRow();
                // all collums copied to dr
                dr[0] = r[0];
                dr[1] = r[1];
                dr[2] = r[2];

                warehouseDatabaseDataSet.tblInventory.Rows.Add(dr);
            }

            //update database to source 
            tblInventoryTableAdapter.Update(warehouseDatabaseDataSet);
        }

        private void buttonInventory_Click(object sender, EventArgs e)
        {
            Inventory_Form invetory = new Inventory_Form();
            invetory.Show();
            // test
        }

        // can update in read window up top and store in database 

        #endregion

        #region Prescription
        /// <summary>
        /// This region is for Pharmacist users for accessing prescription functionallity
        /// </summary>

        private void button1_Click(object sender, EventArgs e)
        {
            CheckForNewExcelPrescription();
        }

        private void PrescriptionJoinTableHandler()
        {
            DGPrescription.DataSource = tblPrescriptionsTableAdapter.GetPrescriptionFull();
        }

        private void CheckForNewExcelPrescription()
        {
            // TODO: Refactor into a single function: Shared in HARDCODE region
            string fileName = @"|DataDirectory|\Excel Docs\Prescription.xlsx";
            OleDbConnection con = new OleDbConnection(string.Format(@"Provider= Microsoft.ACE.OLEDB.12.0;Data Source={0}; Extended Properties = 'Excel 12.0 Xml;HDR=NO';", fileName));
            OleDbCommand cmd = new OleDbCommand("Select * from [Sheet1$]", con);
            OleDbDataReader myReader;
            con.Open();
            myReader = cmd.ExecuteReader();

            // Create Data Table to store data from Excel file
            // TODO: This should happen after new us HAS been found
            // TODO: This data should be created based off a report, and linking to the Customer Table in the DB
            DataTable prescriptions = new DataTable();
            prescriptions.Columns.Add("CustomerID"); prescriptions.Columns.Add("MedicineBatchID");

            while (myReader.Read())
            {
                // EXCEL FILE LAYOUT
                // 0            1
                // CustomerID   MedicineBatchID

                // Add customer from Excel file to Data Table

                Model.Perscription prescip = new Model.Perscription(Int32.Parse(myReader.GetString(0)), Int32.Parse(myReader.GetString(1)));
                prescriptions.Rows.Add(prescip.CustomerID, prescip.MedicineID);
            }
            con.Close();

            if (prescriptions.Rows.Count > 0)
            {
                try
                {
                    InsertIntoDatabasePrescription(prescriptions);
                }
                catch (Exception)
                {
                    MessageBox.Show("There was an error saving to the database.");
                    throw;
                }
                // TODO: if there is an error, success message still displays
                MessageBox.Show(prescriptions.Rows.Count.ToString() + "customers were added to the database.");
            }
        }

        private void InsertIntoDatabasePrescription(DataTable prescriptions)
        {
            // TODO: Refactor into a single function: Shared in HARDCODE region
            string fileName = @"|DataDirectory|\WarehouseDatabase.accdb";
            OleDbConnection con = new OleDbConnection(string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = {0}; Persist Security Info = True;", fileName));
            OleDbCommand cmd = new OleDbCommand("INSERT INTO tblPrescriptions(CustomerID, MedicineBatchID) VALUES(@CID, @MBID)", con);
            con.Open();

            foreach (DataRow dr in prescriptions.Rows)
            {
                cmd.Parameters.AddWithValue("@CID", dr["CustomerID"]);
                cmd.Parameters.AddWithValue("@MBID", dr["MedicineBatchID"]);

                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // TODO: Switch up hard coded value for checking what column is checked
            if (e.ColumnIndex == 3)
            // Open edit Prescription Form
            {
                Prescription prescrip = new Prescription();
                prescrip.Show();
            }
            else
            // If not button cell : Exit
            {
                return;
            }
        }
        #endregion

        #region Point Of Sale
        /// <summary>
        /// This region is for Point of Sale functionality to be accessed by the Administrator users.
        /// </summary>

        #endregion

        #region Patient Record

        #endregion

        #region Client Use
        /// <summary>
        /// This region is for the Client type user. It will allow customers to create Patient Records to store
        /// in the system database.
        /// </summary>

        private void button3_Click(object sender, EventArgs e)
        {
            CreatePatientRecord();
        }

        private void CreatePatientRecord()
        {
            String FirstName = ClientFName.Text.ToString();
            String LastName = ClientLName.Text.ToString();
            String Email = ClientEmail.Text.ToString();
            String Age = ClientAge.Text.ToString();
            String Insurance = ClientInsurance.Text.ToString();
            String Date = DateTime.Today.ToShortDateString();

            string fileName = @"|DataDirectory|\WarehouseDatabase.accdb";
            OleDbConnection con = new OleDbConnection(string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = {0}; Persist Security Info = True;", fileName));
            OleDbCommand cmd = new OleDbCommand("INSERT INTO tblCustomer(FirstName, LastName, Age, Insurance, LastVisit, Email) VALUES(@FN, @LN, @A, @I, @LV, @E)", con);
            con.Open();

            cmd.Parameters.AddWithValue("@FN", FirstName);
            cmd.Parameters.AddWithValue("@LN", LastName);
            cmd.Parameters.AddWithValue("@A", Age);
            cmd.Parameters.AddWithValue("@I", Insurance);
            cmd.Parameters.AddWithValue("@LV", Date);
            cmd.Parameters.AddWithValue("@E", Email);
            cmd.ExecuteNonQuery();

            con.Close();
        }
        #endregion

        #region HardCode
        /// <summary>
        /// This region will simulate functionality that will happen automatically through the system
        /// such as daily updates. For now, functionallity will occur by Button click events.
        /// </summary> 

        private void button2_Click(object sender, EventArgs e)
        {
            CheckForNewExcelUsers();
        }

        private void CheckForNewExcelUsers()
        {
            // TODO: Refactor into a single function: Shared in PRESCRIPION region
            string fileName = @"|DataDirectory|\Excel Docs\Patient.xlsx";
            OleDbConnection con = new OleDbConnection(string.Format(@"Provider= Microsoft.ACE.OLEDB.12.0;Data Source={0}; Extended Properties = 'Excel 12.0 Xml;HDR=NO';", fileName));
            OleDbCommand cmd = new OleDbCommand("Select * from [Sheet1$]", con);
            OleDbDataReader myReader;
            con.Open();
            myReader = cmd.ExecuteReader();

            // Create Data Table to store data from Excel file
            // TODO: This should happen after new user HAS been found
            DataTable customers = new DataTable();
            customers.Columns.Add("FirstName"); customers.Columns.Add("LastName"); customers.Columns.Add("Age"); customers.Columns.Add("Insurance"); customers.Columns.Add("LastVisit"); customers.Columns.Add("Email");

            while (myReader.Read())
            {
                // EXCEL FILE LAYOUT
                // 0    1       2       3           4           5
                // ID   Name    Age     Insurance   Last Visit  Email
                //
                // ID field should be auto-generated in the DB
                // TODO: delete id field and assosiated code

                // Add customer from Excel file to Data Table
                Model.Customer cust = new Model.Customer(myReader.GetString(1), Int32.Parse(myReader.GetString(2)), myReader.GetString(3), DateTime.Parse(myReader.GetString(4)), myReader.GetString(5));
                customers.Rows.Add(cust.FirstName, cust.LastName, cust.Age, cust.Insurance, cust.LastVisit, cust.Email);
            }
            con.Close();

            if (customers.Rows.Count > 0)
            {
                try
                {
                    InsertIntoDatabase(customers);
                }
                catch (Exception)
                {
                    MessageBox.Show("There was an error saving to the database.");
                    throw;
                }
                // TODO: if there is an error, success message still displays
                MessageBox.Show(customers.Rows.Count.ToString() + "customers were added to the database.");
            }
        }

        private void InsertIntoDatabase(DataTable customers)
        {
            // TODO: Refactor into a single function: Shared in PRESCRIPTION region
            string fileName = @"|DataDirectory|\WarehouseDatabase.accdb";
            OleDbConnection con = new OleDbConnection(string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = {0}; Persist Security Info = True;", fileName));
            OleDbCommand cmd = new OleDbCommand("INSERT INTO tblCustomer(FirstName, LastName, Age, Insurance, LastVisit, Email) VALUES(@FN, @LN, @A, @I, @LV, @E)", con);
            con.Open();

            foreach (DataRow dr in customers.Rows)
            {
                cmd.Parameters.AddWithValue("@FN", dr["FirstName"]);
                cmd.Parameters.AddWithValue("@LN", dr["LastName"]);
                cmd.Parameters.AddWithValue("@A", dr["Age"]);
                cmd.Parameters.AddWithValue("@I", dr["Insurance"]);
                cmd.Parameters.AddWithValue("@LV", dr["LastVisit"]);
                cmd.Parameters.AddWithValue("@E", dr["Email"]);

                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
        #endregion
    }
}