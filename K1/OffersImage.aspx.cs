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
    protected void btnUpload_Click(object sender, EventArgs e)
    {
        string fname = FileUpload1.FileName;
        int length = FileUpload1.PostedFile.ContentLength;
        byte[] imgbyte = new byte[length];
        System.Web.HttpPostedFile img = FileUpload1.PostedFile;
        img.InputStream.Read(imgbyte, 0, length);
        //img.SaveAs(@"E:\"+fname);\
        txtPic.Text = null;
    }
}