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
        TextBox9.Visible = false;
        TextBox1.Visible = false;  
        TextBox1.Text = Convert.ToString(Session["prodid"]);
        TextBox9.Text = Convert.ToString(Session["K"]);
        
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
	}
    }

}


