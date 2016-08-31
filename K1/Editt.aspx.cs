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
}




