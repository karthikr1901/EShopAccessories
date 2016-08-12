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
public partial class AdminMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        cn.Open();
        if (Session["K"] != null)
        {
            LinkButton1.Text = LinkButton10.Text = "Logout";
            SqlCommand cmd = new SqlCommand("select count(*) from cart where CustomerID='" + Session["K"].ToString() + "'", cn);
            int x = int.Parse(cmd.ExecuteScalar().ToString());
            LinkButton8.Text = Convert.ToString(x);
            cn.Close();
        }
        if ((string)Session["K"] == "10")
        {
            sc.Visible = LinkButton8.Visible = false;
        }
        SqlDataAdapter da = new SqlDataAdapter("select * from master where position = 'Right Top'", cn);
        SqlDataAdapter da1 = new SqlDataAdapter("select * from master where position = 'Right Bottom'", cn);
        SqlDataAdapter da2 = new SqlDataAdapter("select * from master where position = 'Main Image'", cn);
        
    }
}
