using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVGreenWare
{
    public partial class PrescriptionForm : Form
    {
        int custID;
        int medID;
        int medBatchID;
        int medAmount;
        int prescriptionID = 1;

        List<int> CustomerIDs = new List<int>();
        List<int> MedIDs = new List<int>();
        List<int> BatchIDs = new List<int>();

        public PrescriptionForm()
        {
            InitializeComponent();
            LoadDBInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SavePrescription();
            }
            catch (Exception)
            {
                MessageBox.Show("There was an error saving to the database.");
                throw;
            }
            finally
            {
                MessageBox.Show("Saving was a success.");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure?", "Exit?", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void LoadDBInfo()
        {
            // TODO: Refactor into a single function: Shared in HARDCODE region
            string fileName = @"|DataDirectory|\WarehouseDatabase.accdb";
            OleDbConnection con = new OleDbConnection(string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = {0}; Persist Security Info = True;", fileName));
            OleDbCommand cmd = new OleDbCommand("SELECT MedicineBatchID FROM tblMedicineBatch", con);
            OleDbDataReader reader;
            con.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                BatchIDs.Add(reader.GetInt32(0));
            }
            cmd = new OleDbCommand("SELECT MedicineID FROM tblMedicine", con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                MedIDs.Add(reader.GetInt32(0));
            }
            cmd = new OleDbCommand("SELECT CustomerID FROM tblCustomer", con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CustomerIDs.Add(reader.GetInt32(0));
            }
            con.Close();
            foreach (int i in MedIDs)
            {
                comboBox1.Items.Add(i);
            }
            foreach (int i in BatchIDs)
            {
                comboBox3.Items.Add(i);
            }
            foreach (int i in CustomerIDs)
            {
                comboBox2.Items.Add(i);
            }
        }

        private void SavePrescription()
        {
            // TODO: Refactor into a single function: Shared in HARDCODE region
            string fileName = @"|DataDirectory|\WarehouseDatabase.accdb";
            OleDbConnection con = new OleDbConnection(string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = {0}; Persist Security Info = True;", fileName));
            OleDbCommand cmd = new OleDbCommand("UPDATE tblPrescriptions SET CustomerID = " + custID.ToString() + ", MedicineBatchID = " + medID.ToString() + ", MedicineAmount = " + medAmount.ToString() + " WHERE PrescriptionID = " + prescriptionID.ToString(), con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            custID = 1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            medID = 1;
        }

        private void QTY_ValueChanged(object sender, EventArgs e)
        {
            medAmount = 1;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            medBatchID = 1;
        }
    }
}
