using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PH_ENT
{
    public class LocalComercial_ENT
    {
        private int idLocalComercial;
        private string sitio;

        public int IdLocalComercial
        {
            get { return idLocalComercial; }
            set { idLocalComercial = value; }
        }
        
        public string Sitio
        {
            get { return sitio; }
            set { sitio = value; }
        }
    }
}
