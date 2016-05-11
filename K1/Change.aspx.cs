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

public partial class Change : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["myConnectionString"].ToString());
    SqlCommand cmd = new SqlCommand();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        check();
    }
    private void check()
    {
        cn.Open();
        cmd.CommandText = "select * from Customer where Email = '" + txtEmail.Text + "' and Password = '" + TextBox3.Text + "' and Phone = '" + txtMobile.Text + "'";
        cmd.Connection = cn;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            if(TextBox4.Text == TextBox5.Text)
            {
                SqlCommand cm = new SqlCommand("update Customer set Password ='" + TextBox4.Text + "' where Email ='" + txtEmail.Text + "' and Phone = '" + txtMobile.Text + "'");
                cm.Connection = cn;
                cm.ExecuteNonQuery();
                Label7.Text = "Password changed!!!!";
            }
            else
                Label7.Text = "Both New Password and Confirm Password are not matching!!!!";
        }
        else
            Label7.Text = "Wrong entry!!!!";            
    }
}
    