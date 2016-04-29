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

private void check()
    {
        //TextBox10.Text = TextBox1.Text + Label9.Text + DropDownList1.SelectedItem.Text;
        //cn.ConnectionString = "Data Source = 172.23.197.6\\sql2008; Initial Catalog = Smart Accessories Inc.; User ID = sa; Password = PASSWORD@123";
        cn.Open();


        cmd.CommandText = "select * from Customer where Email = '" + TextBox1.Text + "' and Password = '" + TextBox2.Text + "'";

        cmd.Connection = cn;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);



        if (dt.Rows.Count > 0)
        {

            Session["K"] = dt.Rows[0]["CustomerID"].ToString();
            if (dt.Rows[0]["Name"].ToString() == "Admin")
                Response.Redirect("Load.aspx");
            //Label5.Text = KeyCode;
            //Response.Redirect("Default2.aspx");
            else
            {
                Response.Redirect("Default2.aspx");
            }
        }
        else
        {
            lbl.Text = "Invalid Username or Password!";
        }
    }

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


