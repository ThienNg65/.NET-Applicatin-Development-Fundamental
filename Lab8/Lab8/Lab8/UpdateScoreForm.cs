using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab8
{
    public partial class UpdateScoreForm : Form
    {
        private const string connectionString = "Data Source=DESKTOP-6A8IVC0\\SQLEXPRESS;Initial Catalog=SINHVIEN;Integrated Security=true";
        private string maCB;
        private string maMon;

        public UpdateScoreForm(string maCB, string maMon)
        {
            InitializeComponent();
            this.maCB = maCB;
            this.maMon = maMon;
            LoadStudents();
        }

        private void LoadStudents()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT s.MSSV, s.HoTen, d.Diem FROM SinhVien s " +
                        "join Diem d on s.MSSV = d.MSSV " +
                        "WHERE d.MaMon = @MaMon";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@MaMon", maMon);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string mssv = reader["MSSV"].ToString();
                        string hoTen = reader["HoTen"].ToString();
                        string diem = reader["Diem"] != DBNull.Value ? reader["Diem"].ToString() : "";
                        dataGridView1.Rows.Add(mssv, hoTen, diem);
                    }

                    reader.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Check if the cell value is null before accessing it
                if (row.Cells["MSSV"].Value == null || row.Cells["Diem"].Value == null)
                {
                    // Skip this row if either MSSV or Diem cell value is null
                    continue;
                }

                string mssv = row.Cells["MSSV"].Value.ToString();
                float diem = float.Parse(row.Cells["Diem"].Value.ToString());

                // Cập nhật điểm thi vào cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    /*string query = "MERGE INTO Diem AS target " +
                                         "USING (VALUES (@MSSV, @MaMon, @Diem)) AS source (MSSV, MaMon, Diem) " +
                                         "ON target.MSSV = source.MSSV AND target.MaMon = source.MaMon " +
                                         "WHEN MATCHED THEN " +
                                         "UPDATE SET Diem = source.Diem " +
                                         "WHEN NOT MATCHED THEN " +
                                         "INSERT (MSSV, MaMon, Diem) " +
                                         "VALUES (source.MSSV, source.MaMon, source.Diem);";*/

                    string query = "UPDATE Diem SET Diem = @Diem WHERE MSSV = @MSSV AND MaMon = @MaMon";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Diem", diem);
                    command.Parameters.AddWithValue("@MSSV", mssv);
                    command.Parameters.AddWithValue("@MaMon", maMon);
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Đã cập nhật điểm thi thành công.");
        }
    }
}
