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


public partial class Signup : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["myConnectionString"].ToString());
    SqlCommand cmd = new SqlCommand();
    SqlCommand cm = new SqlCommand();
    DataRow dr;
    string code;

    protected void Page_Load(object sender, EventArgs e)
    {
        btnOK.Visible = false;
        Label9.Visible = false;
        Label8.Visible = false;


        //TextBox9.Visible = false;
        //TextBox9.Enabled = false;

        //TextBox7.Visible = false;
        //TextBox7.Enabled = false;

        genpass();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //TextBox9.Text = TextBox6.Text + Label9.Text + DropDownList1.SelectedItem.Text;
        if (check())
        {
            if (isValidSubmit())
            {
                cn.Open();
                cmd.CommandText = "Insert into Customer values ('" + txtName.Text + "','" + txtAddress.Text + "','" + txtCity.Text + "', '" + txtMobile.Text + "','" + Label9.Text + "' , '" + txtEmail.Text + "')";
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                txtName.Enabled = false;
                txtAddress.Enabled = false;
                txtCity.Enabled = false;
                txtMobile.Enabled = false;
                txtEmail.Enabled = false;
                btnSubmit.Enabled = false;
                lblErrorMessage.Text = "Account created successfully";
                Label9.Visible = true;
                Label8.Visible = true;
                btnOK.Visible = true;
            }

            //NetworkCredential loginInfo = new NetworkCredential("smsmarartt@gmail.com", "ttraramsms"); // give your email id and password here.. 
            //MailMessage msg = new MailMessage();
            //msg.From = new MailAddress(TextBox8.Text);
            //msg.To.Add(new MailAddress(TextBox6.Text));
            //msg.Subject = "Password for the account you have created";
            //msg.Body = "Your Password: " + TextBox7.Text;
            //msg.IsBodyHtml = true;
            //SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            //client.EnableSsl = true;
            //client.UseDefaultCredentials = false;
            //client.Credentials = loginInfo;
            //client.Send(msg);
            cn.Close();
            //}
        }
    }

    private void genpass()
    {
        //cn.ConnectionString = "Data Source = 172.23.197.6\\sql2008; Initial Catalog = Smart Accessories Inc.; User ID = sa; Password = PASSWORD@123";
        cn.Open();
        SqlDataAdapter da = new SqlDataAdapter("select * from  Customer ", cn);
        DataTable dt = new DataTable();
        da.Fill(dt);

        int ctr, len;
        //string codeval;

        len = dt.Rows.Count - 1;
        dr = dt.Rows[len];
        code = dr["CustomerID"].ToString();
        //codeval = code.Substring(1, 6);
        //ctr = Convert.ToInt32(codeval);
        ctr = Convert.ToInt32(code);
        if ((ctr >= 1) && (ctr < 9))
        {
            ctr = ctr + 1;
            Label9.Text = "P00000" + ctr;
        }
        else if ((ctr >= 9) && (ctr < 99))
        {
            ctr = ctr + 1;
            Label9.Text = "P0000" + ctr;
        }
        else if ((ctr >= 99) && (ctr < 999))
        {
            ctr = ctr + 1;
            Label9.Text = "P000" + ctr;
        }
        else if ((ctr >= 999) && (ctr < 9999))
        {
            ctr = ctr + 1;
            Label9.Text = "P00" + ctr;
        }
        else if ((ctr >= 9999) && (ctr < 99999))
        {
            ctr = ctr + 1;
            Label9.Text = "P0" + ctr;
        }
        else if (ctr >= 99999)
        {
            ctr = ctr + 1;
            Label9.Text = "P" + ctr;
        }
        cn.Close();
    }
    private bool check()
    {
        cn.Open();
        cm.CommandText = "select * from Customer where Email = '" + txtEmail.Text + "'";
        cm.Connection = cn;
        SqlDataReader DR2 = cm.ExecuteReader();
        if (DR2.Read())
        {
            lblErrorMessage.Text = "Email ID already exists!!!";
            return false;
        }
        cn.Close();

        return true;

    }
}





