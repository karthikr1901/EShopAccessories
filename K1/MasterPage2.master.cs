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

public partial class MasterPage : System.Web.UI.MasterPage
{
    SqlConnection cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["myConnectionString"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {
        sc.Visible = LinkButton8.Visible = false;
        cn.Open();
        if (Session["K"] != null)
        {
            sc.Visible = LinkButton8.Visible = true;
            LinkButton1.Text = LinkButton10.Text = "Logout";
            
            SqlCommand cmd = new SqlCommand("select count(*) from cart where CustomerID='" + Session["K"].ToString() + "'", cn);
            int x = int.Parse(cmd.ExecuteScalar().ToString());
            LinkButton8.Text = Convert.ToString(x);
        }
        if ((string)Session["K"] == "10")
        {
            sc.Visible = LinkButton8.Visible = false;
        }
        SqlDataAdapter da = new SqlDataAdapter("select * from master where position = 'Right Top'", cn);
        SqlDataAdapter da1 = new SqlDataAdapter("select * from master where position = 'Right Bottom'", cn);
        SqlDataAdapter da2 = new SqlDataAdapter("select * from master where position = 'Main Image'", cn);
        DataTable dt = new DataTable();
        da.Fill(dt);
        DataTable dt1 = new DataTable();
        da1.Fill(dt1);
        DataTable dt2= new DataTable();
        da2.Fill(dt2);

        Image1.ImageUrl = dt2.Rows[0]["Pic"].ToString();
        Image2.ImageUrl = dt.Rows[0]["Pic"].ToString();
        Image3.ImageUrl = dt1.Rows[0]["Pic"].ToString();
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
    protected void LinkButton14_Click(object sender, EventArgs e)
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
    
    protected void LinkButton8_Click1(object sender, EventArgs e)
    {
        Response.Redirect("Cart.aspx");
    }

    protected void LinkButton11_Click(object sender, EventArgs e)
    {
        Response.Redirect("About.aspx");

    }
    protected void LinkButton12_Click(object sender, EventArgs e)
    {
        Response.Redirect("Contact.aspx");
    }
    protected void LinkButton9_Click(object sender, EventArgs e)
    {
        Response.Redirect("Change.aspx");
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Session["click"] = "Shoes";
        Response.Redirect("Belt.aspx");
    }
    protected void LinkButton15_Click(object sender, EventArgs e)
    {
        Session["click"] = "Bags";
        Response.Redirect("Belt.aspx");
    }
    protected void LinkButton16_Click(object sender, EventArgs e)
    {
        Response.Redirect("feedback.aspx");
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
}
