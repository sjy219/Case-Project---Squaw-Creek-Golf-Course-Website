using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MemConfirm : System.Web.UI.Page
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
    public Label MemDuration
    {
        get { return lblMemDuration; }
    }
    public Label MemType
    {
        get { return lblMemType; }
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
            MemDuration.Text = this.Context.Items["MemDuration"].ToString();
            MemType.Text = this.Context.Items["MemType"].ToString();
        }
        else
        {
            ViewState["PreviousPage"] = Request.UrlReferrer;
        }
    }
    protected void btnCancelMem_Click(object sender, EventArgs e)
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
        MemDuration.Text = string.Empty;
        MemType.Text = string.Empty;
        if (ViewState["PreviousPage"] != null)
        {
            Response.Redirect(ViewState["PreviousPage"].ToString());
        }
        
    }
    protected void btnConfirmMem_Click(object sender, EventArgs e)
    {
        objBusinessLayer = new BusinessLayer(Server.MapPath("~/App_Data/"));
        string userPrompt = objBusinessLayer.SendMembership(FirstName.Text, LastName.Text, Address1.Text,
                            Address2.Text, City.Text, State.Text, Zip.Text,
                            PhoneNumber.Text, Email.Text,
                            MemDuration.Text, MemType.Text);
        lblUserPrompt.Text = userPrompt;
    }
}