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

    protected void Disp()
    {
        Panel1.Controls.Clear();
        da = new SqlDataAdapter(TextBox1.Text, cn);
        DataTable dt = new DataTable();
        da.Fill(dt);
        int rows = dt.Rows.Count;


        if (rows % 3 != 0)
            a = (rows / 3) + 1;
        else a = (rows / 3);

        Table t = new Table();

        int x = dt.Rows.Count;
        while (x + 2 >= 0)
        {
            TableRow tr = new TableRow();

            TableCell tc1 = new TableCell();
            TableCell tc2 = new TableCell();
            TableCell tc3 = new TableCell();
            tc1.Attributes.Add("align", "center");
            tc2.Attributes.Add("align", "center");
            tc3.Attributes.Add("align", "center");


            ImageButton imgbtn1 = new ImageButton();
            ImageButton imgbtn2 = new ImageButton();
            ImageButton imgbtn3 = new ImageButton();
	}

    }

}