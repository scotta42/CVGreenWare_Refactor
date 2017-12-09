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
    public partial class Payment : Form
    {
        int insurancePercent;
        int amount;
        int medID;
        int prescriptionID;
        public Payment()
        {
            InitializeComponent();
        }

        public Payment(int i, string fName, string lName, string insurance)
        {
            prescriptionID = i;
            InitializeComponent();
            txtName.Text = fName + " " + lName;
            txtInsurance.Text = insurance;
            CalculateInsurance(insurance);
            LoadDBInfo(i);
            CalculateCost();
        }

        private void CalculateInsurance(string insuranceName)
        {
            switch (insuranceName)
            {
                case "The Empire":
                    insurancePercent = 100;
                    break;
                case "ObamaCare":
                    insurancePercent = 50;
                    break;
                default:
                    insurancePercent = 0;
                    break;
            }
            txtInsurAmount.Text = insurancePercent.ToString() + '%';
        }

        private void CalculateCost()
        {
            int cost = 0;
            switch (medID)
            {
                    // Penicilin
                case 1:
                    cost = 10;
                    break;
                
                    // Amoxicilin
                case 2:
                    cost = 11;
                    break;

                    // Morphine
                case 3:
                    cost = 100;
                    break;

                    // Asprin
                case 4:
                    cost = 2;
                    break;

                    // Tums
                case 5:
                    cost = 1;
                    break;

                    // Nyquil
                case 6:
                    cost = 3;
                    break;

                    // Not Found
                default:
                    MessageBox.Show("Medicine not found in Prescription. Refer to a Pharmacist for confirmation.");
                    this.Close();
                    break;
            }
            int total = cost * amount;
            txtCost.Text = total.ToString();
            txtTotal.Text = (total * (.01 * (100 - insurancePercent))).ToString();
        }

        private void LoadDBInfo(int i)
        {
            // TODO: Refactor into a single function: Shared in HARDCODE region
            string fileName = @"|DataDirectory|\WarehouseDatabase.accdb";
            OleDbConnection con = new OleDbConnection(string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = {0}; Persist Security Info = True;", fileName));
            OleDbCommand cmd = new OleDbCommand("SELECT tblPrescriptions.MedicineAmount, tblMedicineBatch.MedicineID " +
                                                "FROM tblPrescriptions INNER JOIN tblMedicineBatch " +
                                                "ON tblPrescriptions.MedicineBatchID=tblMedicineBatch.MedicineBatchID " +
                                                "WHERE tblPrescriptions.PrescriptionID="+i.ToString(), con);
            OleDbDataReader reader;
            con.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                amount = reader.GetInt32(0);
                medID = reader.GetInt32(1);
            }
        }

        private void Cash_Click(object sender, EventArgs e)
        {
            PaymentConfirmed();
        }

        private void Card_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Did the payment go through successfully?", "Question", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                PaymentConfirmed();
            }
            else if (d == DialogResult.No)
            {
                PaymentDenied();
            }
        }

        private void PaymentConfirmed()
        {
            HandlePayment("Complete");
        }

        private void HandlePayment(string type)
        {
            // TODO: Refactor into a single function: Shared in HARDCODE region
            string fileName = @"|DataDirectory|\WarehouseDatabase.accdb";
            OleDbConnection con = new OleDbConnection(string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = {0}; Persist Security Info = True;", fileName));
            OleDbCommand cmd = new OleDbCommand("UPDATE tblPrescriptions SET Status = '" + type + "' WHERE PrescriptionID = " + prescriptionID, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void PaymentDenied()
        {
            HandlePayment("On-Hold");
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("This will cancel the Prescription. A new doctors order will need to be filled if the order is still needed.", "Warning", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                HandlePayment("Canceled");
                this.Close();
            }
        }
    }
}
