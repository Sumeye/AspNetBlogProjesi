    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Blogum.DAL;
using Blogum.BLL.Repository;

namespace Blogum.WebUI.AdminPanel.Category
{
    public partial class CategoryUpdate : System.Web.UI.Page
    {
        CategoryRepository cr = new CategoryRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["adminSession"] == null)
            {
                Response.Redirect("../Dashboard.aspx");
            }
            if (IsPostBack) return;
            CategoryFill();
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            Categories updated = cr.SelectById(Convert.ToInt32(Request.QueryString["CatId"]));
            updated.CategoryName = txtKategoriAdi.Text;
            cr.Update(updated);
            Response.Redirect("~/AdminPanel/Category/CategoryList.aspx");

        }

        private void CategoryFill()
        {
            if (Request.QueryString["CatId"] !=null)
            {
                Categories updated = cr.SelectById(Convert.ToInt32(Request.QueryString["CatId"]));
                txtKategoriAdi.Text = updated.CategoryName;
            }
          
        }
    }
}