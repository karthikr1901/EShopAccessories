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

public partial class feedback : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["myConnectionString"].ToString());
    SqlCommand cmd = new SqlCommand();
    SqlCommand cm = new SqlCommand();
    SqlCommand cmdd = new SqlCommand();
    SqlDataAdapter ad = new SqlDataAdapter();
    DataTable dataTable = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        if ((string)Session["K"] == "10")
        {
            Label1.Visible = false;
            Label2.Visible = false;            
            Label4.Visible = false;
            TextBox1.Visible = false;
            TextBox2.Visible = false;
            Button1.Visible = false;
            if (!IsPostBack)
            {
                fillgrid();
            }
        }
        else
        {
            Panel1.Visible = false;
            gvUsers.Visible = false;
        }
    }
    protected void fillgrid()
    {
        cn.Open();
        cmd.CommandText = "SELECT * from feedback";
        cmd.Connection = cn;
        ad = new SqlDataAdapter(cmd);
        ad.Fill(dataTable);
        gvUsers.DataSource = dataTable;
        gvUsers.DataBind();
        cn.Close();
    }

    private bool isValid()
    {
        if (TextBox2.Text.Trim() == "")
        {
            Label3.Text = "Please enter Email";
            return false;
        }
        if (TextBox1.Text.Trim() == "")
        {
            Label3.Text = "Please enter feedback";
            return false;
        }
        Label3.Text = "";
        return true;
    }
    
}
