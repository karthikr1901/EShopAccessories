using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Web.Configuration;


public partial class Password : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection(WebConfigurationManager.ConnectionStrings["myConnectionString"].ToString());
    SqlCommand cmd = new SqlCommand();

    private void check()
    {
        //cn.ConnectionString = "Data Source = 172.23.197.6\\sql2008; Initial Catalog = Smart Accessories Inc.; User ID = sa; Password = PASSWORD@123";
        cn.Open();


        cmd.CommandText = "select * from Customer where Email = '" + txtEmail.Text + "'and Phone = '" + txtMobile.Text + "'";
        cmd.Connection = cn;
        SqlDataReader DR2 = cmd.ExecuteReader();

        if (DR2.Read())
        {
            Label5.Text = "Your password is :" + DR2.GetValue(5).ToString();




           
            //NetworkCredential loginInfo = new NetworkCredential("smsmarartt@gmail.com", "ttraramsms"); // give your email id and password here.. 
            //MailMessage msg = new MailMessage();
            //msg.From = new MailAddress(TextBox4.Text);
            //msg.To.Add(new MailAddress(TextBox1.Text));
            //msg.Subject = TextBox2.Text;
            //msg.Body = Label5.Text;
            //msg.IsBodyHtml = true;
            //SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            //client.EnableSsl = true;
            //client.UseDefaultCredentials = false;
            //client.Credentials = loginInfo;
            //client.Send(msg);
            //Response.Write("Password has been sent to your email");
        }
        else
        {
            Label5.Text = "Invalid Email ID or Phone Number!!!";
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox2.Visible = false;
        TextBox2.Enabled = false;
        TextBox4.Visible = false;
        TextBox4.Enabled = false;

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        check();
    }
}