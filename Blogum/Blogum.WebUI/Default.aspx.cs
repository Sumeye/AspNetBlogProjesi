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
    public partial class Default : System.Web.UI.Page
    {
        ArticleRepository ar = new ArticleRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            rpSummary.DataSource = ar.SelectAll().OrderByDescending(a=>a.ArticleId);
            rpSummary.DataBind();
        }
    }
}