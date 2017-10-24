using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blogum.WebUI.AdminPanel
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["adminSession"] != null)
                lblSession.Text = Session["adminSession"].ToString();
                //Session1.Text = Session["adminSession"].ToString();
        }
        protected void lbSessionOut_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/AdminPanel/Dashboard.aspx");
        }
    }
}