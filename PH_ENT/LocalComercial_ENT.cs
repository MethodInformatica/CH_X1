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
        private int cantidad;
        private string codigoProducto;

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
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public string CodigoProducto
        {
            get { return codigoProducto; }
            set { codigoProducto = value; }
        }
    }
}
