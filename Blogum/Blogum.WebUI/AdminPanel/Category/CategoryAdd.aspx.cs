using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Blogum.DAL;
using Blogum.BLL.Repository;
using System.Data.Entity;
namespace Blogum.WebUI.AdminPanel.Category
{
    public partial class CategoryAdd : System.Web.UI.Page
    {
        CategoryRepository cr = new CategoryRepository();
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
            cr.Insert(new Categories
            {
                CategoryName =txtKategoriAdi.Text,    
            });
            Response.Redirect("~/AdminPanel/Category/CategoryList.aspx");

        }

        protected void btnGeriDon_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AdminPanel/Category/CategoryList.aspx");
        }
    }
}