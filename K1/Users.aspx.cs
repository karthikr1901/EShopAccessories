using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;

public partial class Users : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["myConnectionString"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            LoadUsers();
        }
    }
    private void LoadUsers()
    {
        conn.Open();
        SqlDataAdapter da = new SqlDataAdapter("select * from Customer", conn);
        DataTable dt = new DataTable();
        da.Fill(dt);
        gvUsers.DataSource = dt;
        gvUsers.DataBind();
        conn.Close();
    }
}