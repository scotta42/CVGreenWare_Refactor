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
    class DataBase
    {
        OleDbConnection con;
        OleDbCommand cmd;
        public void DbSelect(string fileName, string selectCom)
        {
            con = new OleDbConnection(string.Format(@"Provider= Microsoft.ACE.OLEDB.12.0;Data Source={0}; Extended Properties = 'Excel 12.0 Xml;HDR=NO';", fileName));
            cmd = new OleDbCommand(selectCom, con);
            con.Open();
        }
        public void SavePrescription(string fileName, int custID, int medID, int medAmount, int prescriptionID)
        {
            OleDbConnection con = new OleDbConnection(string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = {0}; Persist Security Info = True;", fileName));
            OleDbCommand cmd = new OleDbCommand("UPDATE tblPrescriptions SET CustomerID = " + custID + ", MedicineBatchID = " + medID + ", MedicineAmount = " + medAmount + ", Status = 'Ready' WHERE PrescriptionID = " + prescriptionID, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public OleDbCommand GetCMD(){ return cmd; }
        public OleDbConnection GetCon() { return con; }
        public void DbClose()
        {
            con.Close();
        }

    }
}
