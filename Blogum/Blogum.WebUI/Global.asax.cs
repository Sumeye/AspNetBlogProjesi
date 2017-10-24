using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Blogum.WebUI
{
    public class Global : System.Web.HttpApplication
    {
        int sayac = 0;
        protected void Application_Start(object sender, EventArgs e)
        {
            Application["OnlineZiyaretci"] = 0; //Burada OnlineZiyaretçi tanımı yapılmıştır.
            Application["total"] = 0;
        }
        void Application_End(object sender, EventArgs e)
        {
            Application.Remove("OnlineZiyaretci"); //Burada uygulama sonlandırılmıştır ve OnlineZiyaretci State'imizi siliyoruz.
        }
        void Session_Start(object sender, EventArgs e)
        {
            Application.Lock();
            Application["OnlineZiyaretci"] = (int)Application["OnlineZiyaretci"] + 1; //Burada sitemize yeni bir kullanıcı girdiğini anlıyoruz ve OnlineZiyaretçi sayımızı 1 artırıyoruz.
            Application["total"] = (int)Application["total"] + 1;
            sayac++ ;
            Application.UnLock();
        }

        void Session_End(object sender, EventArgs e)
        {
            Application.Lock();
            Application["OnlineZiyaretci"] = (int)Application["OnlineZiyaretci"] - 1;  //Burada sitemizden bir kullanıcının ayrılmış olduğunu anlıyoruz ve OnlineZiyaretçi sayımızı 1 azaltıyoruz.
            Application.UnLock();
        }

    }
}