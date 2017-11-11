using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
