<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MonthlyLetter.aspx.cs" Inherits="MonthlyLetter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
	<title>Newsletter</title>
	<link rel="stylesheet" href="styles.css"/>
	<link href="https://fonts.googleapis.com/css?family=Merriweather" rel="stylesheet"/>
	<link href="https://fonts.googleapis.com/css?family=Raleway" rel="stylesheet"/>

    <!--- Element style for newletter textboxes and buttons --->
    <style> 
        .newsletter_input_frame{
            margin-left: 100px;
            margin-right: 100px;
            text-align: center;
        }
        .newsletter_text{
            color: white;
	        font-family: 'Merriweather', serif;
	        font-size: 13px;
        }
    </style>
</head>
<body>
    <header>
		<a href="index.html"> 
			<img id="logo" src="images/Squaw_rescale.png" />
		</a>
		<ul class="main_nav">
			<li class="nav"><a href="index.html" style="text-decoration: none">HOME</a></li>
			<li class="nav"><a href="about.html" style="text-decoration: none">ABOUT US</a></li>
			<li class="nav"><a href="calendar.html" style="text-decoration: none">CALENDAR</a></li>
			<li class="nav"><a href="store.aspx" style="text-decoration: none">STORE</a></li>
			<li class="nav"><a href="membership.aspx" style="text-decoration: none">MEMBERSHIPS</a></li>
			<li class="nav"><a href="MonthlyLetter.aspx" style="text-decoration: none">NEWSLETTER</a></li>
		</ul>
    </header>
    <form id="form1" runat="server">
        <div class="article_frame">
		    <p class="content_title_text">NEWSLETTER</p>
		    <img src="images/newsletter2.png" style="width: 200px; position: relative; margin-left: 39%;" />
		    <p class="content_header_text">About our Newsletter</p>
		    <p class="content_text">&emsp;Twice a month Squaw Creek sends out a newsletter that outlines upcoming events, store deals, and other course specials.<br />
                <br /> Want to subscribe to our (free) newsletter? Just type in your email into the field below and we'll add you to our growing list!</p>
        
            <div class="newsletter_input_frame">
                <asp:Label ID="lblUserPrompt" runat="server" Text="Sign up below!" CssClass="textbox"></asp:Label>
                <br />
                <br />
                <p class="newsletter_text">First Name</p><asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                <p class="newsletter_text">Last Name</p><asp:TextBox ID="txtLastName" runat="server" ></asp:TextBox>
                <p class="newsletter_text">Email</p><asp:TextBox ID="txtEmail" runat="server" ></asp:TextBox>
                <br />
                <br />
        
                <asp:Button ID="btnSubmitEmail" runat="server" Text="Submit" OnClick="btnSubmitEmail_Click" />
                <asp:Button ID="btnClearEmail" runat="server" Text="Clear" OnClick="btnClearEmail_Click" />
                <br />
                <br />
            </div>
        </div>
     </form> 
</body>  
</html>
<footer> 
		<p class="copyright"><strong>@ 2017 Squaw Creek Golf Course </strong></p>
		<p class="footer_text"><strong>1605 Ranch House Rd. | Willow Park, TX 76087 | Tel. (817) 441-8185 | Designed by Team B | <a href="mailto:SquawCreekGolfCourse@gmail.com">Email Us</a></strong></p>
		<p></p>
		<img id="footer_logo" src="images/footer-logo.png"/>
	</footer>