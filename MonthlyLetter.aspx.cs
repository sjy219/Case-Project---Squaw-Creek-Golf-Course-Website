using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;


public partial class MonthlyLetter : System.Web.UI.Page
{
    public TextBox FirstName
    {
        get { return txtFirstName;  }
    }

    public TextBox LastName
    {
        get { return txtLastName; }
    }

    public TextBox Email
    {
        get { return txtEmail; }
    }

    BusinessLayer objBusinessLayer;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        objBusinessLayer = new BusinessLayer(Server.MapPath("~/App_Data/"));
    }
    protected void btnSubmitEmail_Click(object sender, EventArgs e)
    {
        
        string userPrompt;
        if (FirstName.Text == "" || LastName.Text == "" ||  Email.Text == "")
        {
            userPrompt = "Please Fill in All Fields";
        }
        else if (!Regex.IsMatch(FirstName.Text, @"^[a-zA-Z]{1,25}$"))
        {
            userPrompt = "Invalid Entry.";
            FirstName.ForeColor = System.Drawing.Color.Red;
        }
        else if (!Regex.IsMatch(LastName.Text, @"^[a-zA-Z\s-]{1,50}$"))
        {
            userPrompt = "Invalid Entry.";
            LastName.ForeColor = System.Drawing.Color.Red;
            FirstName.ForeColor = System.Drawing.Color.Black;
        }   
        else if (objBusinessLayer.IsEmailValid(Email.Text) == false)
        {
            userPrompt = "Invalid Entry.";
            Email.ForeColor = System.Drawing.Color.Red;
            LastName.ForeColor = System.Drawing.Color.Black;
        }
        else
        {
            Email.ForeColor = System.Drawing.Color.Black;
            userPrompt = objBusinessLayer.SendEmailRequest(FirstName.Text, LastName.Text, Email.Text);
        }
        
        lblUserPrompt.Text = userPrompt;

    }
    protected void btnClearEmail_Click(object sender, EventArgs e)
    {
        FirstName.Text = string.Empty;
        LastName.Text = string.Empty;
        Email.Text = string.Empty;
        lblUserPrompt.Text = "";
    }
}