﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void login(object sender, EventArgs e)
        {
            Response.Redirect("/Login.aspx");
        }
        protected void sign_up(object sender, EventArgs e)
        {
            Response.Redirect("/SignUp.aspx");
        }
    }
}