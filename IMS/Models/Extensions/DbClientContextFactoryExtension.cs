using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Models.Extensions
{
    static class DbClientContextFactoryExtension
    {
        internal static IQueryable<Entity> Where<Entity>(this IQueryable<Entity> queryable, Predicate<Entity> Predicate) where Entity : class
        {
            ICollection<Entity> temp = new List<Entity>();

            Parallel.ForEach(queryable, (record) =>
            {
                if (Predicate(record))
                {
                    temp.Add(record);
                }
            });
            return temp.AsQueryable();
        }

        internal static IQueryable<Entity> Where<Entity>(this IQueryable<Entity> queryable, Expression<Func<Entity, bool>> Expression) where Entity : class
        {
            Func<Entity, bool> func = Expression.Compile();
            Predicate<Entity> pred = func.Invoke;
            return queryable.Where(pred);
        }
    }
}
