using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PH_ENT
{
    public class Comuna_ENT
    {
        private int idComuna;
        private int idCiudad;
        private string nombre;
        private bool estado;
        private Ciudad_ENT ciudad = new Ciudad_ENT();


        public Ciudad_ENT Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        public int IdComuna
        {
            get { return idComuna; }
            set { idComuna = value; }
        }
        
        public int IdCiudad
        {
            get { return idCiudad; }
            set { idCiudad = value; }
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
