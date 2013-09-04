using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PH_ENT;
using PH_DAO;

namespace PH_BSS
{
    public class Region_BSS
    {
        public List<Region_ENT> getAll()
        {
            return new Region_DAO().listRegion();
        }

        public Region_ENT getById(Region_ENT region)
        {
            return new Region_DAO().getForIdRegion(region);
        }
    }
}
