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
    
    public partial class WorkAdd : System.Web.UI.Page
    {
        WorkRepository wr = new WorkRepository();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["adminSession"] == null)
            {
                Response.Redirect("../Dashboard.aspx");
            }
            if (IsPostBack) return;
       
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
            wr.Insert(new Project
            {
                 Title=txtProjectName.Text,
                  ProjeLanguage=txtProjeLanguage.Text,
                  ProjeAbout=txtProjectAbout.Text,
                  ProjeImage=durum
            });
            Response.Redirect("~/AdminPanel/Work/WorkList.aspx");
        }

        protected void btnGeriDon_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AdminPanel/Work/WorkList.aspx");
        }
    }
}