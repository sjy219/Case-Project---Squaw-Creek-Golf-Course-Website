using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Store : System.Web.UI.Page
{
    string order = "You have nothing in your cart.";
    double price = 0.00;  
    
    public RadioButtonList GolfBallPack
    {
        get { return rblGolfBallPack; }
    }
    public TextBox OrderDescription
    {
        get { return txtOrderDescription; }
    }
    public Label Price
    {
        get { return lblPrice; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        string previousPage = Request.UrlReferrer.ToString();
        if (previousPage == "http://localhost:60793/StoreBillingInfo.aspx")// < == when hosted == http://squaw.dynu.net/StoreBillingInfo.aspx
        {
            Session["price"] = 0.00;
            Session["order"] = "";
        } 
    }
    protected void btnAddToCart_Click(object sender, EventArgs e)
    {
        lblUserPrompt.Text = "";
        if (GolfBallPack.Text == "12 Pack")
        {
            double currentPrice = (double)Session["price"];
            string currentOrder = (string)Session["order"];
            price = 10.99;
            currentPrice += price;
            Session["price"] = currentPrice;
            order = "1- " + GolfBallPack.Text + " SCGolf Balls";
            currentOrder += order + Environment.NewLine;
            Session["order"] = currentOrder;
            Price.Text = Session["price"].ToString();
            OrderDescription.Text = Session["order"].ToString();
            
        }
        else if (GolfBallPack.Text == "24 Pack")
        {
            
            double currentPrice = (double)Session["price"];
            string currentOrder = (string)Session["order"];
            price = 19.99;
            currentPrice += price;
            Session["price"] = currentPrice;
            order = "1- " + GolfBallPack.Text + " SCGolf Balls";
            currentOrder += order + Environment.NewLine;
            Session["order"] = currentOrder;
            Price.Text = Session["price"].ToString();
            OrderDescription.Text = Session["order"].ToString();
        }
        else if (GolfBallPack.Text == "48 Pack")
        {            
            double currentPrice = (double)Session["price"];
            string currentOrder = (string)Session["order"];
            price = 38.99;
            currentPrice += price;
            Session["price"] = currentPrice;
            order = "1- " + GolfBallPack.Text + " SCGolf Balls";
            currentOrder += order + Environment.NewLine;
            Session["order"] = currentOrder;
            Price.Text = Session["price"].ToString();
            OrderDescription.Text = Session["order"].ToString();
        }
        else if (GolfBallPack.Text == "100 Pack")
        {
            
            double currentPrice = (double)Session["price"];
            string currentOrder = (string)Session["order"];
            price = 69.99;
            currentPrice += price;
            Session["price"] = currentPrice;
            order = "1- " + GolfBallPack.Text + " SCGolf Balls";
            currentOrder += order + Environment.NewLine;
            Session["order"] = currentOrder;
            Price.Text = Session["price"].ToString();
            OrderDescription.Text = Session["order"].ToString();
        } 
    }
    protected void btnClearCart_Click(object sender, EventArgs e)
    {
        lblUserPrompt.Text = "";
        rblGolfBallPack.Text = string.Empty;
        OrderDescription.Text = string.Empty;
        Price.Text = string.Empty;
        Session["price"] = 0.00;
        Session["order"] = "";
    }
    protected void btnOrder_Click(object sender, EventArgs e)
    {
        if (OrderDescription.Text == "" || Price.Text =="")
        {
            lblUserPrompt.Text = "Please Add Items to Your Cart";
        }        
        else
        {
        this.Context.Items["OrderDescription"] = OrderDescription.Text;
        this.Context.Items["Price"] = Price.Text;
        Server.Transfer("StoreBillingInfo.aspx", true);
        }
    }
}