using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MiddleWare MD = new MiddleWare();
            Boolean flag = true;
            String current_session_email = Session["CurrentUser_email"].ToString();
            if (current_session_email != "")
            {
                if (MD.login(current_session_email, Session["CurrentUser_password"].ToString()) == 1)
                {
                    String name = MD.get_name(current_session_email);
                    CurrentUser.InnerHtml = name;
                    String items = MD.display_cart();
                    cart.InnerHtml = items;
                }
                else
                {
                    Session["Issue"] = "Incorrect Password";
                    flag = false;
                }

            }
            else
            {
                Session["Issue"] = "User Not Found";
                flag = false;
            }
            if (!flag)
            {
                Session.Remove("CurrentUser_email");
                Session.Remove("CurrentUser_password");
                Response.Redirect("/LoginError.aspx");
            }

        }
        protected void customer_sign_out(object sender, EventArgs e)
        {
            Session.Remove("CurrentUser_email");
            Session.Remove("CurrentUser_password");
            Response.Redirect("/home.aspx");
        }
        protected void redirect_cart(object sender, EventArgs e)
        {
            Response.Redirect("/Cart.aspx");
        }
        protected void redirect_most_bought(object sender, EventArgs e)
        {
            Response.Redirect("/MostBought.aspx");
        }
        protected void redirect_customer_home(object sender, EventArgs e)
        {
            Response.Redirect("/CustomerHome.aspx");
        }
        protected void redirect_buy_now(object sender, EventArgs e)
        {
            MiddleWare MD = new MiddleWare();
            MD.empty_cart();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('ORDER PLACED');</script>");
            
        }
    }

    
}