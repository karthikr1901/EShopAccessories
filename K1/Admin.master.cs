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
        if ((string)Session["K"] == "10")
        {
            LinkButton13.Visible = true;
            sc.Visible = LinkButton2.Visible = false;
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        if (LinkButton1.Text == "Login")
            Response.Redirect("Login.aspx");
        else if (LinkButton1.Text == "Logout")
        {
            //Session["K"] = null;
            Session.Clear();
            LinkButton1.Text = "Login";
            Response.Redirect("Default2.aspx");
        }
    }    
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Cart.aspx");
    }
    protected void LinkButton9_Click(object sender, EventArgs e)
    {
        Response.Redirect("Change.aspx");
    }
    protected void LinkButton11_Click(object sender, EventArgs e)
    {
        Response.Redirect("About.aspx");
    }
    protected void LinkButton12_Click(object sender, EventArgs e)
    {
        Response.Redirect("Contact.aspx");
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if ((string)Session["K"] == "10")
        {
            Response.Redirect("Load.aspx");
        }
        else
        {
            Response.Redirect("Default2.aspx");
        }
    }
    protected void LinkButton13_Click(object sender, EventArgs e)
    {
        if ((string)Session["K"] == "10")
        {
            Response.Redirect("Load.aspx");
        }
        else
        {
            Response.Redirect("Default2.aspx");
        }
    }
}

