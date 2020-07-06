using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;     //Password encryption


namespace Token_System
{
    class User
    {
        String FirstName;
        String MiddleName;
        String LastName;
        String CompanyID;
        String Password;              //password of admin.    



    }


    class Admin : User
    {

    }

    class Employee : User
    {
        int CounterNo;
        DateTime StartTime;            //Start time of a patricular service.
        DateTime EndTime;              //End time of that particular service.
    }

    public class Counter
    {
        int CounterID;
        int EmployeeID;
    }

    public class Ticket
    {
        int TicketID;
        String ServiceName;
        int TokenID;
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
