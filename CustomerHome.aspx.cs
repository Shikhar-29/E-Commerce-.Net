using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class CustomerHome : System.Web.UI.Page
    {
        MiddleWare MD = new MiddleWare();
        protected void Page_Load(object sender, EventArgs e)
        {
            Boolean flag = true;
            String current_session_email = Session["CurrentUser_email"].ToString();
            if (current_session_email != "")
            {
                if (MD.login(current_session_email, Session["CurrentUser_password"].ToString()) == 1)
                {
                    String name = MD.get_name(current_session_email);
                    CurrentUser.InnerHtml = name;

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
        protected void add_1(object sender, EventArgs e)
        {
            String product = "Ripped Jeans";
            int price = 1800;
            int quantity = 1;
            MD.add1(product, price,quantity);
            MD.click_1(product);
            
        }
        protected void add_2(object sender, EventArgs e)
        {
            String product = "shirt";
            int price = 1499;
            int quantity = 1;
            MD.add1(product, price,quantity);
            MD.click_1(product);

        }
        protected void add_3(object sender, EventArgs e)
        {
            String product = "t-shirt";
            int price = 999;
            int quantity = 1;
            MD.add1(product, price,quantity);
            MD.click_1(product);

        }
        protected void add_4(object sender, EventArgs e)
        {
            String product = "jacket";
            int price = 3999;
            int quantity = 1;
            MD.add1(product, price, quantity);
            MD.click_1(product);

        }
        protected void add_5(object sender, EventArgs e)
        {
            String product = "sweatshirt";
            int price = 2999;
            int quantity = 1;
            MD.add1(product, price, quantity);
            MD.click_1(product);

        }
        protected void redirect_home(object sender, EventArgs e)
        {
            Response.Redirect("/CustomerHome.aspx");
        }

        protected void temp(object sender, EventArgs e)
        {

        }
    }
}