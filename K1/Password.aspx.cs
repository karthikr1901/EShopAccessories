using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Web.Configuration;


public partial class Password : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["myConnectionString"].ToString());
    SqlCommand cmd = new SqlCommand();

    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox2.Visible = false;
        TextBox2.Enabled = false;
        TextBox4.Visible = false;
        TextBox4.Enabled = false;

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        check();
    }
}