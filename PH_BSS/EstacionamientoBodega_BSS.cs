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
    }
}
