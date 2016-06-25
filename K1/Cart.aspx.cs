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

public partial class Cart : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["myConnectionString"].ToString());
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter da;
    DataTable dt;
    SqlCommand cm = new SqlCommand();
    string productid = "", userid = "";"";
    protected void Page_Load(object sender, EventArgs e)
    {        
        TextBox9.Visible = false;
        TextBox1.Visible = false;  
        TextBox1.Text = Convert.ToString(Session["prodid"]);
        TextBox9.Text = Convert.ToString(Session["K"]);
        

        if (!IsPostBack)
        {
            Button1.Visible = false;
            Label8.Visible = false;
            Label9.Visible = false;
            Label10.Visible = false;
            Label11.Visible = false;
            Label13.Visible = false;
            Label14.Visible = false;
            txtName.Visible = false;
            TextBox11.Visible = false;
            TextBox12.Visible = false;
            TextBox13.Visible = false;
            TextBox14.Visible = false;
            TextBox15.Visible = false;
            txtCVV.Visible = false;
            TextBox18.Visible = false;
            DropDownList2.Visible = false;
            DropDownList3.Visible = false;
            RadioButtonList2.Visible = false;
            FillGrid();
        }
        //TextBox10.Text = RadioButtonList1.SelectedItem.Text;

        //if (RadioButtonList1.se)
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (isValidSubmit())
        {
            productid = TextBox1.Text;
            userid = TextBox9.Text;
            cn.Open();
            da = new SqlDataAdapter("select * from cart where CustomerID='" + userid + "'", cn);
            dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                //cmd = new SqlCommand("select Price from Product where PicID='" + productid + "'", cn);
                //double amt = double.Parse(cmd.ExecuteScalar().ToString());
                //double finalamt = amt * int.Parse(row["count"].ToString());
                //cmd = new SqlCommand("insert into Purchase (CustomerID,PicID,Count,Price,Date) values('" + userid + "','" + row["productid"].ToString() + "','" + row["count"].ToString() + "','" + finalamt + "','" + System.DateTime.Now.ToString("yyyy-MMM-dd hh:mm:ss tt") + "')", cn);
                cmd = new SqlCommand("insert into Purchase (CustomerID,PicID,Name,Price,Date) values('" + row[2].ToString() + "','" + row[1].ToString() + "','" + row[5].ToString() + "','" + row[3].ToString() + "','" + System.DateTime.Now.ToString("yyyy-MMM-dd hh:mm:ss tt") + "')", cn);
                cmd.ExecuteNonQuery();
                //after inserting the product into history table, delete that product from cart table
                cmd = new SqlCommand("delete from Cart where CustomerID='" + row[2].ToString() + "' and PicID='" + row[1].ToString() + "'", cn);
                cmd.ExecuteNonQuery();
                lblErrorMessage.Text = "You have purchased your products!!!! Will be delivered within 3-5 working days";
            }
            cn.Close();
        }
        FillGrid();
    }

    private void FillGrid()
    {
        cn.Open();
        da = new SqlDataAdapter("select * from Cart", cn);
        dt = new DataTable();
        da.Fill(dt);
        gvTest.DataSource = dt;
        gvTest.DataBind();
        cm = new SqlCommand("select Sum(Price) As Total from Cart where CustomerID ='" + TextBox9.Text + "'", cn);
        Label2.Text = Convert.ToString(cm.ExecuteScalar());
        //da1 = new SqlDataAdapter("select Sum(Price) As Total from Cart where CustomerID ='" + TextBox2.Text + "'", cn);
        //dt1 = new DataTable();
        //da.Fill(dt);        
        //Label2.Text = dt1.Rows[0].ToString();
        cn.Close();
    }

    protected void imgDelte_Click(object sender, EventArgs e)
    {
        // Get the Clicked Imagebutton
        ImageButton imgbtn = new ImageButton();
        imgbtn = (ImageButton)sender;

        //get the Clicked imagebutton's row
        GridViewRow row = (GridViewRow)imgbtn.Parent.Parent;

        Label lblRandom = new Label();
        lblRandom = (Label)row.FindControl("lblRandom");
        //random number will be in the second cell, get the clicked row's randomnumber
        string strRandomNo = lblRandom.Text;
        //delete the particular record
        Delete(strRandomNo);
        //fill the grid again to reflect 
        FillGrid();
    }
    private void Delete(string RandomNo)
    {
        cn.Open();
        cmd = new SqlCommand("delete from Cart where Random ='" + RandomNo + "'", cn);
        cmd.ExecuteNonQuery();
        cn.Close();
    }
    protected void lblNo_Click(object sender, EventArgs e)
    {
        LinkButton lbl = new LinkButton();
        lbl = (LinkButton)sender;
        Session["prodid"] = lbl.Text;
        Response.Redirect("detail.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedItem.Text == "Net Banking")
        {
            Button1.Visible = true;
            Label8.Visible = true;
            Label14.Visible = true;
            txtName.Visible = true;
            TextBox18.Visible = true;            
            Label9.Visible = false;
            Label10.Visible = false;
            Label11.Visible = false;
            Label13.Visible = false;
            TextBox11.Visible = false;
            TextBox12.Visible = false;
            TextBox13.Visible = false;
            TextBox14.Visible = false;
            TextBox15.Visible = false;
            txtCVV.Visible = false;
            DropDownList2.Visible = false;
            DropDownList3.Visible = false;
            RadioButtonList2.Visible = false;
        }
        else
        {
            Button1.Visible = true;
            Label8.Visible = true;
            Label9.Visible = true;
            Label10.Visible = true;
            Label11.Visible = true;
            Label13.Visible = true;
            Label14.Visible = true;
            txtName.Visible = true;
            TextBox11.Visible = true;
            TextBox12.Visible = true;
            TextBox13.Visible = true;
            TextBox14.Visible = true;
            txtCVV.Visible = true;
            TextBox18.Visible = true;
            DropDownList2.Visible = true;
            DropDownList3.Visible = true;
            RadioButtonList2.Visible = true;
        }

    }

}


