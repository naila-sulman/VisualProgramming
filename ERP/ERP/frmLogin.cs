using System;
using System.Windows.Forms;

namespace ERP
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblUserName.Text = "Name";
            lblPassword.Text = "Password";
            btnLogin.Text = "Login";
            btnCancel.Text = "Cancel";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "Naila" || txtName.Text == "naila")
            {
                if (txtPassword.Text == "123456")
                {
                    ERPMain frmMain = new ERPMain();
                    frmMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Enter Valid Passowrd");
                }
            }
            else
            {
                MessageBox.Show("Your Valid Name");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
