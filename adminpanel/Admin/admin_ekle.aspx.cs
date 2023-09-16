using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace adminpanel.Admin
{
    public partial class admin_ekle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            database.OpenConnection();
            doldur();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
        void doldur()
        {
            string cumle = "Select * from admin";
            database.cmd.CommandText = cumle;
            database.da = new SqlDataAdapter(database.cmd);
            database.da.Fill(database.dt);
            GridView1.DataSource = database.dt;

        }
    }
}