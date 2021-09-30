using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Unity;

namespace WebAPI.Repository
{
    public class DataAccess
    {
    }
    public class SQLDataAccess : IDataAccess
    {
        public string Add()
        {//Implement the SQL DB methods to store data
            return "Data inserted into SQL Server";
        }
    }

    public class NoSQLDataAccess : IDataAccess
    {
        public string Add()
        {//Implement the NO SQL DB methods to store data
            return "Data inserted into NO SQL DB";
        }
    }


    public class Factory
    {
        public static Customer GenerateCustomerClass(IConfiguration _conf)
        {
           
           var result = _conf.GetValue<string>("Settings:DbConnection");

            IUnityContainer objContainer = new UnityContainer();
            objContainer.RegisterType<Customer>();
            if (result.ToString() == "SQL")
                objContainer.RegisterType<IDataAccess, SQLDataAccess>();
            else if (result.ToString() == "NOSQL")
                objContainer.RegisterType<IDataAccess, NoSQLDataAccess>();

            Customer obj = objContainer.Resolve<Customer>();
            return obj;
        }
    }

}
