using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaoBeleza
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            if (txtLogin.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Required fields");
            }
            else
            {
                if (txtLogin.Text == "suh" && txtPass.Text == "1234")
                {
                    Main frm = new Main();

                    frm.Show();
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Login not found");
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '*')
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Console.WriteLine("Pressed keys enter");
                SendKeys.Send("{TAB}");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
