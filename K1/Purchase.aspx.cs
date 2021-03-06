﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

public partial class Purchase : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["myConnectionString"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ViewState["ID"] = Request.QueryString["ID"];
            if (ViewState["ID"] != null && ViewState["ID"].ToString() != "")
            {
                lblHead.Text = "Purchase History for " + GetName();
            }
            else
            {
                lblHead.Text = "Purchase History";
            }
            LoadPurchase();
        }
    }
    private string GetName()
    {
        conn.Open();
        SqlCommand cmd = new SqlCommand("select Name from Customer where CustomerID='" + ViewState["ID"].ToString() + "'", conn);
        string strName = cmd.ExecuteScalar().ToString();
        conn.Close();
        return strName;
    }
    private void LoadPurchase()
    {
        SqlDataAdapter da;
        conn.Open();
        if (ViewState["ID"] != null && ViewState["ID"].ToString() != "")
        {
            da = new SqlDataAdapter("select * from Purchase where CustomerID='" + ViewState["ID"].ToString() + "'", conn);
        }
        else
        {
            da = new SqlDataAdapter("select * from Purchase", conn);
        }
        DataTable dt = new DataTable();
        da.Fill(dt);
        gvPurchase.DataSource = dt;
        gvPurchase.DataBind();

        double p = 0;

        foreach (DataRow row in dt.Rows)
        {
            p += double.Parse(row["Price"].ToString());
        }
        lblTotalPrice.Text = "Total Price "+p.ToString();
        lblTotalItems.Text = "Total Items " + dt.Rows.Count.ToString();
    }
}