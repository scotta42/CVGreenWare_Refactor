using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CVGreenWare
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {

                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = |DataDirectory|\\WarehouseDatabase.accdb; Persist Security Info = True;");
                OleDbCommand cmd = new OleDbCommand("Select * from tblUsers where UserName = '"+this.textBoxUsername.Text+"'AND Password='"+this.textBoxPassword.Text +"'AND Type;",con);
                OleDbDataReader myReader;


                con.Open();

                myReader = cmd.ExecuteReader();

                int count = 0;

                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    
                    if (textBoxUsername.Text == "Mchicas")
                    {
                        MessageBox.Show("Login Successful \nWelcome back, Milton");
                                            }
                    if (textBoxUsername.Text == "Bbuchan")
                    {
                        MessageBox.Show("Login Successful \nWelcome back, Brian");
                    }
                    if (textBoxUsername.Text == "Ascott")
                    {
                        MessageBox.Show("Login Successful \nWelcome back, Anthony");
                    }
                    if (textBoxUsername.Text == "Cwilson")
                    {
                        MessageBox.Show("Login Successful \nWelcome back, Chris");
                    }

                    AttemptSuccess();
                }
                else if (count > 1)
                {
                    MessageBox.Show("Invalid Username or Password");
                }
                else
                    MessageBox.Show("Invalid Username or Password");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                        
        }



        private void AttemptSuccess()
        {
            //test data
            Form1 program = new Form1();
            program.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateUser createUser = new CreateUser();
            createUser.Show();
        }
    }
}
