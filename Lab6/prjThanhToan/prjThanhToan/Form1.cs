using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prjThanhToan
{
    public partial class Form1 : Form
    {
        int soHD;

        void ResetFields(bool status)
        {
            txtSoHD.Clear();
            txtHoTen.Clear();
            cboSoPhong.SelectedIndex = -1;
            txtCMND.Clear();
            txtSoTien.Clear();
            btnLuu.Enabled = status;
            btnThoat.Enabled = status;
            btnThem.Enabled = !status;
            txtHoTen.Focus();
        }

        public Form1()
        {
            InitializeComponent();

            clsDatabase.OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaPhong, TenPhong from Phong", clsDatabase.con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cboSoPhong.DataSource = dt;
            cboSoPhong.DisplayMember = "TenPhong";
            cboSoPhong.ValueMember = "MaPhong";

            clsDatabase.CloseConnection();

            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnThoat.Enabled = true;
        }

        class clsDatabase
        {
            public static SqlConnection con;

            public static bool OpenConnection()
            {
                try
                {
                    // con = new SqlConnection("Server=DESKTOP-6A8IVC0\\SQLEXPRESS;Database=DVDLibrary;uid=mylogin;pwd=mylogin");
                    con = new SqlConnection("Data Source=DESKTOP-6A8IVC0\\SQLEXPRESS;Initial Catalog=ThanhToan;Integrated Security=true;uid=mylogin;pwd=mylogin");
                    con.Open();
                }
                catch (Exception)
                {
                    return false;
                }
                return true;
            }

            public static bool CloseConnection()
            {
                try
                {
                    con.Close();
                }
                catch (Exception)
                {
                    return false;
                }
                return true;
            }
        }

        private void cboSoPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand("Select max(SoHD) from KhachHang", clsDatabase.con);
                soHD = Convert.ToInt32(cmd.ExecuteScalar());
                clsDatabase.CloseConnection();
            }
            catch (Exception)
            {
                soHD = 0;
            }

            soHD++;
            ResetFields(false);
            txtSoHD.Text = soHD.ToString();
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnThoat.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            ResetFields(false);
            Application.Exit();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string strInsert = "INSERT INTO KhachHang VALUES (@SoHD, @TenKH, @CMND, @SoTien, @NgayTT, @Phong)";
                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(strInsert, clsDatabase.con);

                SqlParameter p1 = new SqlParameter("@SoHD", SqlDbType.Int);
                p1.Value = soHD;

                SqlParameter p2 = new SqlParameter("@TenKH", SqlDbType.NVarChar);
                p2.Value = txtHoTen.Text;

                SqlParameter p3 = new SqlParameter("@CMND", SqlDbType.NVarChar);
                p3.Value = txtCMND.Text;

                SqlParameter p4 = new SqlParameter("@SoTien", SqlDbType.Money);
                p4.Value = Convert.ToDecimal(txtSoTien.Text.Trim());

                SqlParameter p5 = new SqlParameter("@NgayTT", SqlDbType.DateTime);
                p5.Value = Convert.ToDateTime(dateTT.Text);

                SqlParameter p6 = new SqlParameter("@Phong", SqlDbType.Int);
                p6.Value = cboSoPhong.SelectedValue;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Insert successfully!!!");
                clsDatabase.CloseConnection();

                ResetFields(false);
                btnThoat.Enabled = true;
                btnThem.Enabled = true;
                btnLuu.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
