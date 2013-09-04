using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PH_ENT;
using PH_DAO;

namespace PH_BSS
{
    public class EstacionamientoBodega_BSS
    {
        public EstacionamientoBodega_BSS() { 
        }

        public EstacionamientoBodega_ENT insertEstacionamientoBodega(EstacionamientoBodega_ENT datosEstacionamientoBodega)
        {
            EstacionamientoBodega_ENT oEstacionamientoBodega = new EstacionamientoBodega_DAO().insert(datosEstacionamientoBodega);
            return oEstacionamientoBodega;
        }

        public void deleteEstacionamientoBodega(EstacionamientoBodega_ENT datosEstacionamientoBodega)
        {
            new EstacionamientoBodega_DAO().delete(datosEstacionamientoBodega);
        }

        public EstacionamientoBodega_ENT getEstacionamientoBodegaID(EstacionamientoBodega_ENT datosEstacionamientoBodega)
        {
            EstacionamientoBodega_ENT oEstacionamientoBodega = new EstacionamientoBodega_DAO().getForIdEstacionamientoBodega(datosEstacionamientoBodega);
            return oEstacionamientoBodega;
        }

        public int updateEstacionamientoBodega(EstacionamientoBodega_ENT datosEstacionamientoBodega) 
        {
            return new EstacionamientoBodega_DAO().update(datosEstacionamientoBodega);
        }

        public EstacionamientoBodega_ENT generaCodigo(string codigo)
        {
            string codigoProducto;
            EstacionamientoBodega_ENT oEstaBode = new EstacionamientoBodega_ENT();
            oEstaBode = new EstacionamientoBodega_DAO().insertEstacionamientoBodega(codigo);

            int cantidad = oEstaBode.Cantidad;

            if (cantidad.ToString().Length == 1)
            {
                codigoProducto = codigo + "00" + cantidad;
            }
            else if (cantidad.ToString().Length == 2)
            {
                codigoProducto = codigo + "0" + cantidad;
            }
            else
            {
                codigoProducto = codigo + cantidad;
            }

            oEstaBode.CodigoProducto = codigoProducto;

            return oEstaBode;
        }
    }
}
