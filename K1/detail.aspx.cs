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


public partial class detail : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["myConnectionString"].ToString());
    SqlCommand cmd = new SqlCommand();
    //SqlDataAdapter da;
    //DataTable dt;
    SqlCommand cm;
    string productid = "", userid = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Session["K"] != null)
        {
            cn.Open();
            cm = new SqlCommand("insert into Cart values('" + productid + "','" + userid + "' , '" + Label3.Text + "' , '" + System.DateTime.Now.ToString("yyyy-MMM-dd hh:mm:ss tt") + "' , '" + Label4.Text + "' )", cn);
            cm.ExecuteNonQuery();
            cn.Close();
            DisplayCartCount();
        }
        else
            Response.Redirect("Login.aspx");
    }
    private void DisplayCartCount()
    {
        cn.Open();
        SqlCommand cmd = new SqlCommand("select count(*) from cart where CustomerID='" + Session["K"].ToString() + "'", cn);
        int x = int.Parse(cmd.ExecuteScalar().ToString());
        cn.Close();
        LinkButton lb = (LinkButton)Master.FindControl("LinkButton8");
        lb.Text = Convert.ToString(x);
    }
}