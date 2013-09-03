using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PH_ENT;
using PH_DAO;

namespace PH_BSS
{
    public class Casa_BSS
    {
        public Casa_BSS(){
        }

        public Casa_ENT insertCasa(Casa_ENT datosCasa)
        {
            Casa_ENT oCasa = new Casa_DAO().insert(datosCasa);
            return oCasa;
        }

        public int deleteCasa(Casa_ENT datosCasa)
        {
             int error = new Casa_DAO().delete(datosCasa);
             return error;
        }

        public Casa_ENT getCasaID(Casa_ENT datosCasa) {
            Casa_ENT oCasa = new Casa_DAO().getForIdCasa(datosCasa);
            return oCasa;
        }

        public int updateCasa(Casa_ENT datosCasa) 
        {
            return new Casa_DAO().update(datosCasa);
        }

    }
}
