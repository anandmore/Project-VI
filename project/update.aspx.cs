using System;
using System.Data.OleDb;
namespace project
{
    public partial class update : System.Web.UI.Page
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
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "update students set roomno=" + TextBox2.Text + " where uid=" + TextBox1.Text;
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Updated successfully!');</script>");
                TextBox1.Text = "";
                TextBox2.Text = "";
            }
            catch (Exception ex)
            {

                Response.Write(ex);
            }
        }
    }
}