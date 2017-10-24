using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Blogum.DAL;
using Blogum.BLL.Repository;

namespace Blogum.WebUI.AdminPanel
{
    public partial class Dashboard : System.Web.UI.Page
    {
        AdminRepository adr = new AdminRepository();
        BlogumDBEntities db = new BlogumDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            if (Response.Cookies["UserName"] != null && Response.Cookies["Password"] != null)
            {
                //txtUserName.Text = Response.Cookies["UserName"].Value;
                //txtPassword.Text = Response.Cookies["Password"].Value;
            }

        }
       
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var context = new BlogumDBEntities();
            foreach (var user in context.Admin)
            {
                if (user.UserName==txtUserName.Text&& user.Password==txtPassword.Text)
                {
                    Session["adminSession"] = txtUserName.Text;
                    Session.Timeout = 30;
                    Response.Redirect("~/AdminPanel/Article/ArticleList.aspx");

                }
                else
                {
                    txtUserName.Text = "";
                    txtPassword.Text = "";
                }
            }
          
      
        }
    }
}