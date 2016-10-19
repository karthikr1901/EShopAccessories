using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class OffersImage : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["myConnectionString"].ToString());

    protected void Page_Load(object sender, EventArgs e)
    {

    }
}