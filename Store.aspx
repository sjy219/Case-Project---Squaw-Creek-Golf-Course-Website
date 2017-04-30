<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Store.aspx.cs" Inherits="Store" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Store</title>
    <link rel="stylesheet" href="styles.css"/>
	<link href="https://fonts.googleapis.com/css?family=Merriweather" rel="stylesheet"/>
	<link href="https://fonts.googleapis.com/css?family=Raleway" rel="stylesheet"/>
     <style> 
        .store_list_format{
            position: fixed;
            margin-left: 15%;
        }
        .store_button_format{
            text-align: center;
        }
        .store_radio_text{
            color: white;
	        font-family: 'Merriweather', serif;
	        font-size: 13px;
        }
    </style>
</head>
<body>
<header>
		<a href="index.html"> 
			<img id="logo" src="images/Squaw_rescale.png"/>
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
            <p class="content_header_text">Welcome to the Squaw Creek store!</p>
            <asp:Label ID="lblUserPrompt" runat="server" Text="" CssClass="textbox"></asp:Label>
            <p class="content_title_text">Golf Ball Pack Options</p>
            <br />
            <!--- Golf ball content --->
            <img src="images/balls.jpg" style="width: 200px; margin-left: 39%;"/>
            <div class="store_list_format">
                <asp:RadioButtonList ID="rblGolfBallPack" runat="server" RepeatDirection="Horizontal" CssClass="store_radio_text">
                     <asp:ListItem>12 Pack</asp:ListItem>
                     <asp:ListItem>24 Pack</asp:ListItem>
                     <asp:ListItem>48 Pack</asp:ListItem>
                     <asp:ListItem>100 Pack</asp:ListItem>
                 </asp:RadioButtonList>
            </div>
            <br />
            <br />
            <br />
            <div class="store_button_format">
                <asp:Button ID="btnAddToCart" runat="server" Text="Add To Cart" OnClick="btnAddToCart_Click" />
                <asp:Button ID="btnClearCart" runat="server" Text="Clear Cart" OnClick="btnClearCart_Click" />
                <asp:Button ID="btnOrder" runat="server" Text="Place Order" OnClick="btnOrder_Click" />
                <br />
                <!--- Textbox area --->
                <p style="color: white; font-family: 'Merriweather', serif; font-size: 13px; text-align: center;">Order Description</p>
                <asp:TextBox ID="txtOrderDescription" runat="server" TextMode="MultiLine" Width="250px"></asp:TextBox>
                <br />
                <p style="color: white; font-family: 'Merriweather', serif; font-size: 13px; text-align: center;">Price: $</p>
                <asp:Label ID="lblPrice" runat="server" ForeColor="White" ></asp:Label>
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
