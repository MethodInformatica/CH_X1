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
        private int cantidad;
        private string codigoProducto;
       
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
