using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;



public partial class Login : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["myConnectionString"].ToString());
    SqlCommand cmd = new SqlCommand();

    //private static string strKeyCode = string.Empty;

    //public static string KeyCode
    //{
    //    get
    //    {
    //        return strKeyCode;
    //    }
    //    set
    //    {
    //        strKeyCode = value;
    //    }
    //}

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        check();
        //Button imgbt = (Button)sender;
        //Session["Login"] = imgbt.ID;
        //Response.Redirect("Default2.aspx");
    }
  
}


