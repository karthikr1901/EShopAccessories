using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class Editt : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["myConnectionString"].ToString());
    SqlCommand cmd23 = new SqlCommand();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillGrid();
        }
    }
    private void FillGrid()
    {
        cn.Open();
        SqlDataAdapter da = new SqlDataAdapter("select * from product", cn);
        DataTable dt = new DataTable();
        da.Fill(dt);
        gvTest.DataSource = dt;
        gvTest.DataBind();
        cn.Close();
    }
    protected void lblNo_Click(object sender, EventArgs e)
    {
        LinkButton lbl = new LinkButton();
        lbl = (LinkButton)sender;
        //char[] t = lbl.Text.ToCharArray();
        //if (t[0] == 'A')
        //    Response.Write("Hi");
        //else Response.Write("hello");

        //lbl is the clicked link button
        //lbl.Text is the clicked product id
        FillDetails(lbl.Text);
        Session["lbl"] = lbl.Text;
        btnSubmit.Enabled = true;

    }
    private void FillDetails(string ProductID)
    {
        cn.Open();
        SqlDataAdapter da = new SqlDataAdapter("select * from product where PicID='" + ProductID + "'"
        DataTable dt = new DataTable();
        da.Fill(dt);
        txtProductID.Text = dt.Rows[0]["PicID"].ToString();
        txtName.Text = dt.Rows[0]["Name"].ToString();
        txtDesc.Text = dt.Rows[0]["Description"].ToString();
        txtPrice.Text = dt.Rows[0]["Price"].ToString();
        txtStock.Text = dt.Rows[0]["Stock"].ToString();
        txtDiscount.Text = dt.Rows[0]["Discount"].ToString();
    }
}




