using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Controllers;

namespace WebAPI.Repository
{
    public class Customer
    {
        private IDataAccess ODAL;
        public string CustomerName { get; set; }
        public Customer(IDataAccess iObj)
        {
            ODAL = iObj;
        }
        public string Add()
        {
            return ODAL.Add();
        }

    }
}
