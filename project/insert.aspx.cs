﻿using System;
using System.Data.OleDb;
namespace project
{
    public partial class insert : System.Web.UI.Page
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
                TextBox2.Enabled = false;
                TextBox3.Enabled = false;
                TextBox4.Enabled = false;
                TextBox5.Enabled = false;
                TextBox6.Enabled = false;
                TextBox7.Enabled = false;
                TextBox8.Enabled = false;
                TextBox9.Enabled = false;
                Response.Write("<script>alert('Please login to gain access to this page!');window.location.href='login.aspx';</script>");
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "insert into students(sname,fname,class,rno,uid,address,roomno,mess,fees) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "'," + TextBox4.Text + "," + TextBox5.Text + ",'" + TextBox6.Text + "'," + TextBox7.Text + ",'" + TextBox8.Text + "','" + TextBox9.Text + "')";
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Inserted successfully!');window.location.href='admin.aspx';</script>");
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