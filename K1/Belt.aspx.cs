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

            try
            {
                imgbtn1.ImageUrl = dt.Rows[x]["Pic"].ToString();
                imgbtn1.Height = 250; imgbtn1.Width = 200;
                tc1.Controls.Add(imgbtn1);
                imgbtn1.ID = dt.Rows[x]["PicID"].ToString();
               // imgbtn1.Click += new ImageClickEventHandler(imgbtn_Click);
                imgbtn1.Click += new ImageClickEventHandler(imgbtn_Click);
                //tc1.Controls.Add(imgbtn1);

            }
            catch { }
            try
            {
                imgbtn2.ImageUrl = dt.Rows[x + 1]["Pic"].ToString();
                imgbtn2.Height = 250; imgbtn2.Width = 200;
                tc2.Controls.Add(imgbtn2);              
                imgbtn2.ID = dt.Rows[x + 1]["PicID"].ToString();
                //imgbtn2.Click += new ImageClickEventHandler(imgbtn_Click);
                imgbtn2.Click += new ImageClickEventHandler(imgbtn_Click);
                //tc2.Controls.Add(imgbtn2);

            }
            catch { }
            try
            {
                imgbtn3.ImageUrl = dt.Rows[x + 2]["Pic"].ToString();
                imgbtn3.Height = 250; imgbtn3.Width = 200;
                tc3.Controls.Add(imgbtn3);              
                imgbtn3.ID = dt.Rows[x + 2]["PicID"].ToString();
                //imgbtn3.Click += new ImageClickEventHandler(imgbtn_Click);
                imgbtn3.Click += new ImageClickEventHandler(imgbtn_Click);
                //tc3.Controls.Add(imgbtn3);

            }
            catch { }

            tr.Cells.Add(tc3);
            tr.Cells.Add(tc2);            
            tr.Cells.Add(tc1);

            t.Rows.Add(tr);

            x = x - 3;

        }
        Panel1.Controls.Add(t);


    }

    protected void imgbtn_Click(object sender, ImageClickEventArgs e)
    {
        ImageButton imgbt = (ImageButton)sender;
        Session["prodid"] = imgbt.ID;
        Response.Redirect("detail.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        check();
        if (CheckBox1.Checked == true || CheckBox2.Checked == true || CheckBox3.Checked == true)
        {
            TextBox1.Text = TextBox1.Text + " and (";
            if (CheckBox1.Checked == true)
            {
                TextBox1.Text = TextBox1.Text + "category1 = 'M'";
                if (CheckBox2.Checked == true || CheckBox3.Checked == true)
                    TextBox1.Text = TextBox1.Text + " or ";
            }

            if (CheckBox2.Checked == true)
            {
                TextBox1.Text = TextBox1.Text + "category1 = 'W'";
                if (CheckBox3.Checked == true)
                    TextBox1.Text = TextBox1.Text + " or ";
            }

            if (CheckBox3.Checked == true)
                TextBox1.Text = TextBox1.Text + "category1 = 'K'";
            TextBox1.Text = TextBox1.Text + ")";
        }
              
    }
}


