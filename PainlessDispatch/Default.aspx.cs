using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PainlessDispatch
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //mgp
            if (Session["SignedIn"] == null || ((bool)Session["SignedIn"] != true))
            { 
            Response.Redirect("http://localhost:4638/Account/Login");
            }
        }
    }
}