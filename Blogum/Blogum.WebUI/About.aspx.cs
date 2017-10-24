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
    public partial class About : System.Web.UI.Page
    {
        AdminRepository adr = new AdminRepository();
        protected void Page_Load(object sender, EventArgs e)
        {

            rptAbout.DataSource = adr.SelectAll();
            rptAbout.DataBind();
        }
    }
}