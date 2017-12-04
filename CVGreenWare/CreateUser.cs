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
            radioButton1.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //admin key now required and textbox will display if all fields are not filled in
                if (isFormValid())
                {
                    if (txtAdmin.Text == "Genesis")
                    {
                    CreateNewUser();
                    this.Close();
                    }else
                     {
                    MessageBox.Show("Admin Key Invalid");
                }

                 }else
                     {
                MessageBox.Show("Please fill in all fields before submitting");
            }
        }

        private void CreateNewUser()
        {
            Model.FormUser newUser = new Model.FormUser(txtFName.Text, txtLName.Text, txtUName.Text, txtPassword.Text, userType);

            string fileName = @"|DataDirectory|\WarehouseDatabase.accdb";
            OleDbConnection con = new OleDbConnection(string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = {0}; Persist Security Info = True;", fileName));
            OleDbCommand cmd = new OleDbCommand("INSERT INTO tblUsers(FirstName, LastName, UserName, PWord, Type) VALUES(@FN, @LN, @UN, @P, @T)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@FN", newUser.FirstName);
            cmd.Parameters.AddWithValue("@LN", newUser.LastName);
            cmd.Parameters.AddWithValue("@UN", newUser.UserName);
            cmd.Parameters.AddWithValue("@P", newUser.Password);
            cmd.Parameters.AddWithValue("@T", newUser.Type);

            cmd.ExecuteNonQuery();
            con.Close();
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
