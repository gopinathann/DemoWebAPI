using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Unity;
using Unity.Injection;
using WebAPI.Repository;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        private readonly IConfiguration _config;

        public MessageController(IConfiguration config)
        {
            _config = config;
        
        }

        [HttpGet, Route("Read")]
        public string getMessage()
        {
            Message m = new Message();
            // Read message from the configuration
            m.Data = _config.GetValue<string>("Settings:Message");
            if (m.Data != null)
                return m.Data;
            else
                return ("No message found");
        }

        [HttpGet, Route("Write")]
        public string WriteMessage()
        {
            //Get the DB instance based on the DB source
            Customer obj = Factory.GenerateCustomerClass(_config);
            obj.CustomerName = "Hello World";
            return obj.Add();
            
            
        }

        
    }

}
