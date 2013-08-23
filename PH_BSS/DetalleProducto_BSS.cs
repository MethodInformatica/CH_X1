using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PH_DAO;
using PH_ENT;

namespace PH_BSS
{
    public class DetalleProducto_BSS
    {

        public DetalleProducto_BSS() { 
        }

        public DetalleProducto_ENT insertDetalleProducto(DetalleProducto_ENT datosDetalleProducto)
        {
            DetalleProducto_ENT oDetalleProducto = new DetalleProducto_DAO().insert(datosDetalleProducto);
            return oDetalleProducto;
        }

        public void deleteDetalleProducto(DetalleProducto_ENT datosDetalleProducto)
        {
            new DetalleProducto_DAO().delete(datosDetalleProducto);
        }

        public DetalleProducto_ENT getProductoDetalleIdProducto(DetalleProducto_ENT datosDetalleProducto)
        {
            DetalleProducto_ENT oDetalleProducto = new DetalleProducto_DAO().getForIdProducto(datosDetalleProducto);
            return oDetalleProducto;
        }

    }
}
