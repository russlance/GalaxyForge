namespace GalaxyForge.Models
{
    public class GalacticSectorDataAccessLayer
    {
        private GalaxyContext context = new GalaxyContext();

        public IEnumerable<GalacticSector> GetAllGalacticSectors()
        {
            try
            {
                return context.GalacticSectors.ToList();
            }
            catch
            {
                throw;
            }
        }

        public interface IGenericDataRepository<T> where T : class
        {
            /*
                         public virtual IList<T> GetAll(params Expression<Func<T, object>>[] navigationProperties)
                        {
                            List<T> list;
                            using (var context = new Entities())
                            {
                                IQueryable<T> dbQuery = context.Set<T>();

                                //Apply eager loading
                                foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                                    dbQuery = dbQuery.Include<T, object>(navigationProperty);

                                list = dbQuery
                                    .AsNoTracking()
                                    .ToList<T>();
                            }
                            return list;
                        }*/

            /*
                         public virtual IList<T> GetList(Func<T, bool> where,
                             params Expression<Func<T, object>>[] navigationProperties)
                        {
                            List<T> list;
                            using (var context = new Entities())
                            {
                                IQueryable<T> dbQuery = context.Set<T>();

                                //Apply eager loading
                                foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                                    dbQuery = dbQuery.Include<T, object>(navigationProperty);

                                list = dbQuery
                                    .AsNoTracking()
                                    .Where(where)
                                    .ToList<T>();
                            }
                            return list;
                        }
             */

            /*
                         public virtual T GetSingle(Func<T, bool> where,
                             params Expression<Func<T, object>>[] navigationProperties)
                        {
                            T item = null;
                            using (var context = new Entities())
                            {
                                IQueryable<T> dbQuery = context.Set<T>();

                                //Apply eager loading
                                foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                                    dbQuery = dbQuery.Include<T, object>(navigationProperty);

                                item = dbQuery
                                    .AsNoTracking() //Don't track any changes for the selected item
                                    .FirstOrDefault(where); //Apply where clause
                            }
                            return item;
                        }
             */

            void Add(params T[] items);

            void Update(params T[] items);

            void Remove(params T[] items);
        }
    }
}