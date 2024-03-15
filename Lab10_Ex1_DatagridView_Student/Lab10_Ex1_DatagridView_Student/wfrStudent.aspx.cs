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

            }
            catch (Exception ex)
            {

            }
        }

        protected void gvStudent_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvStudent.PageIndex = e.NewPageIndex;
            loadDataStudent();
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