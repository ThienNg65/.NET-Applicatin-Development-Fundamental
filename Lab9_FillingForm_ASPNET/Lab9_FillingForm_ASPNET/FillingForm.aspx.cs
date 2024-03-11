using System;

namespace Lab9_FillingForm_ASPNET
{
    public partial class FillingForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDangky_Click(object sender, EventArgs e)
        {
            lblThongBao.Text = "Đăng ký thành công";
        }
    }
}