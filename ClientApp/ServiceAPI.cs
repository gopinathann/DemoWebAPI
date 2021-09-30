using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WebAPI;

namespace ClientApp
{

    

    public class ServiceAPI
    {

        public  string ServiceCall(string serviceType)
        {
            string response=null;
            string url = "http://localhost:49168/Message/" + serviceType;
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/x-www-form-urlencoded";

            HttpWebResponse webresponse=null;

            try
            {
                 webresponse = (HttpWebResponse)webrequest.GetResponse();
                if (webresponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    using (Stream dataStream = webresponse.GetResponseStream())
                    {
                        // Open the stream using a StreamReader for easy access.
                        StreamReader reader = new StreamReader(dataStream);
                        // Read the content.
                        string responseFromServer = reader.ReadToEnd();
                        // Display the content.
                        response = responseFromServer;
                    }
                    
                }
            }
            catch
            {
                response= "Error";
            }
            
            return response;
        }
           

        public string DisplayData()
        {
            return null;
        }
       
    }
    
}
