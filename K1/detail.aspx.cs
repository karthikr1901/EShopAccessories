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
        TextBox2.Visible = false;
        TextBox1.Visible = false;
        TextBox1.Text = Convert.ToString(Session["prodid"]);
        TextBox2.Text = Convert.ToString(Session["K"]);
        productid = TextBox1.Text;
        userid = TextBox2.Text;


        cn.Open();

        SqlDataAdapter da = new SqlDataAdapter("select * from product where PicID = '" + TextBox1.Text + "'  ", cn);
        DataTable dt = new DataTable();
        da.Fill(dt);
        double cost = 0, discount = 0, finalprice = 0;

        Image1.ImageUrl = dt.Rows[0]["Pic"].ToString();
        Label4.Text = dt.Rows[0]["Name"].ToString();
        Label1.Text = dt.Rows[0]["Description"].ToString();
        Label5.Text = dt.Rows[0]["Brand"].ToString();

        cost = double.Parse(dt.Rows[0]["Price"].ToString());
        discount = double.Parse(dt.Rows[0]["Discount"].ToString());
        finalprice = cost - (cost * (discount / 100));

        lblCost.Text = cost.ToString();
        lblDiscount.Text = discount.ToString() + " %";
        Label3.Text = finalprice.ToString();

        //cmd.CommandText = "select * from product where PicID = '" + TextBox1.Text + "'  ";
        //cmd.Connection = cn;

        //SqlDataReader DR1 = cmd.ExecuteReader();
        //if (DR1.Read())
        //{
        //    //TextBox2.Text =
        //    Image1.ImageUrl = DR1.GetValue(7).ToString(); ;
        //    Label1.Text = DR1.GetValue(2).ToString();
        //    Label3.Text = DR1.GetValue(3).ToString();
        //    //Label3.Text = DR1.GetValue(3).ToString();
        //    Label4.Text = DR1.GetValue(1).ToString();
        //    //Label5.Text = DR1.GetValue(5).ToString();
        //    //Label6.Text = DR1.GetValue(6).ToString(); 
        //}
        cn.Close();

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