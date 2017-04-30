<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MemConfirm.aspx.cs" Inherits="MemConfirm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<meta charset="utf-8"/>
	<link rel="stylesheet" href="styles.css"/>
	<link href="https://fonts.googleapis.com/css?family=Merriweather" rel="stylesheet"/>
	<link href="https://fonts.googleapis.com/css?family=Raleway" rel="stylesheet"/>
    <title>Membership Confirm Page of Squaw Creek Golf Club</title>
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
        <div class="membership_input_frame">
            <p class="membership_title_text"><asp:Label ID="lblUserPrompt" runat="server" Text="Please Confirm Your Information" CssClass="textbox"></asp:Label></p>
            <br />
            <br />
            <p class="membership_text">First Name:</p><asp:Label ID="lblFirstName" runat="server" Text="" CssClass="membership_text"></asp:Label>
            <br />
            <br />
            <p class="membership_text">Last Name:</p><asp:Label ID="lblLastName" runat="server" Text="" CssClass="membership_text"></asp:Label>
            <br />
            <br />
            <p class="membership_text">Address:</p><asp:Label ID="lblAddress1" runat="server" Text="" CssClass="membership_text"></asp:Label>
            <br />
            <br />
            <p class="membership_text">Address 2:</p><asp:Label ID="lblAddress2" runat="server" Text="" CssClass="membership_text"></asp:Label>
            <br />
            <br />
            <p class="membership_text">City:</p><asp:Label ID="lblCity" runat="server" Text="" CssClass="membership_text"></asp:Label> 
            <br />
            <br />
            <p class="membership_text">State:</p><asp:Label ID="lblState" runat="server" Text="" CssClass="membership_text"></asp:Label> 
            <br />
            <br />
            <p class="membership_text">State:</p><asp:Label ID="lblZip" runat="server" Text="" CssClass="membership_text"></asp:Label> 
            <br />
            <br />
            <p class="membership_text">Phone Number:</p><asp:Label ID="lblPhone" runat="server" Text="" CssClass="membership_text"></asp:Label> 
            <br /> 
            <br />
            <p class="membership_text">Email:</p><asp:Label ID="lblEmail" runat="server" Text="" CssClass="membership_text"></asp:Label> 
            <br />  
            <br />
            <p class="membership_text">Membership Duration:</p><asp:Label ID="lblMemDuration" runat="server" Text="" CssClass="membership_text"></asp:Label> 
            <br />
            <br />
            <p class="membership_text">Membership Type</p><asp:Label ID="lblMemType" runat="server" Text="" CssClass="membership_text"></asp:Label> 
            <br />
            <br />
            <asp:Button ID="btnConfirmMem" runat="server" Text="Confirm" OnClick="btnConfirmMem_Click" />
            <asp:Button ID="btnCancelMem" runat="server" Text="Cancel" OnClick="btnCancelMem_Click" />
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