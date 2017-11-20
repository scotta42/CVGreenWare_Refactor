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

namespace CVGreenWare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Login_Form login = new Login_Form();
            login.Show();
            this.Hide();
        }

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

        private void tblInventoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblInventoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.warehouseDatabaseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'warehouseDatabaseDataSet1.tblCustomer' table. You can move, or remove it, as needed.
            this.tblCustomerTableAdapter.Fill(this.warehouseDatabaseDataSet1.tblCustomer);
            // TODO: This line of code loads data into the 'warehouseDatabaseDataSet.tblInventory' table. You can move, or remove it, as needed.
            this.tblInventoryTableAdapter.Fill(this.warehouseDatabaseDataSet.tblInventory);

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
            // Gather info from form
            // TODO: Refactor fileName to not be hard coded
            string fileName = @"C:\Users\bucha\CVGreenWare\CVGreenWare\WarehouseDatabase.accdb";
            string name = ClientFName.Text + " " + ClientLName.Text;
            string email = ClientEmail.Text;
            int age = Int32.Parse(ClientAge.Text);
            string insurance = ClientInsurance.Text;
            // TODO: Method to scrub input so DB corruption doesn't occur

            // Open connection to DB and save customer info
            using (OleDbConnection con = new OleDbConnection(string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};", fileName)))
            {
                DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter("Select * from [tblCustomers]", string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};", fileName));
                con.Open();
                da.Fill(ds, "tblCustomers");

                ds.Tables["tblCustomers"].Rows.Add(name, age, insurance, DateTime.Today, email);
                da.Update(ds, "tblCustomers");
                con.Close();
            }
        }
        #endregion

        #region User Login
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        //Setting up the Login button
        //
        //using userNameBox for the username textbox and passwordBox for the Password textbox

        private void button1_Click(object sender, EventArgs e)
        {
            if ((userNameBox.Text == "Anthony") && (passwordBox.Text == "Pinapple31!!"))
            {
                MessageBox.Show("Welcome Back Anthony");
            }
            else
            {
                logError.Visible = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region HardCode
        /// <summary>
        /// This region will simulate functionality that will happen automatically through the system
        /// such as daily updates. For now, functionallity will occur by Button click events.
        /// </summary> 

        private void button2_Click(object sender, EventArgs e)
        {
            string brianHome = @"C:\Users\Milton\source\repos\CVGreenWare\CVGreenWare\Excel Docs\Patient.xlsx";
            ExcelToCustomerDB(brianHome);
        }

        private void ExcelToCustomerDB(string fileName)
        {
            using (OleDbConnection con = new OleDbConnection(string.Format("Provider = Microsoft.ACE.OLEDB.12.0; Data Source ={0};Extended Properties = Excel 12.0 Xml;HDR=NO", fileName)))
            {
                DataTable DT = new DataTable();
                string query = string.Format("select * from [Sheet1$]");
                con.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, con);
                adapter.Fill(DT);
                foreach (DataRow dr in DT.Rows)
                {
                    warehouseDatabaseDataSet.tblCustomer.Rows.Add(dr);
                }
            }
        }
        #endregion


    }
}