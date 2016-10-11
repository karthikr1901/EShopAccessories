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
        else if ((ctr >= 999) && (ctr < 9999))
        {
            ctr = ctr + 1;
            txtPicID.Text = "A000" + ctr;
        }
        else if ((ctr >= 9999) && (ctr < 99999))
        {
            ctr = ctr + 1;
            txtPicID.Text = "A00" + ctr;
        }
        else if ((ctr >= 99999) && (ctr < 999999))
        {
            ctr = ctr + 1;
            txtPicID.Text = "A0" + ctr;
        }
        else if (ctr >= 999999)
        {
            ctr = ctr + 1;
            txtPicID.Text = "A" + ctr;
        }
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        //if (isValidSubmit())
        //{

        //if (FileUpload1.HasFile)
        //{
            string fname = FileUpload1.FileName;
            int length = FileUpload1.PostedFile.ContentLength;
            byte[] imgbyte = new byte[length];
            System.Web.HttpPostedFile img = FileUpload1.PostedFile;
            img.InputStream.Read(imgbyte, 0, length);
            //img.SaveAs(@"E:\"+fname);\
            img.SaveAs(@TextBox1.Text + fname);
            txtUrl.Text = "~/images/" + fname;
            //btnClick.Enabled = false;
        //}

        cmd.CommandText = "Insert into Product values ('" + txtPicID.Text + "','" + txtName.Text + "','" + txtDesc.Text + "', '" + txtPrice.Text + "','" + txtStock.Text + "' , '" + ddlCategory1.SelectedItem.Text + "' , '" + txtDiscount.Text + "' , '" + txtUrl.Text + "' , '" + txtBrand.Text + "','" + ddlCategory2.SelectedValue.ToString() + "')";

        cmd.Connection = cn;

        cmd.ExecuteNonQuery();

        genpass();

        txtName.Text = "";
        txtDesc.Text = "";
        txtPrice.Text = "";
        txtStock.Text = "";
        txtDiscount.Text = "";
        txtBrand.Text = "";
        lblErrorMessage.Text = "Product updated";
        //Button2.Visible = true;

        // }
    }

    private bool isValidSubmit()
    {
        if (txtName.Text.Trim() == "")
        {
            lblErrorMessage.Text = "Please Enter Values in Textbox3";
            return false;
        }
        else if (txtDesc.Text.Trim() == "")
        {
            lblErrorMessage.Text = "Please Enter Values in Textbox4";
            return false;
        }
    }
}