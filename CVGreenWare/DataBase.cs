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
        public void DbSelect(string fileName)
        {
            con = new OleDbConnection(string.Format(@"Provider= Microsoft.ACE.OLEDB.12.0;Data Source={0}; Extended Properties = 'Excel 12.0 Xml;HDR=NO';", fileName));
            cmd = new OleDbCommand("Select * from [Sheet1$]", con);
            con.Open();
        }
        public OleDbCommand GetCMD(){ return cmd; }
        public OleDbConnection GetCON() { return con; }
        public void DbClose()
        {
            con.Close();
        }

    }
}
