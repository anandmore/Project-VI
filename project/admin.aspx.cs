using System;
namespace project
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(Session["session"]);
            if (i == 0)
            {
                Button1.Enabled = false;
                Button2.Enabled = false;
                Button3.Enabled = false;
                Button4.Enabled = false;
                Button5.Enabled = false;
            }
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            Session["session"] = 0;
            Response.Redirect("login.aspx");
        }
    }
}