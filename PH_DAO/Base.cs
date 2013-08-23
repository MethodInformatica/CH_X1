using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PH_DAO
{
    public class Base
    {
        public string ConexionPH;

        public Base()
        {
            this.ConexionPH = System.Configuration.ConfigurationManager.ConnectionStrings["ConexionPH"].ToString();
        }

    }
}
