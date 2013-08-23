using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PH_ENT
{
    public class Ciudad_ENT
    {
        private int idCiudad;
        private int idRegion;
        private string nombre;
        private bool estado;

        public int IdCiudad
        {
            get { return idCiudad; }
            set { idCiudad = value; }
        }
        
        public int IdRegion
        {
            get { return idRegion; }
            set { idRegion = value; }
        }
        
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        
        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
