using System;
using System.Data.OleDb;
namespace project
{
    public partial class delete : System.Web.UI.Page
    {
        OleDbConnection con;
        OleDbCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection(@"PROVIDER=Microsoft.SQLSERVER.CE.OLEDB.3.5;" + @"Data Source=C:\Users\anandmore\Documents\admin.sdf");
            cmd = new OleDbCommand();
            int i = Convert.ToInt32(Session["session"]);
            if (i == 0)
            {
                Button1.Enabled = false;
                TextBox1.Enabled = false;
                Response.Write("<script>alert('Please login to gain access to this page!');window.location.href='login.aspx';</script>");
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "delete from students where uid="+ TextBox1.Text;
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Deleted successfully!');window.location.href='admin.aspx';</script>");
                TextBox1.Text = "";
            }
            catch (Exception a)
            {
                Response.Write(a);
            }
        }
    }
}