using infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Repo
{
    public class GenericRepo<T> : IgenericRepo<T> where T : class
    {
        private readonly AppDB _db;
        private readonly DbSet<T> table;

        public GenericRepo(AppDB db)
        {
            _db = db;
            table = _db.Set<T>();
        }


        public void Delete(object id)
        {
           T item = table.Find(id);
            
            table.Remove(item);
        }

        public T Get(object id)
        {
           return table.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public void Insert(T item)
        {
           table.Add(item);
        }

        public void Update(T item)
        {
            table.Attach(item);

            _db.Entry(item).State = EntityState.Modified;
        }
    }
}
