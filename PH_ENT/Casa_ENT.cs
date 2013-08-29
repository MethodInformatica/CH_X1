using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PH_ENT
{
    public class Casa_ENT
    {
        private int idCasa;
        private string manzana;
        private string sitio;
        private int casaEsquina;
        private string modelo;
        private DetalleProducto_ENT oDetalleProducto;

        public int IdCasa
        {
            get { return idCasa; }
            set { idCasa = value; }
        }
        
        public string Manzana
        {
            get { return manzana; }
            set { manzana = value; }
        }
        
        public string Sitio
        {
            get { return sitio; }
            set { sitio = value; }
        }
        
        public int CasaEsquina
        {
            get { return casaEsquina; }
            set { casaEsquina = value; }
        }
        
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public DetalleProducto_ENT ODetalleProducto
        {
            get { return oDetalleProducto; }
            set { oDetalleProducto = value; }
        }

        public Casa_ENT() { 
        }

    }
}
