using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace githup_HW
{
    public partial class page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["UserInfo"];
            if (cookie != null)
            {
                Label1.Text = cookie["Name"];
                Label2.Text = cookie["Email"];

            }
            if (Session["Name"] != null)
            {
                Label1.Text = Session["Name"].ToString();
            }

            if (Session["Email"] != null)
            {
                Label2.Text = Session["Email"].ToString();
            }
            if (Application["name"] != null)
                Label1.Text = Application["Name"].ToString();
            if (Application["Email"] != null)
                Label2.Text = Application["Email"].ToString();


            string name = Request.QueryString.Get("name");
            Response.Write(name);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ViewState["FirstName"] = TextBox2.Text;
            ViewState["LastName"] = TextBox3.Text;
            TextBox2.Text = "";
            TextBox3.Text = "";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox2.Text = ViewState["FirstName"].ToString();
            TextBox3.Text = ViewState["LastName"].ToString();
        }
    }
}