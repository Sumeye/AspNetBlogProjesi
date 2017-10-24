using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Blogum.DAL;
using Blogum.BLL.Repository;
using System.IO;

namespace Blogum.WebUI.AdminPanel.Article
{
    public partial class ArticleAdd : System.Web.UI.Page
    {
        ArticleRepository ar = new ArticleRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["adminSession"] == null)
            {
                Response.Redirect("../Dashboard.aspx");
            }
            if (IsPostBack) return;
            CategoryFiil();
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            string durum = "";
            if (fuImage.HasFile)
            {
                FileInfo imgInfo = new FileInfo(fuImage.FileName);//dosya adı alındı
                string newimg = Guid.NewGuid().ToString() + imgInfo.Extension;//resme yeni ad verildi. guid unic bir sayı belirler
                if (newimg != null)
                {
                    fuImage.SaveAs(Server.MapPath("~/images/portfolio/") + newimg);
                    durum = "/images/portfolio/" + newimg;
                }
            }
            if (durum == "")
            {
                durum = "/images/portfolio/bosresim.jfif";
            }
            ar.Insert(new Articles
            {
                ArticleTitle = txtBaslik.Text,
                ArticleContent = txtMessage.Text,
                CreatedDate = Convert.ToDateTime(txtCreatedDate.Text),
                ArticleSummary = TxtSummary.Text,
                VideoLink=txtVideoLink.Text,
                ArticleImage=durum,
               ArticleAdminId = Convert.ToInt32(Session["adminSession"]),
                CatId = Convert.ToInt32(ddlKategori.SelectedValue)
                
            });
             Response.Redirect("~/AdminPanel/Article/ArticleList.aspx");

        }


        private void CategoryFiil()
        {
            CategoryRepository cr = new CategoryRepository();
            ddlKategori.DataSource = cr.SelectAll();
            ddlKategori.DataTextField = "CategoryName";
            ddlKategori.DataValueField = "CatId";
            ddlKategori.DataBind();
        }

        protected void btnGeriDon_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AdminPanel/Article/ArticleList.aspx");
        }
    }
}