using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Web.Configuration;

public partial class feedback : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["myConnectionString"].ToString());
    SqlCommand cmd = new SqlCommand();
    SqlCommand cm = new SqlCommand();
    SqlCommand cmdd = new SqlCommand();
    SqlDataAdapter ad = new SqlDataAdapter();
    DataTable dataTable = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        if ((string)Session["K"] == "10")
        {
            Label1.Visible = false;
            Label2.Visible = false;            
            Label4.Visible = false;
            TextBox1.Visible = false;
            TextBox2.Visible = false;
            Button1.Visible = false;
            if (!IsPostBack)
            {
                fillgrid();
            }
        }
        else
        {
            Panel1.Visible = false;
            gvUsers.Visible = false;
        }
    }
    
}
