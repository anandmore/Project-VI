using System;
using System.Data.OleDb;
namespace project
{
    public partial class login : System.Web.UI.Page
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection(@"PROVIDER=Microsoft.SQLSERVER.CE.OLEDB.3.5;" + @"Data Source=C:\Users\anandmore\Documents\admin.sdf");
            cmd = new OleDbCommand();            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "select COUNT(*) from info where uname='"+TextBox1.Text+"'and passwd='"+TextBox2.Text+"'";
                cmd.Connection = con;
                con.Open();
                dr=cmd.ExecuteReader();
                dr.Read();
                int i = dr.GetInt32(0);
                con.Close();
                if (i == 1)
                {
                    Session["session"] = 1;
                    Response.Redirect("admin.aspx");
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex);

            }
        }
    }
}