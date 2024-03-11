using System;
using System.Data;
using System.Data.SqlClient;

namespace Lab9_FillingForm_ASPNET
{
    public partial class FillingForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        void ResetFields(bool status)
        {
            txtTenDN.Text = "";
            txtMK.Text = "";
            txtNhaplaiMK.Text = "";
            txtKH.Text = "";
            txtNgaySinh.Text = "";
            txtEmail.Text = "";
            txtThuNhap.Text = "";
            lblThongBao.Text = "";
        }

        protected void btnDangky_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Insert into KhachHang values (@TenDN, @MK, @HoTen, @NgaySinh, @GioiTinh, @Email, @ThuNhap)";
                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, clsDatabase.con);

                cmd.Parameters.AddWithValue("@TenDN", txtTenDN.Text);
                cmd.Parameters.AddWithValue("@MK", txtMK.Text);
                cmd.Parameters.AddWithValue("@HoTen", txtKH.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", txtNgaySinh.Text);
                cmd.Parameters.AddWithValue("@GioiTinh", radNam.Checked ? "Nam" : "Nữ");
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@ThuNhap", txtThuNhap.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    lblThongBao.Text = "Đăng ký không thành công";
                    ResetFields(false);
                }
                else
                {
                    lblThongBao.Text = "Đăng ký thành công";
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }

            /*lblThongBao.Text = "Đăng ký thành công";*/
        }
    }

    class clsDatabase
    {
        public static SqlConnection con;

        public static bool OpenConnection()
        {
            try
            {
                con = new SqlConnection("Data Source=DESKTOP-6A8IVC0\\SQLEXPRESS;Initial Catalog=QLKhachHang;Integrated Security=true");
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