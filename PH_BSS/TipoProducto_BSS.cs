using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PH_ENT;
using PH_DAO;

namespace PH_BSS
{
    public class TipoProducto_BSS
    {
        public TipoProducto_BSS(){
        }

        public TipoProducto_ENT getTipoProducto(int idTipoProducto) 
        {
            return new TipoProducto_DAO().getForIdTipoProducto(idTipoProducto);
        }
    }
}
