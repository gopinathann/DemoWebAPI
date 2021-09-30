using System;
using System.Net;
using System.Net.Http;
using System.Web;
using System.IO;

namespace ClientApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            displayData(); // display data to console
            writeData(); // stored the data to db and return the message

           
        }


        public static void displayData()

        {//Create API instane and pass Read/Write
            ServiceAPI s = new ServiceAPI();
            Console.WriteLine("------------Reading data from config file---------");
            Console.WriteLine(s.ServiceCall("Read"));

        }
        public static void writeData()

        {//Create API instane and pass Read/Write
            ServiceAPI s = new ServiceAPI();
            Console.WriteLine("--------------Writing data to DB (SQL/ NOSQL ) based on Repository pattern-------------");
            Console.WriteLine(s.ServiceCall("Write"));

        }
       

    }
}
