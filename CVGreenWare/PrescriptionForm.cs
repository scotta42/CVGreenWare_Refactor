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
        int prescriptionID;
        DataBase db = new DataBase();


        List<int> CustomerIDs = new List<int>();
        List<int> MedIDs = new List<int>();
        List<int> BatchIDs = new List<int>();

        public PrescriptionForm()
        {
            InitializeComponent();
            LoadDBInfo();
        }

        public PrescriptionForm(int i)
        {
            InitializeComponent();
            prescriptionID = i;
            LoadDBInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                db.SavePrescription((@"|DataDirectory|\WarehouseDatabase.accdb"),custID,medID,medAmount,prescriptionID);
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

            string fileName = @"|DataDirectory|\WarehouseDatabase.accdb";
            db.DbSelect(fileName, ("SELECT MedicineBatchID FROM tblMedicineBatch"));
            OleDbDataReader reader = db.GetCMD().ExecuteReader();
            OleDbCommand cmd;

            while (reader.Read())
            {
                BatchIDs.Add(reader.GetInt32(0));
            }
            cmd = new OleDbCommand("SELECT MedicineID FROM tblMedicine", db.GetCon());
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                MedIDs.Add(reader.GetInt32(0));
            }
            cmd = new OleDbCommand("SELECT CustomerID FROM tblCustomer", db.GetCon());
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CustomerIDs.Add(reader.GetInt32(0));
            }
            db.GetCon().Close();
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


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            custID = Int32.Parse(comboBox2.SelectedItem.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            medID = Int32.Parse(comboBox1.SelectedItem.ToString());
        }

        private void QTY_ValueChanged(object sender, EventArgs e)
        {
            medAmount = Convert.ToInt32(QTY.Value);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            medBatchID = Int32.Parse(comboBox3.SelectedItem.ToString());
        }
    }
}
