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
        if (Session["Login"] != null)
        {
            LinkButton1.Text = "Logout";
            cn.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from cart where CustomerID='" + Session["K"].ToString() + "'", cn);
            int x = int.Parse(cmd.ExecuteScalar().ToString());
            LinkButton8.Text = Convert.ToString(x);
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        if (LinkButton1.Text == "Login")
            Response.Redirect("Login.aspx");
        else if (LinkButton1.Text == "Logout")
        {
            Session["Login"] = null;
            LinkButton1.Text = "Login";
        }
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default2.aspx");
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Session["click"] = "Belts";
        Response.Redirect("Belt.aspx");
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Session["click"] = "Watches";
        Response.Redirect("Belt.aspx");
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Session["click"] = "Wallets";
        Response.Redirect("Belt.aspx");
    }
    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        Session["click"] = "Pens";
        Response.Redirect("Belt.aspx");
    }
    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        Session["click"] = "Sunglasses";
        Response.Redirect("Belt.aspx");
    }
    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        Response.Redirect("Cart.aspx");
    }
}
