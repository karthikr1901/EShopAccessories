using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Web.Configuration;
using System.IO;


public partial class Load : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["myConnectionString"].ToString());
    SqlCommand cmd = new SqlCommand();

    DataRow dr;
    string code;

    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Enabled = false;
        TextBox1.Visible = false;
        txtUrl.Enabled = false;
        txtUrl.Visible = false;
        genpass();
        TextBox1.Text = HttpRuntime.AppDomainAppPath;
        TextBox1.Text = TextBox1.Text + "images\\";
    }

    protected void genpass()
    {
        cn.Open();
        SqlDataAdapter da = new SqlDataAdapter("select * from  Product ", cn);
        DataTable dt = new DataTable();
        da.Fill(dt);

        int ctr, len;
        string codeval;

        len = dt.Rows.Count - 1;
        dr = dt.Rows[len];
        code = dr["PicID"].ToString();
        codeval = code.Substring(1, 7);
        ctr = Convert.ToInt32(codeval);
        if ((ctr >= 1) && (ctr < 9))
        {
            ctr = ctr + 1;
            txtPicID.Text = "A000000" + ctr;
        }
        else if ((ctr >= 9) && (ctr < 99))
        {
            ctr = ctr + 1;
            txtPicID.Text = "A00000" + ctr;
        }
        else if ((ctr >= 99) && (ctr < 999))
        {
            ctr = ctr + 1;
            txtPicID.Text = "A0000" + ctr;
        }
    }
}