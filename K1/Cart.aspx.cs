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

public partial class Cart : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["myConnectionString"].ToString());
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter da;
    DataTable dt;
    SqlCommand cm = new SqlCommand();
    string productid = "", userid = "";"";
    protected void Page_Load(object sender, EventArgs e)
    {        
        if (!IsPostBack)
        {
            Button1.Visible = false;
            Label8.Visible = false;
            Label9.Visible = false;
            Label10.Visible = false;
            Label11.Visible = false;
            Label13.Visible = false;
            Label14.Visible = false;
            txtName.Visible = false;
            TextBox11.Visible = false;
            TextBox12.Visible = false;
            TextBox13.Visible = false;
            TextBox14.Visible = false;
            TextBox15.Visible = false;
            txtCVV.Visible = false;
            TextBox18.Visible = false;
            DropDownList2.Visible = false;
            DropDownList3.Visible = false;
            RadioButtonList2.Visible = false;
            FillGrid();
        }
        //TextBox10.Text = RadioButtonList1.SelectedItem.Text;

        //if (RadioButtonList1.se)
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (isValidSubmit())
        {
            productid = TextBox1.Text;
            userid = TextBox9.Text;
            cn.Open();
            da = new SqlDataAdapter("select * from cart where CustomerID='" + userid + "'", cn);
            dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                //cmd = new SqlCommand("select Price from Product where PicID='" + productid + "'", cn);
                //double amt = double.Parse(cmd.ExecuteScalar().ToString());
                //double finalamt = amt * int.Parse(row["count"].ToString());
                //cmd = new SqlCommand("insert into Purchase (CustomerID,PicID,Count,Price,Date) values('" + userid + "','" + row["productid"].ToString() + "','" + row["count"].ToString() + "','" + finalamt + "','" + System.DateTime.Now.ToString("yyyy-MMM-dd hh:mm:ss tt") + "')", cn);
                cmd = new SqlCommand("insert into Purchase (CustomerID,PicID,Name,Price,Date) values('" + row[2].ToString() + "','" + row[1].ToString() + "','" + row[5].ToString() + "','" + row[3].ToString() + "','" + System.DateTime.Now.ToString("yyyy-MMM-dd hh:mm:ss tt") + "')", cn);
                cmd.ExecuteNonQuery();
            }
	}
    }

}


