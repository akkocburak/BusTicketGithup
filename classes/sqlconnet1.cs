using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusTicketGithup.classes
{
    public class sqlconnet1
    {
        public class Sqlconnection connection = new Sqlconnection("Data Source=BURAK;Initial Catalog=bus_ticket;Integrated Security=True;Encrypt=False");
    public static void checkconnection()
        {
            if (connection.state == System.Data.ConnectionState.Closed)
            {
                connection.Open();  
            }
            else { }
        }
    }
}