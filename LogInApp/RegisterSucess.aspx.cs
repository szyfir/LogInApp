using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LogInApp
{
    public partial class RegisterSucess : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ((Panel)Master.FindControl("login")).Visible = false;
            ((Panel)Master.FindControl("loginSucess")).Visible = true;
            string imie = Request.QueryString["Imie"].ToString();
            ((Label)Master.FindControl("lbLogout")).Text = imie;
        }
    }
}