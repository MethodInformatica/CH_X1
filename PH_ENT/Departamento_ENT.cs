using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PH_ENT
{
    public class Departamento_ENT
    {
        private int idDepartamento;
        private string block;
        private int piso;
        private string numeroDepto;
        private string modelo;
        private int cantidad;
        private string codigoProducto;

        public Departamento_ENT()
        {
        }        

        public int IdDepartamento
        {
            get { return idDepartamento; }
            set { idDepartamento = value; }
        }
        
        public string Block
        {
            get { return block; }
            set { block = value; }
        }
        
        public int Piso
        {
            get { return piso; }
            set { piso = value; }
        }
        
        public string NumeroDepto
        {
            get { return numeroDepto; }
            set { numeroDepto = value; }
        }
        
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
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
