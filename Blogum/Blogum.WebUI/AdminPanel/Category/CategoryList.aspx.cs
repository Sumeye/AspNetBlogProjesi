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
    public partial class CategoryList : System.Web.UI.Page
    {
        CategoryRepository cr = new CategoryRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["adminSession"] == null)
            {
                Response.Redirect("../Dashboard.aspx");
            }
            if (IsPostBack) return;
            CategoryFiil();
        }

        protected void rptKategoriler_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "delete":
                    cr.Delete(Convert.ToInt32(e.CommandArgument));
                    CategoryFiil();
                    break;
                case "update":
                    Response.Redirect(string.Format("~/AdminPanel/Category/CategoryUpdate.aspx?CatId={0}", e.CommandArgument));
                    break;

            }
        }


        private void CategoryFiil()
        {
            rptCategory.DataSource = cr.SelectAll();
            rptCategory.DataBind();
        }

        protected void lnknewcategory_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AdminPanel/Category/CategoryAdd.aspx");
        }
    }
}