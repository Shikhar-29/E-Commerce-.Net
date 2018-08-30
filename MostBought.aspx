<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MostBought.aspx.cs" Inherits="WebApplication2.MostBought" %>

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
                         <asp:Button runat="server" onclick="redirect_customer_home" class="w3-text-blue w3-button" Text="Home"></asp:Button>
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
             <div runat="server" id="most_bought"></div>
                </div>

                 </form>
	</body>
</html>
