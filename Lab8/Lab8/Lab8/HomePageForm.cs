using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab8
{
    public partial class HomePageForm : Form
    {
        private string maCB;
        private const string connectionString = "Data Source=DESKTOP-6A8IVC0\\SQLEXPRESS;Initial Catalog=SINHVIEN;Integrated Security=true";

        public HomePageForm(string maCB)
        {
            InitializeComponent();
            this.maCB = maCB;
            loadSubject();
        }

        // method to load the subjects of lecturer
        private void loadSubject()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "select m.MaMon, m.TenMon " +
                        "from MonHoc m join GiangDay g on m.MaMon = g.MaMon " +
                        "where MaCB = @MaCB";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@MaCB", maCB);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string maMon = reader["MaMon"].ToString();
                        string tenMon = reader["TenMon"].ToString();
                        lstBox.Items.Add($"{maMon} - {tenMon}");
                    }

                    reader.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdateScore_Click(object sender, System.EventArgs e)
        {
            if (lstBox.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn môn học để cập nhật điểm thi.");
                return;
            }

            string maMon = lstBox.SelectedItem.ToString().Split('-')[0].Trim();
            UpdateScoreForm updateScoreForm = new UpdateScoreForm(maCB, maMon);
            updateScoreForm.ShowDialog();
        }
    }
}
