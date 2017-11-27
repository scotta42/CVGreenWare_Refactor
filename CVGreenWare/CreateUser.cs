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
    public partial class CreateUser : Form
    {
        int userType;
        public CreateUser()
        {
            userType = 0;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isFormValid())
            {
                CreateNewUser();
            }
        }

        private void CreateNewUser()
        {
            Model.FormUser newUser = new Model.FormUser(txtFName.Text, txtLName.Text, txtUName.Text, txtPassword.Text, userType);
            
            // Open connection to DB and save User
            using (OleDbConnection con = new OleDbConnection())
            {
                // TODO: Refactor fileName to not be hard coded
                string fileName = @"C:\Users\bucha\CVGreenWare\CVGreenWare\WarehouseDatabase.accdb";
                DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter("Select * from [tblUsers]", string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};", fileName));
                con.Open();
                da.Fill(ds, "tblUsers");

                ds.Tables["tblUsers"].Rows.Add(newUser.FirstName, newUser.LastName, newUser.UserName, newUser.Password, newUser.Type);
                da.Update(ds, "tblUsers");
                con.Close();
            }
        }

        private bool isFormValid()
        {
            if (userType > 0)
            {
                if (txtUName.Text != null && txtUName.Text != "")
                {
                    if (txtPassword.Text != null && txtPassword.Text != "")
                    {
                        if (txtFName.Text != null && txtFName.Text != "")
                        {
                            if (txtLName.Text != null && txtLName.Text != "")
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            userType = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            userType = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            userType = 3;
        }

    }
}
