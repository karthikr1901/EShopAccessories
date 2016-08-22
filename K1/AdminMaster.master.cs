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
public partial class AdminMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        cn.Open();
        if (Session["K"] != null)
        {
            LinkButton1.Text = LinkButton10.Text = "Logout";
            SqlCommand cmd = new SqlCommand("select count(*) from cart where CustomerID='" + Session["K"].ToString() + "'", cn);
            int x = int.Parse(cmd.ExecuteScalar().ToString());
            LinkButton8.Text = Convert.ToString(x);
            cn.Close();
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
        DataTable dt2 = new DataTable();
        da2.Fill(dt2);

        Image1.ImageUrl = dt2.Rows[0]["Pic"].ToString();
        Image2.ImageUrl = dt.Rows[0]["Pic"].ToString();
        Image3.ImageUrl = dt1.Rows[0]["Pic"].ToString();
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Load.aspx");
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("Load.aspx");
    }
    protected void LinkButton14_Click(object sender, EventArgs e)
    {
        Response.Redirect("Users.aspx");
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
    protected void LinkButton8_Click1(object sender, EventArgs e)
    {

    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("Editt.aspx");
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Response.Redirect("Purchase.aspx");
    }
    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        Response.Redirect("OffersImage.aspx");
    }
}
