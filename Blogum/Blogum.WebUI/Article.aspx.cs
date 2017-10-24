using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Blogum.DAL;
using Blogum.BLL.Repository;
namespace Blogum.WebUI
{
    public partial class Article : System.Web.UI.Page
    {
        AdminRepository adr = new AdminRepository();
        ArticleRepository ar = new ArticleRepository();
      
        protected void Page_Load(object sender, EventArgs e)
        {

            //GetAdmin();
            GetArticle();
            CategoryArticle();
        }

        private void GetArticle()
        {
            rptArticle.DataSource = ar.SelectAll().Select(a => new
            {
                a.ArticleId,
                a.ArticleTitle,
                a.CreatedDate,
                a.ArticleContent,
                a.ArticleImage,
                a.VideoLink,
                a.ArticleAdminId

             
            }).Where(a => a.ArticleId == Convert.ToInt32(Request.QueryString["ArticleId"]));
            rptArticle.DataBind();
        }

        private void GetAdmin()
        {
            //rptAdmin.DataSource = adr.SelectAll();
            //rptAdmin.DataBind();

        }

        private void CategoryArticle()
        {
            rpSummary.DataSource = ar.SelectAll().Select(a => new
            {
                a.ArticleId,
                a.ArticleTitle,
                a.ArticleSummary,
                a.CreatedDate,
                a.CatId,
                a.ArticleAdminId
            }).Where(a => a.CatId == Convert.ToInt32(Request.QueryString["CatId"]));
            rpSummary.DataBind();
        }

       
    }
}