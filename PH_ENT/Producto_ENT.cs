using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PH_ENT
{
    public class Producto_ENT
    {
        private int idProducto;
        private string codigoProducto;
        private int idTipoProducto;
        private int idConjuntoHabitacional;
        private string rutCliente;
        private int idReferencia;

        public int IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }
        
        public string CodigoProducto
        {
            get { return codigoProducto; }
            set { codigoProducto = value; }
        }
        
        public int IdTipoProducto
        {
            get { return idTipoProducto; }
            set { idTipoProducto = value; }
        }
        
        public int IdConjuntoHabitacional
        {
            get { return idConjuntoHabitacional; }
            set { idConjuntoHabitacional = value; }
        }
        
        public string RutCliente
        {
            get { return rutCliente; }
            set { rutCliente = value; }
        }
        
        public int IdReferencia
        {
            get { return idReferencia; }
            set { idReferencia = value; }
        }
    }
}
