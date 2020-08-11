using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Controleur
{
  public  class RegionCTRL : ContextSaison
    {

        public List<region> GetRegionListFromDB()
        {
            return context.regions.ToList();

         
        }

        public Dictionary<int,string> GetFromDB()
        {
            var list = context.regions.ToList();

           Dictionary<int,string> dict = list.ToDictionary(x => x.CODE_REGION,x=>x.NOM_REGION);

            return dict;
        }

        public region GetRegion(int code_region)
        {
            return context.regions.Find(code_region);
        }
        
        public int AddToDB(region r)
        {
            context.regions.Add(r);
            context.SaveChanges();

            return r.CODE_REGION; 
        }

        public int DeleteDB(region r)
        {
            region region = context.regions.Find(r.CODE_REGION);
            context.regions.Remove(region);
            return context.SaveChanges();
        }

        public int UpdateDB(region r)
        {
            region region = context.regions.Find(r.CODE_REGION);
            region.NOM_REGION = r.NOM_REGION;
            return context.SaveChanges();
        }

    }
}
