using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PH_ENT;
using PH_DAO;

namespace PH_BSS
{
    public class LocalComercial_BSS
    {
        public LocalComercial_BSS() { 
        }

        public LocalComercial_ENT insertLocalComercial(LocalComercial_ENT datosLocalComercial)
        {
            LocalComercial_ENT oLocalComercial = new LocalComercial_DAO().insert(datosLocalComercial);
            return oLocalComercial;
        }

        public void deleteLocalComercial(LocalComercial_ENT datosLocalComercial)
        {
            new LocalComercial_DAO().delete(datosLocalComercial);
        }

        public LocalComercial_ENT getLocalComercialID(LocalComercial_ENT datosLocalComercial)
        {
            LocalComercial_ENT oLocalComercial = new LocalComercial_DAO().getForIdLocalComercial(datosLocalComercial);
            return oLocalComercial;
        }
    }
}
