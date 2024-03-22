using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace Lab9_FillingForm_ASPNET
{
    public partial class CustomerList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getKhachHang();
            }
        }

        void getKhachHang()
        {
            try
            {
                clsDatabase.OpenConnection();
                string query = "SELECT TenDN, HoTen, NgaySinh, GioiTinh, Email FROM KhachHang";
                SqlCommand cmd = new SqlCommand(query, clsDatabase.con);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                grCustomer.DataSource = dt;
                grCustomer.DataBind();

                clsDatabase.CloseConnection();
            }
            catch
            {

            }
        }

        protected void grCustomer_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            grCustomer.PageIndex = e.NewPageIndex;
            getKhachHang();
        }

        protected void grCustomer_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {

        }

        protected void grCustomer_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            grCustomer.EditIndex = e.NewEditIndex;
            getKhachHang();
        }

        protected void grCustomer_RowCancelingEdit(object sender, System.Web.UI.WebControls.GridViewCancelEditEventArgs e)
        {
            grCustomer.EditIndex = -1;
            getKhachHang();
        }

        protected void grCustomer_RowDeleting(object sender, System.Web.UI.WebControls.GridViewDeleteEventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();
                string query = "DELETE FROM KhachHang WHERE TenDN=@TenDN";
                SqlCommand cmd = new SqlCommand(query, clsDatabase.con);

                cmd.Parameters.AddWithValue("@TenDN", (grCustomer.DataKeys[e.RowIndex].Value.ToString()));

                cmd.ExecuteNonQuery();

                getKhachHang();
                Response.Write("<script>alert('Deleted!');</script>");

            }
            catch (Exception ex)
            {

            }
        }

        protected void grCustomer_RowUpdating(object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();
                string query = "UPDATE KhachHang SET HoTen=@HoTen,GioiTinh=@GioiTinh,NgaySinh=@NgaySinh,Email=@Email WHERE TenDN=@TenDN";
                SqlCommand cmd = new SqlCommand(query, clsDatabase.con);

                cmd.Parameters.AddWithValue("@MSSV", (grCustomer.DataKeys[e.RowIndex].Value.ToString()));
                cmd.Parameters.AddWithValue("@HoTen", (grCustomer.Rows[e.RowIndex].FindControl("txtHoTen") as TextBox).Text.Trim());
                cmd.Parameters.AddWithValue("@GioiTinh", (grCustomer.Rows[e.RowIndex].FindControl("txtGioiTinh") as TextBox).Text.Trim());
                cmd.Parameters.AddWithValue("@NgaySinh", (grCustomer.Rows[e.RowIndex].FindControl("txtNgaySinh") as TextBox).Text.Trim());
                cmd.Parameters.AddWithValue("@Email", (grCustomer.Rows[e.RowIndex].FindControl("txtEmail") as TextBox).Text.Trim());

                cmd.ExecuteNonQuery();

                grCustomer.EditIndex = -1;
                getKhachHang();
                Response.Write("<script>alert('Updated!');</script>");

            }
            catch (Exception ex)
            {

            }
        }
    }
}