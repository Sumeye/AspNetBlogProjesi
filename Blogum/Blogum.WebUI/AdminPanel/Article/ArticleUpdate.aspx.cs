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
    public partial class ArticleUpdate : System.Web.UI.Page
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
            CategoryFiil();
        }

        private void Articlefill()
        {
            if (Request.QueryString["ArticleId"] !=null)
            {
                Articles updated = ar.SelectById(Convert.ToInt32(Request.QueryString["ArticleId"]));
                txtBaslik.Text = updated.ArticleTitle;
                txtCreatedDate.Text =updated.CreatedDate.Value.ToString("yyyy-MM-dd");
                txtMessage.Text = updated.ArticleContent;
                TxtSummary.Text = updated.ArticleSummary;
                //ddlCat.SelectedValue = updated.Categories.CategoryName;
            }  
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            Articles Updated =ar.SelectById(Convert.ToInt32(Request.QueryString["ArticleId"]));
            Updated.ArticleTitle = txtBaslik.Text;
            Updated.ArticleContent = txtMessage.Text;
            Updated.CreatedDate = (Convert.ToDateTime(txtCreatedDate.Text));
            Updated.CatId = Convert.ToInt32(ddlCat.SelectedValue);
            Updated.ArticleSummary = TxtSummary.Text;
            ar.Update(Updated);
            Response.Redirect("~/AdminPanel/Article/ArticleList.aspx");
        }

        private void CategoryFiil()
        {
            CategoryRepository cr = new CategoryRepository();
            ddlCat.DataSource = cr.SelectAll();
            ddlCat.DataTextField = "CategoryName";
            ddlCat.DataValueField = "CatId";
            ddlCat.DataBind();
        }

        protected void btnGeriDon_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AdminPanel/Article/ArticleList.aspx");
        }
    }
}