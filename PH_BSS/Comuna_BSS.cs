using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PH_ENT;
using PH_DAO;

namespace PH_BSS
{
    public class Comuna_BSS
    {
        public Comuna_ENT insertComuna(Comuna_ENT datosComuna)
        {
            Comuna_ENT oComuna = new Comuna_DAO().insert(datosComuna);
            return oComuna;
        }

        public int deleteComuna(Comuna_ENT datosComuna)
        {
            int error = new Comuna_DAO().delete(datosComuna);
            return error;
        }

        public Comuna_ENT getComunaID(Comuna_ENT datosComuna)
        {
            Comuna_ENT oComuna = new Comuna_DAO().getForIdComuna(datosComuna);
            return oComuna;
        }
    }
}
