using System;
using System.Windows.Forms;

namespace Lab2_B2
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;

            if (username == "Admin" && password == "Admin")
            {
                EmployeeDetails emp = new EmployeeDetails();
                this.Hide();
                emp.Show();
            }
            else
            {
                MessageBox.Show("Invalid user name or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
