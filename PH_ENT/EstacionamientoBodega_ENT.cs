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
        private int mtsTerreno;
        private string direccionComunal;
        private string rolSii;

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

        public int MtsTerreno
        {
            get { return mtsTerreno; }
            set { mtsTerreno = value; }
        }
        
        public string DireccionComunal
        {
            get { return direccionComunal; }
            set { direccionComunal = value; }
        }
        
        public string RolSii
        {
            get { return rolSii; }
            set { rolSii = value; }
        }

        public EstacionamientoBodega_ENT() { 
        }

    }
}
