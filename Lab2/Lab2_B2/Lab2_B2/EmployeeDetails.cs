using System;
using System.Windows.Forms;

namespace Lab2_B2
{
    public partial class EmployeeDetails : Form
    {
        public EmployeeDetails()
        {
            InitializeComponent();
        }

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            login f1 = new login();
            f1.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEName.Text = "";
            txtEAddress.Text = "";
            dateJoin.Value = DateTime.Now;
            cbBoxDepartment.SelectedIndex = -1;
            lstboxEducation.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Employee details saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
