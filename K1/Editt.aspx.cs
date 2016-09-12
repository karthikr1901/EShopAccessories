﻿using System;
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
        SqlDataAdapter da = new SqlDataAdapter("select * from product where PicID='" + ProductID + "'", cn);
        DataTable dt = new DataTable();
        da.Fill(dt);
        txtProductID.Text = dt.Rows[0]["PicID"].ToString();
        txtName.Text = dt.Rows[0]["Name"].ToString();
        txtDesc.Text = dt.Rows[0]["Description"].ToString();
        txtPrice.Text = dt.Rows[0]["Price"].ToString();
        txtStock.Text = dt.Rows[0]["Stock"].ToString();
        txtDiscount.Text = dt.Rows[0]["Discount"].ToString();
        txtPic.Text = dt.Rows[0]["Pic"].ToString();
        txtBrand.Text = dt.Rows[0]["Brand"].ToString();

        cn.Close();
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        Save(); // to save the updated description into database
        FillGrid(); // to see the updated description in the gridview once again load the grid
        btnSubmit.Enabled = false;
        txtProductID.Text = "";
        txtName.Text = "";
        txtDesc.Text = "";
        txtPrice.Text = "";
        txtStock.Text = "";
        txtDiscount.Text = "";
        txtBrand.Text = "";
        lblErrorMessage.Text = "Product updated";
    }        
    private void Save()
    {
        string fname = FileUpload1.FileName;
        int length = FileUpload1.PostedFile.ContentLength;
        byte[] imgbyte = new byte
        System.Web.HttpPostedFile img = FileUpload1.PostedFile;
        img.InputStream.Read(imgbyte, 0, length);
        //img.SaveAs(@"E:\"+fname);\
        txtPic.Text = null;[length];
    }        
}




