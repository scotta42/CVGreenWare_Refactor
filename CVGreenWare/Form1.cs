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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }



        //Setting up the Login button
        //
        //using userNameBox for the username textbox and passwordBox for the Password textbox
  
        private void button1_Click(object sender, EventArgs e)
        {
            if ((userNameBox.Text == "Anthony")&&(passwordBox.Text == "Pinapple31!!"))
            {
                MessageBox.Show("Welcome Back Anthony");
            }else
            {
                logError.Visible = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


 //WAREHOUSE TAB -----------------------------------------------------------------


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
        // WAREHOUSE TAB ----------------------------------------------------------------


    }
}
