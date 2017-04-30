using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

public partial class Membership : System.Web.UI.Page
{
    public TextBox FirstName
    {
        get { return txtFirstName; }
    }
    public TextBox LastName
    {
        get { return txtLastName; }
    }
    public TextBox Address1
    {
        get { return txtAddress1; }
    }
    public TextBox Address2
    {
        get { return txtAddress2; }
    }
    public TextBox City
    {
        get { return txtCity; }
    }
    public ListBox State
    {
        get { return txtState; }
    }
    public TextBox Zip
    {
        get { return txtZip; }
    }
    public TextBox PhoneNumber
    {
        get { return txtPhone; }
    }
    public TextBox Email
    {
        get { return txtEmail; }
    }
    public RadioButtonList MemDuration
    {
        get { return rblMemDuration; }
    }
    public RadioButtonList MemType
    {
        get { return rblMemType; }
    }
    BusinessLayer objBusinessLayer;

    protected void Page_Load(object sender, EventArgs e)
    {
        objBusinessLayer = new BusinessLayer(Server.MapPath("~/App_Data/"));
    }
    protected void btnSubmitMem_Click(object sender, EventArgs e)
    {
        
        if (FirstName.Text == "" || LastName.Text == "" || Address1.Text =="" || 
            City.Text == "" || State.Text == "" || Zip.Text == "" ||
            PhoneNumber.Text == "" || Email.Text == "" || MemDuration.Text == "" || MemType.Text == "")
        {
            lblUserPrompt.Text = "Please Fill in All Fields (Address 2 Optional).";
        }
        else if (!Regex.IsMatch(FirstName.Text, @"^[a-zA-Z]{1,25}$"))
        {
            lblUserPrompt.Text = "Invalid Entry.";
            FirstName.ForeColor = System.Drawing.Color.Red;
        }
        else if (!Regex.IsMatch(LastName.Text, @"^[a-zA-Z\s-]{1,50}$"))
        {
            lblUserPrompt.Text = "Invalid Entry.";
            LastName.ForeColor = System.Drawing.Color.Red;
            FirstName.ForeColor = System.Drawing.Color.Black;
        }
        else if (!Regex.IsMatch(Address1.Text, @"^[a-zA-Z0-9\s.]{1,100}$"))
        {
            lblUserPrompt.Text = "Invalid Entry.";
            Address1.ForeColor = System.Drawing.Color.Red;
            LastName.ForeColor = System.Drawing.Color.Black;
        }
        else if (Address2.Text != "" && !Regex.IsMatch(Address2.Text, @"^[a-zA-Z0-9\s.]{1,100}$"))
        {
            lblUserPrompt.Text = "Invalid Entry.";
            Address2.ForeColor = System.Drawing.Color.Red;
            Address1.ForeColor = System.Drawing.Color.Black;
        }
        else if (!Regex.IsMatch(City.Text, @"^[a-zA-Z\s-]{1,50}$"))
        {
            lblUserPrompt.Text = "Invalid Entry.";
            City.ForeColor = System.Drawing.Color.Red;
            Address2.ForeColor = System.Drawing.Color.Black;
        }
        else if (!Regex.IsMatch(Zip.Text, @"^[0-9]{1,5}$"))
        {
            lblUserPrompt.Text = "Invalid Entry.";
            Zip.ForeColor = System.Drawing.Color.Red;
            City.ForeColor = System.Drawing.Color.Black;
        }
        else if (!Regex.IsMatch(PhoneNumber.Text, @"^[(]{1}[0-9]{3}[)]{1}[0-9]{3}[-]{1}[0-9]{4}$"))
        {
            lblUserPrompt.Text = "Invalid Entry.";
            PhoneNumber.ForeColor = System.Drawing.Color.Red;
            Zip.ForeColor = System.Drawing.Color.Black;
        }
        else if (objBusinessLayer.IsEmailValid(Email.Text) == false)
        {
            lblUserPrompt.Text = "Invalid Entry.";
            Email.ForeColor = System.Drawing.Color.Red;
            PhoneNumber.ForeColor = System.Drawing.Color.Black;
        }
        else
        {
            this.Context.Items["FirstName"] = FirstName.Text;
            this.Context.Items["LastName"] = LastName.Text;
            this.Context.Items["Address1"] = Address1.Text;
            this.Context.Items["Address2"] = Address2.Text;
            this.Context.Items["City"] = City.Text;
            this.Context.Items["State"] = State.Text;
            this.Context.Items["Zip"] = Zip.Text;
            this.Context.Items["PhoneNumber"] = PhoneNumber.Text;
            this.Context.Items["Email"] = Email.Text;
            this.Context.Items["MemDuration"] = MemDuration.Text;
            this.Context.Items["MemType"] = MemType.Text;
            Server.Transfer("MemConfirm.aspx", true);
        }   

    }
    protected void btnClearMem_Click(object sender, EventArgs e)
    {
        FirstName.Text = string.Empty;
        LastName.Text = string.Empty;
        Address1.Text = string.Empty;
        Address2.Text = string.Empty;
        City.Text = string.Empty;
        State.Text = string.Empty;
        PhoneNumber.Text = string.Empty;
        Email.Text = string.Empty;
        MemDuration.SelectedIndex = -1;
        MemType.SelectedIndex = -1;
    }
    
}