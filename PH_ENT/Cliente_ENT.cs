using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PH_ENT
{
    public class Cliente_ENT
    {
        private int idCliente;
        private int idProducto;
        private string rut;
        private string nombre;
        private string email;
        private string area;
        private string telefono;

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public int IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }

        public string Rut
        {
            get { return rut; }
            set { rut = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
     
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        
        public string Area
        {
            get { return area; }
            set { area = value; }
        }
        
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public Cliente_ENT()
        { 

        }

    }
}
