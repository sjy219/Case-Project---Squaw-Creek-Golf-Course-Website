<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StoreBillingInfo.aspx.cs" Inherits="StoreBillingInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
	<meta charset="utf-8"/>
	<link rel="stylesheet" href="styles.css"/>
	<link href="https://fonts.googleapis.com/css?family=Merriweather" rel="stylesheet"/>
	<link href="https://fonts.googleapis.com/css?family=Raleway" rel="stylesheet" />
    <title>Membership Page of Squaw Creek Golf Club</title>
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
        <!--- STORE BILLING INFO CONTROLS -->
            <asp:Label ID="lblUserPrompt" runat="server" Text="Please Enter Your Billing Information." CssClass="textbox"></asp:Label>
             <!--- USED membership_text class as TEMP -->
            <p class="membership_text">First Name</p><asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                
                <p class="membership_text">Last Name</p><asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
               
                <p class="membership_text">Address</p><asp:TextBox ID="txtAddress1" runat="server"></asp:TextBox>
                <br />       
                <p class="membership_text">Address 2</p><asp:TextBox ID="txtAddress2" runat="server"></asp:TextBox>
                <br />
                <p class="membership_text">City</p><asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                <br />
                <p class="membership_text">State</p><asp:ListBox ID="txtState" runat="server" Rows="1">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem>AL</asp:ListItem>
                <asp:ListItem>AK</asp:ListItem>
                <asp:ListItem>AZ</asp:ListItem>
                <asp:ListItem>AR</asp:ListItem>
                <asp:ListItem>CA</asp:ListItem>
                <asp:ListItem>CO</asp:ListItem>
                <asp:ListItem>CT</asp:ListItem>
                <asp:ListItem>DE</asp:ListItem>
                <asp:ListItem>FL</asp:ListItem>
                <asp:ListItem>GA</asp:ListItem>
                <asp:ListItem>HI</asp:ListItem>
                <asp:ListItem>ID</asp:ListItem>
                <asp:ListItem>IL</asp:ListItem>
                <asp:ListItem>IN</asp:ListItem>
                <asp:ListItem>IA</asp:ListItem>
                <asp:ListItem>KS</asp:ListItem>
                <asp:ListItem>KY</asp:ListItem>
                <asp:ListItem>LA</asp:ListItem>
                <asp:ListItem>ME</asp:ListItem>
                <asp:ListItem>MD</asp:ListItem>
                <asp:ListItem>MA</asp:ListItem>
                <asp:ListItem>MI</asp:ListItem>
                <asp:ListItem>MN</asp:ListItem>
                <asp:ListItem>MS</asp:ListItem>
                <asp:ListItem>MO</asp:ListItem>
                <asp:ListItem>MT</asp:ListItem>
                <asp:ListItem>NE</asp:ListItem>
                <asp:ListItem>NV</asp:ListItem>
                <asp:ListItem>NH</asp:ListItem>
                <asp:ListItem>NJ</asp:ListItem>
                <asp:ListItem>NM</asp:ListItem>
                <asp:ListItem>NY</asp:ListItem>
                <asp:ListItem>NC</asp:ListItem>
                <asp:ListItem>ND</asp:ListItem>
                <asp:ListItem>OH</asp:ListItem>
                <asp:ListItem>OK</asp:ListItem>
                <asp:ListItem>OR</asp:ListItem>
                <asp:ListItem>PA</asp:ListItem>
                <asp:ListItem>RI</asp:ListItem>
                <asp:ListItem>SC</asp:ListItem>
                <asp:ListItem>SD</asp:ListItem>
                <asp:ListItem>TN</asp:ListItem>
                <asp:ListItem>TX</asp:ListItem>
                <asp:ListItem>UT</asp:ListItem>
                <asp:ListItem>VT</asp:ListItem>
                <asp:ListItem>VA</asp:ListItem>
                <asp:ListItem>WA</asp:ListItem>
                <asp:ListItem>WV</asp:ListItem>
                <asp:ListItem>WI</asp:ListItem>
                <asp:ListItem>WY</asp:ListItem>
                </asp:ListBox>
                <br />
                <p class="membership_text">Zip Code</p><asp:TextBox ID="txtZip" MaxLength="5" runat="server"></asp:TextBox>
                <br />
                <p class="membership_text">Phone Number</p><asp:TextBox ID="txtPhone" MaxLength="13" runat="server"></asp:TextBox><p class="membership_text">(___)___-____</p>
                <br />
                <p class="membership_text">Email</p><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                <br />
              <p class="content_title_text">Payment Method</p>  
              <asp:RadioButtonList ID="rblPaymentMethod" runat="server" RepeatDirection="Horizontal" CssClass="content_text">
                     <asp:ListItem>American Express</asp:ListItem>
                     <asp:ListItem>Master Card</asp:ListItem>
                     <asp:ListItem>Visa</asp:ListItem>
                 </asp:RadioButtonList>
              <br />
              <p class="membership_text">Credit Card Number</p><asp:TextBox ID="txtCCNumber" MaxLength="16" runat="server"></asp:TextBox>
              <br />
              <p class="membership_text">Order Description: </p><asp:Label ID="lblOrderDescription1" runat="server" Text="" CssClass="membership_text"></asp:Label>
              <br />
              <p class="membership_text">Price: $</p><asp:Label ID="lblPrice1" runat="server" Text="" CssClass="membership_text"></asp:Label>
              <br />
              <br />
                <asp:Button ID="btnSubmitOrder" runat="server" Text="Submit" OnClick="btnSubmitOrder_Click" />
                <asp:Button ID="btnCancelOrder1" runat="server" Text="Cancel" OnClick="btnCancelOrder1_Click" />   
                <asp:Button ID="btnClearOrder" runat="server" Text="Clear" OnClick="btnClearOrder_Click" /> 
                <br />  
                <br />
            </div>
    </form>
</body>
</html>
