using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Web.Configuration;


public partial class Signup : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["myConnectionString"].ToString());
    SqlCommand cmd = new SqlCommand();
    SqlCommand cm = new SqlCommand();
    DataRow dr;
    string code;

    protected void Page_Load(object sender, EventArgs e)
    {
        btnOK.Visible = false;
        Label9.Visible = false;
        Label8.Visible = false;


        //TextBox9.Visible = false;
        //TextBox9.Enabled = false;

        //TextBox7.Visible = false;
        //TextBox7.Enabled = false;

        genpass();
    }    
}





