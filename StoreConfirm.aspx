<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StoreConfirm.aspx.cs" Inherits="StoreConfirm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
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
        <!--- USING membership_input_frame CLASS AS TEMP-->
        <div class="membership_input_frame">
        <p class="membership_title_text"><asp:Label ID="lblUserPrompt" runat="server" Text="Please Confirm Your Order" CssClass="textbox"></asp:Label></p>
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
            <p class="membership_text">Payment Method:</p><asp:Label ID="lblPaymentMethod" runat="server" Text="" CssClass="membership_text"></asp:Label> 
            <br />  
            <br />
            <p class="membership_text">Credit Card Number:</p><asp:Label ID="lblCCNumber" runat="server" Text="" CssClass="membership_text"></asp:Label> 
            <br />  
            <br />
            <p class="membership_text">Order Description:</p><asp:Label ID="lblOrderDescription2" runat="server" Text="" CssClass="membership_text"></asp:Label> 
            <br />  
            <br />
            <p class="membership_text">Price: $</p><asp:Label ID="lblPrice2" runat="server" Text="" CssClass="membership_text"></asp:Label> 
            <br />  
            <br />
            <asp:Button ID="btnConfirmOrder" runat="server" Text="Confirm" OnClick="btnConfirmOrder_Click" />
            <asp:Button ID="btnCancelOrder2" runat="server" Text="Cancel" OnClick="btnCancelOrder2_Click" />
            <br /> 
            <br />
    </div>
      </div>
    </form>
</body>
</html>
