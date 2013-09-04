using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PH_ENT
{
    public class TipoProducto_ENT
    {
        private int idTipoProducto;
        private string nombre;
        private bool estado;
        private string codigo;

        public int IdTipoProducto
        {
            get { return idTipoProducto; }
            set { idTipoProducto = value; }
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

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
    }
}
