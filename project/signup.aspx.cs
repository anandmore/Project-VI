using System;
using System.Data.OleDb;
namespace project
{
    public partial class signup : System.Web.UI.Page
    {
        OleDbConnection con;
        OleDbCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection(@"PROVIDER=Microsoft.SQLSERVER.CE.OLEDB.3.5;" + @"Data Source=C:\Users\anandmore\Documents\admin.sdf");
            cmd = new OleDbCommand();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox3.Text != TextBox4.Text)
                Response.Write("<script>alert('Passwords do not match!');</script>");
            try
            {
                cmd.CommandText = "insert into info(aname,uname,passwd,uid,address,age,email,cno) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "'," + TextBox5.Text + ",'" + TextBox6.Text + "'," + TextBox7.Text + ",'" + TextBox8.Text + "','" + TextBox9.Text + "')";
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Registered successfully! Go back and login.');window.location.href='login.aspx';</script>");
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
                TextBox8.Text = "";
                TextBox9.Text = "";
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }
    }
}