using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Blogum.DAL;
using Blogum.BLL.Repository;

namespace Blogum.WebUI.AdminPanel.Work
{
    public partial class WorkList : System.Web.UI.Page
    {
        WorkRepository wr = new WorkRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["adminSession"] == null)
            {
                Response.Redirect("../Dashboard.aspx");
            }
            if (IsPostBack) return;  
            GetProject();
        }

        protected void rptProject_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "delete":
                    wr.Delete(Convert.ToInt32(e.CommandArgument));
                    GetProject();
                    break;
                case "update":
                Response.Redirect(string.Format("~/AdminPanel/Work/WorkUpdate.aspx?ProjeId={0}", e.CommandArgument));
                    break;
              
            }
        }


        private void GetProject()
        {
            rptProject.DataSource = wr.SelectAll().Select(a =>new
              {
                  a.ProjeId,
                  a.ProjeAbout,
                  a.ProjeLanguage,
                  a.Title,
                  a.ProjeImage
              });
            rptProject.DataBind();
        }
    }
}