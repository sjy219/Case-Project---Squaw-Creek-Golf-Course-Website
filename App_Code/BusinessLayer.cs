using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Net.Mail;

/// <summary>
/// C# Class to store Business Logic for Monthly Letter Functionality
/// </summary>
public class BusinessLayer
{
    string dataPath;

    DataLayer objDataLayer;
    
    public BusinessLayer(string serverMappedPath)
	{
        dataPath = serverMappedPath;
        objDataLayer = new DataLayer(dataPath + "SquawCreekDB.accdb"); 
	}

    public string SendEmailRequest(string firstname, string lastname, string email)
    {
        string userPrompt = "Email Request Sent Successfully. Thank you for Signing Up for the Monthly Newsletter!!!";
        try
        {
            objDataLayer.InsertEmailRequest(firstname, lastname, email);
        }
        catch (Exception error)
        {
            userPrompt = "Error Requesting Email: ";
            userPrompt += error.Message;
        }
        return userPrompt;
    }

    public string SendMembership(string firstname, string lastname, string address1, string address2, string city,
                                string state, string zip, string phonenumber, string email, string memduration, string memtype)
    {
        string userPrompt = "Membership Sign Up Sent Successfully";
        try
        {
            objDataLayer.InsertMembership(firstname, lastname, address1, address2, city, state, zip,
                                        phonenumber, email, memduration, memtype);
        }
        catch (Exception error)
        {
            userPrompt = "Error Requesting Membership: ";
            userPrompt += error.Message;
        }
        return userPrompt;
    }

    public string SendOrder(string firstname, string lastname, string address1, string address2, string city,
                                string state, string zip, string phonenumber, string email,
                            string payment, string ccnumber, string orderdesc, double price)
    {
        string userPrompt = "Order Confirmation Was Successful";
        try
        {
            objDataLayer.InsertOrder(firstname, lastname, address1, address2, city, state, zip,
                                        phonenumber, email, payment, ccnumber,  orderdesc, price);
        }
        catch (Exception error)
        {
            userPrompt = "Error Placing Order: ";
            userPrompt += error.Message;
        }
        return userPrompt;
    }
    public bool IsEmailValid(string emailaddress)
    {
        try
        {
            MailAddress m = new MailAddress(emailaddress);

            return true;
        }
        catch (FormatException)
        {
            return false;
        }
    }
}