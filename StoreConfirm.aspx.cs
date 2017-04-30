using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StoreConfirm : System.Web.UI.Page
{
    public Label FirstName
    {
        get { return lblFirstName; }
    }
    public Label LastName
    {
        get { return lblLastName; }
    }
    public Label Address1
    {
        get { return lblAddress1; }
    }
    public Label Address2
    {
        get { return lblAddress2; }
    }
    public Label City
    {
        get { return lblCity; }
    }
    public Label State
    {
        get { return lblState; }
    }
    public Label Zip
    {
        get { return lblZip; }
    }
    public Label PhoneNumber
    {
        get { return lblPhone; }
    }
    public Label Email
    {
        get { return lblEmail; }
    }
    public Label PaymentMethod
    {
        get { return lblPaymentMethod; }
    }
    public Label CCNumber
    {
        get { return lblCCNumber; }
    }
    public Label OrderDescription
    {
        get { return lblOrderDescription2; }
    }
    public Label Price
    {
        get { return lblPrice2; }
    }
    BusinessLayer objBusinessLayer;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FirstName.Text = this.Context.Items["FirstName"].ToString();
            LastName.Text = this.Context.Items["LastName"].ToString();
            Address1.Text = this.Context.Items["Address1"].ToString();
            Address2.Text = this.Context.Items["Address2"].ToString();
            City.Text = this.Context.Items["City"].ToString();
            State.Text = this.Context.Items["State"].ToString();
            Zip.Text = this.Context.Items["Zip"].ToString();
            PhoneNumber.Text = this.Context.Items["PhoneNumber"].ToString();
            Email.Text = this.Context.Items["Email"].ToString();
            PaymentMethod.Text = this.Context.Items["PaymentMethod"].ToString();
            CCNumber.Text = this.Context.Items["CCNumber"].ToString();
            OrderDescription.Text = this.Context.Items["OrderDescription"].ToString();
            Price.Text = this.Context.Items["Price"].ToString();
        }
        else
        {
            ViewState["PreviousPage"] = Request.UrlReferrer;
        }
    }
    protected void btnConfirmOrder_Click(object sender, EventArgs e)
    {
        objBusinessLayer = new BusinessLayer(Server.MapPath("~/App_Data/"));
        double price = Convert.ToDouble(Price.Text);
        string userPrompt = objBusinessLayer.SendOrder(FirstName.Text, LastName.Text, Address1.Text,
                            Address2.Text, City.Text, State.Text, Zip.Text, PhoneNumber.Text, Email.Text,
                            PaymentMethod.Text, CCNumber.Text, OrderDescription.Text, price);
        lblUserPrompt.Text = userPrompt;           
    }
    protected void btnCancelOrder2_Click(object sender, EventArgs e)
    {
        FirstName.Text = string.Empty;
        LastName.Text = string.Empty;
        Address1.Text = string.Empty;
        Address2.Text = string.Empty;
        City.Text = string.Empty;
        State.Text = string.Empty;
        Zip.Text = string.Empty;
        PhoneNumber.Text = string.Empty;
        Email.Text = string.Empty;
        PaymentMethod.Text = string.Empty;
        CCNumber.Text = string.Empty;
        OrderDescription.Text = string.Empty;
        Price.Text = string.Empty;
        if (ViewState["PreviousPage"] != null)
        {
            Response.Redirect("Store.aspx");
        }
    }
}