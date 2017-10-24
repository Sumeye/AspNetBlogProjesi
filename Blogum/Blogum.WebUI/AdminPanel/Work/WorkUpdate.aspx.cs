using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Blogum.DAL;
using Blogum.BLL.Repository;
using System.IO;

namespace Blogum.WebUI.AdminPanel.Work
{
    public partial class WorkUpdate : System.Web.UI.Page
    {
        WorkRepository wr = new WorkRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["adminSession"] == null)
            {
                Response.Redirect("../Dashboard.aspx");
            }
            if (IsPostBack) return;
            GetWork();

        }

        private void GetWork()
        {
            if (Request.QueryString["ProjeId"] != null)
            {
                Project updated = wr.SelectById(Convert.ToInt32(Request.QueryString["ProjeId"]));
                txtProjectName.Text = updated.Title;
                txtProjeLanguage.Text = updated.ProjeLanguage;
                txtProjectAbout.Text = updated.ProjeAbout;
                //fuImage.SaveAs= updated.ProjeImage
                //ddlCat.SelectedValue = updated.Categories.CategoryName;
            }
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
            Project Updated = wr.SelectById(Convert.ToInt32(Request.QueryString["ProjeId"]));
            Updated.Title = txtProjectName.Text;
            Updated.ProjeLanguage = txtProjeLanguage.Text;
            Updated.ProjeAbout = txtProjectAbout.Text;
            Updated.ProjeImage = durum;
            wr.Update(Updated);
            Response.Redirect("~/AdminPanel/Work/WorkList.aspx");
        }

        protected void btnGeriDon_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AdminPanel/Work/WorkList.aspx");
        }
    }
}