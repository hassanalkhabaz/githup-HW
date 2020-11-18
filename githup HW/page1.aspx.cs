using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace githup_HW
{
    public partial class page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("page2.aspx?name=" + TextBox1.Text);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            Response.Redirect("page2.aspx?UserName=" + Server.UrlEncode(TextBox1.Text) + "&UserEmail=" + Server.UrlEncode(TextBox2.Text));
            HttpCookie cookie = new HttpCookie("UserInfo");
            cookie["Name"] = TextBox1.Text;
            cookie["Email"] = TextBox2.Text;
            cookie.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(cookie);
            Response.Redirect("page2.aspx");
            Session["Name"] = TextBox1.Text;
            Session["Email"] = TextBox2.Text;
            Response.Redirect("page2.aspx");
            Application["Name"] = TextBox1.Text;
            Application["Email"] = TextBox2.Text;
            Response.Redirect("page2.aspx");
        }
    }
}