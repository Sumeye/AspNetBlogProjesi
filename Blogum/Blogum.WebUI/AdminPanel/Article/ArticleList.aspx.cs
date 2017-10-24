using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Blogum.DAL;
using Blogum.BLL.Repository;

namespace Blogum.WebUI.AdminPanel.Article
{
    public partial class ArticleList : System.Web.UI.Page
    {
        ArticleRepository ar = new ArticleRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["adminSession"] == null)
            {
                Response.Redirect("../Dashboard.aspx");
            }
            if (IsPostBack) return;
            Articlefill();
        }

        private void Articlefill()
        {
            rptMakaleler.DataSource = ar.SelectAll().Select(a => new
            {
              a.ArticleId,
              a.ArticleContent,
              a.CreatedDate,
              a.ArticleTitle,
              a.Categories.CategoryName,
              a.ArticleSummary,
              a.ArticleAdminId
              
            });
            rptMakaleler.DataBind();
        }

        protected void rptMakaleler_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            switch(e.CommandName)
           {
                case "delete":
                    ar.Delete(Convert.ToInt32(e.CommandArgument));
                    Articlefill();
                    break;
                case "update":
                    Response.Redirect(string.Format("~/AdminPanel/Article/ArticleUpdate.aspx?ArticleId={0}",e.CommandArgument));
                    break;

            }
        }
    }
}