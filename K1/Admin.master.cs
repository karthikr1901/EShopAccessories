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

public partial class MasterPage : System.Web.UI.MasterPage
{
    SqlConnection cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["myConnectionString"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {
        sc.Visible = LinkButton2.Visible = false;
        LinkButton13.Visible = false;
        if (Session["K"] != null)
        {
            sc.Visible = LinkButton2.Visible = true;
            LinkButton1.Text = "Logout";
            cn.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from cart where CustomerID='" + Session["K"].ToString() + "'", cn);
            int x = int.Parse(cmd.ExecuteScalar().ToString());
            LinkButton2.Text = Convert.ToString(x);
        }
        if (Session["K"] != null)
        {
        }
    }    
}

