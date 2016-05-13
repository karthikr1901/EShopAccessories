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


public partial class Belt : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["myConnectionString"].ToString());
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter da;
    int a;

    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        //cn.ConnectionString = "Data Source = 172.23.197.6\\sql2008; Initial Catalog = Smart Accessories Inc.; User ID = sa; Password = PASSWORD@123";
        cn.Open();
        //if (!IsPostBack)
        //{
            check();
            Disp();
        //}
    } 
}


