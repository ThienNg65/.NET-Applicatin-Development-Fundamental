using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prjDVD
{
    class clsDatabase
    {
        public static SqlConnection con;

        public static bool OpenConnection()
        {
            try
            {
                con = new SqlConnection("Server=DESKTOP-6A8IVC0\\SQLEXPRESS;Database=DVDLibrary;uid=mylogin;pwd=mylogin");
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

    public partial class frmDVDCatalog : Form
    {
        int CodeNo;
        decimal price;
        string language;
        int subTitle;

        public frmDVDCatalog()
        {
            InitializeComponent();
        }
    }
}
