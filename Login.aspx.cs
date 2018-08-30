using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void login(object sender, EventArgs e)
        {
            MiddleWare MD = new MiddleWare();
            Session["CurrentUser_email"] = email.Text;
            Session["CurrentUser_password"] = password.Text;
            MD.empty_cart();
            Response.Redirect("/CustomerHome.aspx");
           
        }
        protected void to_sign_up(object sender, EventArgs e)
        {
            Response.Redirect("/SignUp.aspx");
        }
        protected void to_home(object sender, EventArgs e)
        {
            Response.Redirect("/home.aspx");
        }
    }
}