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
    public partial class MainPage : System.Web.UI.MasterPage
    {
        AdminRepository adr = new AdminRepository();
        CategoryRepository cr = new CategoryRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblZiyaretciSayisi.Text = "Online Ziyaretci Sayısı:" + Application["OnlineZiyaretci"];
            lbltotalziyaretci.Text = "Toplam Ziyaretci Sayısı:" + Application["total"];
            GetAdmin();
            getCategory();
        }



        private void GetAdmin()
        {
            rptAdminBio.DataSource = adr.SelectAll();
            rptAdminBio.DataBind();
        }

        private void getCategory()
        {
            rptCategory.DataSource = cr.SelectAll();
            rptCategory.DataBind();
            
        }

        

    }
}

