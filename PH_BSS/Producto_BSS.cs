using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PH_ENT;
using PH_DAO;

namespace PH_BSS
{
    public class Producto_BSS
    {
        public Producto_BSS()
        {
        }

        public Producto_ENT insert(Producto_ENT datosProducto) {
            Producto_ENT oProducto = new Producto_DAO().insert(datosProducto);
            return oProducto;
        }

        public List<Producto_ENT> listAllProductos() {
            List<Producto_ENT> listaProductos = new Producto_DAO().listProducto();
            return listaProductos;
        }

        public Producto_ENT getProductoID(Producto_ENT datosProducto){
            Producto_ENT oProducto = new Producto_DAO().getForIdProducto(datosProducto);
            return oProducto;
        }

        public int deleteProducto(Producto_ENT datosProducto) 
        {
            return new Producto_DAO().delete(datosProducto);
        }

    }
}
