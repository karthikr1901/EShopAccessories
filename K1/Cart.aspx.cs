﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Web.Configuration;

public partial class Cart : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["myConnectionString"].ToString());
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter da;
    DataTable dt;
    SqlCommand cm = new SqlCommand();
    string productid = "", userid = "";"";
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox9.Visible = false;
        TextBox1.Visible = false;  
        TextBox1.Text = Convert.ToString(Session["prodid"]);
        TextBox9.Text = Convert.ToString(Session["K"]);
        
        if (!IsPostBack)
        {
	}        
    }

}


