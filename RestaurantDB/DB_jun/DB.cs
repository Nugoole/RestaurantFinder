using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RestaurantDB.DB_jun
{
    public class DB<T> where T : class
    {
        static DB()
        {

        }

        public static List<T> GetAll()
        {
            using (RestaurantEntities context = new RestaurantEntities())
            {
                return context.Set<T>().ToList();
            }
        }

        public static bool Insert(T reservation)
        {
            using (DbContext context = new RestaurantEntities())
            {
                
                context.Set<T>().Add(reservation);

                try
                {
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    if (e != null)
                        return false;
                }
                return true;
            }
        }

    }
}
