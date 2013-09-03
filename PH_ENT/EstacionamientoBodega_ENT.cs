using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PH_ENT
{
    public class EstacionamientoBodega_ENT
    {
        private int idEstacionamientoBodega;
        private string numeroEstBod;

        public EstacionamientoBodega_ENT()
        {
        }

        public int IdEstacionamientoBodega
        {
            get { return idEstacionamientoBodega; }
            set { idEstacionamientoBodega = value; }
        }
        
        public string NumeroEstBod
        {
            get { return numeroEstBod; }
            set { numeroEstBod = value; }
        }
        
    }
}
