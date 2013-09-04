using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PH_ENT;
using PH_DAO;

namespace PH_BSS
{
    public class Ciudad_BSS
    {
        public List<Ciudad_ENT> getAllByIdRegion(string idRegion)
        {
            return new Ciudad_DAO().listCiudadForIdRegion(idRegion);
        }

        public Ciudad_ENT getById(Ciudad_ENT ciudad)
        {
            return new Ciudad_DAO().getForIdCiudad(ciudad);
        }
    }
}
