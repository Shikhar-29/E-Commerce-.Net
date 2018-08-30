 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerHome.aspx.cs" Inherits="WebApplication2.CustomerHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
		<title>Welcome to Shopping Portal</title>
		<meta charset="UTF-8" />
		<meta name="viewport" content="width=device-width, initial-scale=1" />
		<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css" />
        <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Raleway" />
		<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.3.0/css/font-awesome.min.css" />
		<style>
			body,h1,h2,h3,h4,h5,h6 {font-family: "Raleway", sans-serif}
		</style>
	</head>
	
	<body>
        <form runat="server">
            <!-- Sidebar -->
		    		    <nav class="w3-sidebar w3-collapse w3-black w3-animate-left" style="z-index:3;width:300px;" id="mySidebar"><br/>
			    <div class="w3-container">
				    
				    <h4><a id="CurrentUser" runat="server"><b>User</b></a></h4>
				    <p class="w3-text-grey">Customer</p>
			    </div>
			    <div class="w3-bar-block">
				    <asp:Button runat="server" OnClick="redirect_most_bought" class="w3-bar-item w3-button w3-padding w3-text-teal" Text="Most Viewed"></asp:Button> 
				  <asp:Button runat="server" OnClick="redirect_cart" class="w3-bar-item w3-button w3-padding w3-text-teal" Text="Cart"></asp:Button> 
				    <div class="w3-bottom w3-hide-small">
					    <asp:Button runat="server" onclick="customer_sign_out" class="w3-text-red w3-button" Text="Sign Out"></asp:Button>
                    </div>
			    </div>
		    </nav>
            <!-- !PAGE CONTENT! -->
            <div class="w3-main" style="margin-left:300px">

                <!-- Header -->
                <header>
                    <div class="w3-container">
                        <h1><b>My Shopping Portal</b></h1>
                    </div>
                </header>
                </div>

               <!-- !PRoducts! -->

                  <div class="w3-row">
                  <div class="w3-col l3 s6">
                <div class="w3-container">
        <img src="/static/images/hmprod.jpeg" style="width:100%; height: 300px; margin-left:600px"/>
        <p style="margin-left:700px">Mega Ripped Jeans<br/><b>Rs. 2000</b> Discount: 10%</p>
                    
      </div>

    </div>
<!-- !Button 1! -->
<div class="w3-row w3-section"style="width: 200px; margin-left: 650px; padding: 5px">
    <asp:Button ID="submit" runat="server" OnClick="add_1" class="w3-button w3-block w3-section w3-teal w3-ripple w3-padding" Text="Add To Cart" />
    </div>
            </div>

            <!-- product 2! -->
              <div class="w3-row">
                  <div class="w3-col l3 s6">
                    <div class="w3-container">
                    <img src="/static/images/2.jpeg" style="width:100%; height: 300px; margin-left:600px"/>
                        <p style="margin-left:700px">Vintage Shirt<br/><b>Rs. 1499</b></p>
                     </div>
                    </div>
                  
            <div class="w3-row w3-section"style="width: 200px; margin-left: 650px; padding: 5px">
                <asp:Button ID="Button1" runat="server" OnClick="add_2" class="w3-button w3-block w3-section w3-teal w3-ripple w3-padding" Text="Add To Cart" />
             </div>
           </div>

            <!-- product 3! -->
              <div class="w3-row ">
                  <div class="w3-col l3 s6">
                    <div class="w3-container">
                    <img src="/static/images/3.jpg" style="width:100%; height: 300px; margin-left:600px"/>
                        <p style="margin-left:700px">Vintage Shirt<br/><b>Rs. 999</b></p>
                     </div>
                    </div>
                  
            <div class="w3-row w3-section"style="width: 200px; margin-left: 650px; padding: 5px">
                <asp:Button ID="Button2" runat="server" OnClick="add_3" class="w3-button w3-block w3-section w3-teal w3-ripple w3-padding" Text="Add To Cart" />
             </div>
           </div>
            <!-- product 4! -->
              <div class="w3-row">
                  <div class="w3-col l3 s6">
                    <div class="w3-container">
                    <img src="/static/images/4.jpg" style="width:100%; height: 300px; margin-left:600px"/>
                        <p style="margin-left:700px">Leather Jacket<br/><b>Rs. 3999</b></p>
                     </div>
                    </div>
                  
            <div class="w3-row w3-section"style="width: 200px; margin-left: 650px; padding: 5px">
                <asp:Button ID="Button3" runat="server" OnClick="add_4" class="w3-button w3-block w3-section w3-teal w3-ripple w3-padding" Text="Add To Cart" />
             </div>
           </div>
            <!-- product 5! -->
              <div class="w3-row ">
                  <div class="w3-col l3 s6">
                    <div class="w3-container">
                    <img src="/static/images/5.jpg" style="width:100%; height: 300px; margin-left:600px"/>
                        <p style="margin-left:700px">Sweat Shirt<br/><b>Rs. 2999</b></p>
                     </div>
                    </div>
                  
            <div class="w3-row w3-section"style="width: 200px; margin-left: 650px; padding: 5px">
                <asp:Button ID="Button4" runat="server" OnClick="add_5" class="w3-button w3-block w3-section w3-teal w3-ripple w3-padding" Text="Add To Cart" />
             </div>
           </div>

        </form>
	</body>
</html>