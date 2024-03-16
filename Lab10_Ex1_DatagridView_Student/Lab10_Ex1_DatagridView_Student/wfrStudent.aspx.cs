using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace Lab10_Ex1_DatagridView_Student
{
    public partial class wfrStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadDataStudent();
            }
        }

        void loadDataStudent()
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand("select * from SinhVien", clsDatabase.con);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    gvStudent.DataSource = dt;
                    gvStudent.DataBind();
                }
                else
                {
                    dt.Rows.Add(dt.NewRow());
                    gvStudent.DataSource = dt;
                    gvStudent.DataBind();
                    gvStudent.Rows[0].Cells.Add(new TableCell());
                    gvStudent.Rows[0].Cells[0].ColumnSpan = dt.Columns.Count;
                    gvStudent.Rows[0].Cells[0].Text = "No Data found...!";
                    gvStudent.Rows[0].Cells[0].HorizontalAlign = HorizontalAlign.Center;
                }
                clsDatabase.CloseConnection();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void gvStudent_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvStudent.PageIndex = e.NewPageIndex;
            loadDataStudent();
        }

        protected void gvStudent_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("AddNew"))
            {
                try
                {
                    clsDatabase.OpenConnection();
                    string query = "INSERT INTO SinhVien (MSSV, HoTen, GioiTinh, MaLop) VALUES (@MSSV, @HoTen, @GioiTinh, @MaLop)";
                    SqlCommand cmd = new SqlCommand(query, clsDatabase.con);

                    cmd.Parameters.AddWithValue("@MSSV", (gvStudent.FooterRow.FindControl("txtMSSVFooter") as TextBox).Text.Trim());
                    cmd.Parameters.AddWithValue("@HoTen", (gvStudent.FooterRow.FindControl("txtHoTenFooter") as TextBox).Text.Trim());
                    cmd.Parameters.AddWithValue("@GioiTinh", (gvStudent.FooterRow.FindControl("txtGioiTinhFooter") as TextBox).Text.Trim());
                    cmd.Parameters.AddWithValue("@MaLop", (gvStudent.FooterRow.FindControl("txtMaLopFooter") as TextBox).Text.Trim());

                    cmd.ExecuteNonQuery();
                    Response.Write("<script>alert('New Student Added');</script>");

                    loadDataStudent();
                    lblSuccessMessage.Text = "New Student Added";

                    lblErrorMessage.Text = "";
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }

        }

        protected void gvStudent_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvStudent.EditIndex = e.NewEditIndex;
            loadDataStudent();
        }

        protected void gvStudent_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvStudent.EditIndex = -1;
            loadDataStudent();
        }

        protected void gvStudent_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();
                string query = "UPDATE SinhVien SET HoTen=@HoTen,GioiTinh=@GioiTinh,MaLop=@MaLop WHERE MSSV=@MSSV";
                SqlCommand cmd = new SqlCommand(query, clsDatabase.con);

                cmd.Parameters.AddWithValue("@MSSV", (gvStudent.DataKeys[e.RowIndex].Value.ToString()));
                cmd.Parameters.AddWithValue("@HoTen", (gvStudent.Rows[e.RowIndex].FindControl("txtHoTen") as TextBox).Text.Trim());
                cmd.Parameters.AddWithValue("@GioiTinh", (gvStudent.Rows[e.RowIndex].FindControl("txtGioiTinh") as TextBox).Text.Trim());
                cmd.Parameters.AddWithValue("@MaLop", (gvStudent.Rows[e.RowIndex].FindControl("txtMaLop") as TextBox).Text.Trim());

                cmd.ExecuteNonQuery();

                gvStudent.EditIndex = -1;
                loadDataStudent();
                Response.Write("<script>alert('Updated!');</script>");
                lblSuccessMessage.Text = "Selected Record Updated";

                lblErrorMessage.Text = "";

            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }
        }

        protected void gvStudent_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();
                string query = "DELETE FROM SinhVien WHERE MSSV=@MSSV";
                SqlCommand cmd = new SqlCommand(query, clsDatabase.con);

                cmd.Parameters.AddWithValue("@MSSV", (gvStudent.DataKeys[e.RowIndex].Value.ToString()));

                cmd.ExecuteNonQuery();

                loadDataStudent();
                Response.Write("<script>alert('Deleted!');</script>");
                lblSuccessMessage.Text = "Selected Record deleted";

                lblErrorMessage.Text = "";

            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }
        }
    }



    class clsDatabase
    {
        public static SqlConnection con;

        public static bool OpenConnection()
        {
            try
            {
                con = new SqlConnection("Data Source=DESKTOP-6A8IVC0\\SQLEXPRESS;Initial Catalog=SINHVIEN;Integrated Security=true");
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