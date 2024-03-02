using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prjQLCB
{
    public partial class Form1 : Form
    {
        int mscb;
        int macv;
        string hotenCB;
        string chucvu;
        int sogio;
        decimal price;

        public Form1()
        {
            InitializeComponent();

            //Enable button Save and MSCB
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            txtHoTen.Focus();
            try
            {
                clsDatabase.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter("select MaCV, TenCV from ChucVu", clsDatabase.con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Data binding
                cboChucVu.DataSource = dt;
                cboChucVu.DisplayMember = "TenCV";
                cboChucVu.ValueMember = "MaCV";
                clsDatabase.CloseConnection();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ResetFields(bool status)
        {
            txtMSCB.Clear();
            txtHoTen.Clear();
            cboChucVu.SelectedIndex = -1;
            txtSoGio.Clear();
            txtDonGia.Clear();
            btnThem.Enabled = status;
            btnLuu.Enabled = !status;
            btnDong.Enabled = !status;
            txtHoTen.Focus();
        }

        private void cboChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT max(MaCB) from CanBo", clsDatabase.con);
                mscb = Convert.ToInt32(cmd.ExecuteScalar());
                clsDatabase.CloseConnection();

            }
            catch (Exception)
            {
                mscb = 0;
            }

            mscb++;
            ResetFields(true);
            txtMSCB.Text = mscb.ToString();
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnDong.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand("INSERT INTO CanBo values (@mscb, @hotenCB, @chucvu, @sogio, @price)", clsDatabase.con);

                SqlParameter p1 = new SqlParameter("@mscb", System.Data.SqlDbType.Int);
                p1.Value = mscb;

                SqlParameter p2 = new SqlParameter("@hotenCB", System.Data.SqlDbType.NVarChar);
                p2.Value = txtHoTen.Text.Trim();

                SqlParameter p3 = new SqlParameter("@chucvu", System.Data.SqlDbType.Int);
                p3.Value = cboChucVu.SelectedIndex;

                SqlParameter p4 = new SqlParameter("@sogio", System.Data.SqlDbType.Int);
                p4.Value = Convert.ToInt32(txtSoGio.Text.Trim());

                SqlParameter p5 = new SqlParameter("@price", System.Data.SqlDbType.Money);
                p5.Value = Convert.ToDecimal(txtDonGia.Text.Trim());

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Insert Successfully!!!");
                clsDatabase.CloseConnection();
                ResetFields(false);

                clsDatabase.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            ResetFields(false);
            Application.Exit();
        }
    }

    class clsDatabase
    {
        public static SqlConnection con;

        public static bool OpenConnection()
        {
            try
            {
                // con = new SqlConnection("Server=DESKTOP-6A8IVC0\\SQLEXPRESS;Database=DVDLibrary;uid=mylogin;pwd=mylogin");
                con = new SqlConnection("Data Source=DESKTOP-6A8IVC0\\SQLEXPRESS;Initial Catalog=QLCB;Integrated Security=true;uid=mylogin;pwd=mylogin");
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
}
