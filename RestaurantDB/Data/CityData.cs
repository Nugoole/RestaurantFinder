using RestaurantDB.DB_jun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDB.Data
{
    public class CityData : EntityData<City>
    {
        public List<string> GetAllCitiesIn(int stateId)
        {
            using(RestaurantEntities context = new RestaurantEntities())
            {
                var query = from x in context.Cities
                            where x.StateId == stateId
                            select x.Name;

                
                return query.ToList();
            }
        }
    }
}
