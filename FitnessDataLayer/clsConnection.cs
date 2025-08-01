using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace FitnessDataLayer
{
    public class clsConnection
    {
        /// <summary>
        /// connect to database server without using app config class
        /// </summary>
       // public static string ConnectionString = "Server =.;Database=h_fitness;User Id=sa;Password = sa123456";

        /// <summary>
        /// access database using app config class
        /// </summary>
         public static string ConnectionString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        //public static string ConnectionString = 
    }

}
