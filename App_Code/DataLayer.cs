using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data;

/// <summary>
/// C# class to manipulate data in the SqauwDB Database
/// </summary>
public class DataLayer
{
    OleDbConnection dbConnection;
    
    public DataLayer(string Path)
	{
        dbConnection = new OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path);
	}

    public void InsertEmailRequest(string firstname, string lastname, string email)
    {
        dbConnection.Open();

        string sqlStmt = "INSERT INTO tblEmail_Request (first_name, last_name, email)";
        sqlStmt += "VALUES (@firstname, @lastname, @email)";

        OleDbCommand dbCommand = new OleDbCommand(sqlStmt, dbConnection);

        OleDbParameter param = new OleDbParameter("@firstname", firstname);
        dbCommand.Parameters.Add(param);

        dbCommand.Parameters.Add(new OleDbParameter(" @lastname", lastname));
        dbCommand.Parameters.Add(new OleDbParameter("@email", email));

        dbCommand.ExecuteNonQuery();

        dbConnection.Close();
    }

    public void InsertMembership(string firstname, string lastname, string address1, string address2, string city, 
                                string state, string zip, string phonenumber, string email, string memduration, string  memtype)
    {
        dbConnection.Open();

        string sqlStmt = "INSERT INTO tblMemberships (first_name, last_name, address1, address2, city, state, zip, phone_number, email, mem_duration, mem_type)";
        sqlStmt += "VALUES (@firstname, @lastname, @address1, @address2, @city, @state, @zip, @phonenumber, @email, @memduration, @memtype)";

        OleDbCommand dbCommand = new OleDbCommand(sqlStmt, dbConnection);

        OleDbParameter param = new OleDbParameter("@firstname", firstname);
        dbCommand.Parameters.Add(param);

        dbCommand.Parameters.Add(new OleDbParameter(" @lastname", lastname));
        dbCommand.Parameters.Add(new OleDbParameter(" @address1", address1));
        dbCommand.Parameters.Add(new OleDbParameter(" @address2", address2));
        dbCommand.Parameters.Add(new OleDbParameter(" @city", city));
        dbCommand.Parameters.Add(new OleDbParameter(" @state", state));
        dbCommand.Parameters.Add(new OleDbParameter(" @zip", zip));
        dbCommand.Parameters.Add(new OleDbParameter(" @phonenumber", phonenumber));
        dbCommand.Parameters.Add(new OleDbParameter("@email", email));
        dbCommand.Parameters.Add(new OleDbParameter(" @memduration", memduration));
        dbCommand.Parameters.Add(new OleDbParameter(" @lastname", memtype));

        dbCommand.ExecuteNonQuery();

        dbConnection.Close();
    }
    public void InsertOrder(string firstname, string lastname, string address1, string address2, string city,
                                string state, string zip, string phonenumber, string email, string payment, 
                                string ccnumber, string orderdesc, double price)
    {
        dbConnection.Open();

        string sqlStmt = "INSERT INTO tblOrders (first_name, last_name, address1, address2, city, state, zip, phone_number, email, cc_type, cc_number, order_description, price)";
        sqlStmt += "VALUES (@firstname, @lastname, @address1, @address2, @city, @state, @zip, @phonenumber, @email, @payment, @ccnumber, @orderdesc, @price )";

        OleDbCommand dbCommand = new OleDbCommand(sqlStmt, dbConnection);

        OleDbParameter param = new OleDbParameter("@firstname", firstname);
        dbCommand.Parameters.Add(param);

        dbCommand.Parameters.Add(new OleDbParameter(" @lastname", lastname));
        dbCommand.Parameters.Add(new OleDbParameter(" @address1", address1));
        dbCommand.Parameters.Add(new OleDbParameter(" @address2", address2));
        dbCommand.Parameters.Add(new OleDbParameter(" @city", city));
        dbCommand.Parameters.Add(new OleDbParameter(" @state", state));
        dbCommand.Parameters.Add(new OleDbParameter(" @zip", zip));
        dbCommand.Parameters.Add(new OleDbParameter(" @phonenumber", phonenumber));
        dbCommand.Parameters.Add(new OleDbParameter("@email", email));
        dbCommand.Parameters.Add(new OleDbParameter(" @payment", payment));
        dbCommand.Parameters.Add(new OleDbParameter(" @ccnumber", ccnumber));
        dbCommand.Parameters.Add(new OleDbParameter(" @orderdesc", orderdesc));
        dbCommand.Parameters.Add(new OleDbParameter(" @price", price));

        dbCommand.ExecuteNonQuery();

        dbConnection.Close();
    }
}