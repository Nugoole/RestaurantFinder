using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDB.DB_jun
{
    public class DB<T> where T : class
    {
        static DB()
        {

        }

        public static List<T> GetAll()
        {
            using(DbContext context = new RestaurantEntities())
            {
                return context.Set<T>().ToList();
            }
        }

        public static void Insert()
        {
            using(DbContext context = new RestaurantEntities())
            {

            }
        }

    }
}
