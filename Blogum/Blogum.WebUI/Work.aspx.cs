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
    public partial class Work : System.Web.UI.Page
    { WorkRepository wr = new WorkRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            rptportfolio.DataSource = wr.SelectAll().Select(a => new
            {
                a.ProjeId,
                a.ProjeAbout,
                a.ProjeLanguage,
                a.Title,
                a.ProjeImage
            });
            rptportfolio.DataBind();
        }
    }
}