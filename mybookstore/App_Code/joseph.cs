using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Configuration;

namespace mybookstore.App_Code
{
    public class joseph
    {
        public static string GetCon()
        {
            return ConfigurationManager.ConnectionStrings["MyCon"].ConnectionString;
        }

    }
}