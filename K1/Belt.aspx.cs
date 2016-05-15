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
    protected void check()
    {
        if (Session["click"].ToString() == "Belts")
        {
            TextBox1.Text = "select * from product where category = 'Belts'";
            //da = new SqlDataAdapter("select * from product where category = 'Belts'", cn);
        }
        else if (Session["click"].ToString() == "Watches")
        {
            TextBox1.Text = "select * from product where category = 'Watches'";
            //da = new SqlDataAdapter("select * from product where category = 'Watches'", cn);
        }
        else if (Session["click"].ToString() == "Wallets")
        {
            TextBox1.Text = "select * from product where category = 'Wallets'";
            //da = new SqlDataAdapter("select * from product where category = 'Wallets'", cn);
        }
        else if (Session["click"].ToString() == "Pens")
        {
            TextBox1.Text = "select * from product where category = 'Pens'";
            //da = new SqlDataAdapter("select * from product where category = 'Pens'", cn);
        }
        else if (Session["click"].ToString() == "Sunglasses")
        {
            TextBox1.Text = "select * from product where category = 'Sunglasses'";
            //da = new SqlDataAdapter("select * from product where category = 'Sunglasses'", cn);
        }
        else if (Session["click"].ToString() == "Bags")
        {
            TextBox1.Text = "select * from product where category = 'Bags'";
            //da = new SqlDataAdapter("select * from product where category = 'Sunglasses'", cn);
        }
        else if (Session["click"].ToString() == "Shoes")
        {
            TextBox1.Text = "select * from product where category = 'Shoes'";
            //da = new SqlDataAdapter("select * from product where category = 'Sunglasses'", cn);
        }
    }
}