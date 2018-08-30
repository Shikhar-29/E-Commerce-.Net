<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="WebApplication2.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">




























































































		<title>Shopping Portal</title>
		<meta charset="UTF-8" />
		<meta name="viewport" content="width=device-width, initial-scale=1" />
		<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css" />
		<link rel="stylesheet" href="https://www.w3schools.com/lib/w3-theme-teal.css" />
		<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.3.0/css/font-awesome.min.css" />
		<link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons" />
		<script>
			// Side navigation
			function w3_open() {
				var x = document.getElementById("mySidebar");
				x.style.width = "100%";
				x.style.fontSize = "40px";
				x.style.paddingTop = "10%";
				x.style.display = "block";
			}
			function w3_close() {
				document.getElementById("mySidebar").style.display = "none";
			}
			function about_to_contact() {
				document.getElementById('about_us').style.display='none';
				document.getElementById('contact').style.display='block';
            }
		</script>
	</head>

	<body>
		<!-- Side Navigation -->
		<nav class="w3-sidebar w3-bar-block w3-card-2 w3-animate-left w3-center" style="display: none" id="mySidebar">
			<h1 class="w3-xxxlarge w3-text-theme">Shopping Portal</h1>
			<button onclick="document.getElementById('about_us').style.display='block'" class="w3-bar-item w3-button">About Us</button>
			<button onclick="document.getElementById('contact').style.display='block'" class="w3-bar-item w3-button">Contact</button>
			<button class="w3-bar-item w3-button w3-red" onclick="w3_close()">Close <i class="fa fa-remove"></i></button>
		</nav>

		<!-- Header -->
		<header class="w3-container w3-theme w3-padding" id="myHeader">
			<i onclick="w3_open()" class="fa fa-bars w3-xlarge w3-button w3-theme"></i>
			<div class="w3-center" >
				<h3 class="w3-wide">SHOPPING PORTAL</h3>
				<h2 class="w3-xxxlarge w3-animate-bottom">SHOP ALL THAT YOU NEED IN ONE PLACE</h2>
				<div>
                    <form id="login_signup" runat="server">
					    <div class="w3-half w3-container w3-right-align">
						    <div class="w3-padding-32">
						        <asp:button runat="server" class="w3-btn w3-xlarge w3-theme-dark w3-hover-black" onclick="sign_up" 
                                    style="font-weight: 900;" Text="&nbsp;&nbsp;&nbsp;&nbsp;Sign Up&nbsp;&nbsp;&nbsp;&nbsp;"></asp:button>
                            </div>
					    </div>
                        <div class="w3-half w3-container w3-left-align">
						    <div class="w3-padding-32">
							    <asp:button runat="server" class="w3-btn w3-xlarge w3-theme-dark w3-hover-black" onclick="login" 
                                    style="font-weight: 900;" Text="&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Login&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"></asp:button>
						    </div>
					    </div>
                    </form>
				</div>
				<br />
			</div>
		</header>

        <div style="width:100%;margin-right:0px;height:5%">
            <img src="/static/images/ecommerce1.png" style="width:100%;height:50%"/>
        </div>

		
		
		<!-- Contact Modal -->
		<div id="contact" class="w3-modal">
			<div class="w3-modal-content w3-animate-zoom">
				<div class="w3-container w3-blue">
					<span onclick="document.getElementById('contact').style.display='none'" class="w3-button w3-display-topright w3-large">x</span>
					<h1>Contact</h1>
				</div>
				<div class="w3-container">
					<p>Tell us what you need and we will do our best to help you</p>
					<form id="form_contact" class="w3-margin">
						<p><input class="w3-input w3-padding-16 w3-border" type="email" name="email" placeholder="Email" required="required" /></p>
						<textarea rows="5" class="w3-input w3-padding-16 w3-border" name="message" placeholder="Message" required="required"></textarea>
						<p><input type="submit" value="Send Message" class="w3-button w3-block w3-section w3-green w3-ripple w3-padding" /></p>
					</form>
				</div>
			</div>
		</div>
		
		
		<!-- Footer -->
		<footer class="w3-center w3-black w3-padding-16">
			<a href="#myHeader" class="w3-button w3-red"><i class="fa fa-arrow-up w3-margin-right"></i>To the top</a>
			<div class="w3-xlarge w3-section">
				<i class="fa fa-facebook-official w3-hover-opacity"></i>
				<i class="fa fa-twitter w3-hover-opacity"></i>
			</div>
			<p>Created using <a href="https://www.w3schools.com/w3css/default.asp" title="W3.CSS" target="_blank" class="w3-hover-text-blue">w3.css</a></p>
		</footer>
	</body>
</html>