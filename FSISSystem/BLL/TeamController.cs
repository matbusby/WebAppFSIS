using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSISSystem.DAL;
using FSISSystem.ENTITIES;

namespace NWSystem.BLL
{
    public class RegionController
    {
        public Region Regions_FindByID(int regionid)
        {
            using (var context = new NWContext())
            {
                return context.Regions.Find(regionid);
            }
        }
    }
}
