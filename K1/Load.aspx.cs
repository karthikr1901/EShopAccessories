﻿using System;
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
using System.IO;


public partial class Load : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["myConnectionString"].ToString());
    SqlCommand cmd = new SqlCommand();

    DataRow dr;
    string code;

    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Enabled = false;
        TextBox1.Visible = false;
        txtUrl.Enabled = false;
        txtUrl.Visible = false;
    }
}