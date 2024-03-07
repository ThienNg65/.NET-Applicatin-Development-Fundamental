using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab8
{
    public partial class LoginForm : Form
    {
        private const string connectionString = "Data Source=DESKTOP-6A8IVC0\\SQLEXPRESS;Initial Catalog=SINHVIEN;Integrated Security=true";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            string maCB = txtMaCB.Text;
            string matKhau = txtMatKhau.Text;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                if (string.IsNullOrEmpty(maCB) || string.IsNullOrEmpty(matKhau))
                {
                    MessageBox.Show("TeacherID or Password need to be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        con.Open();
                        string query = "select count(*) from CanBo where MaCB = @MaCB and MatKhau = @MatKhau";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@MaCB", maCB);
                        cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            HomePageForm homePageForm = new HomePageForm(maCB);
                            homePageForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Mã cán bộ hoặc mật khẩu không đúng. Vui lòng thử lại.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
