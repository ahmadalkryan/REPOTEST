using Core.interfaces;
using infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Repo
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        private readonly AppDB _context;
        private readonly IgenericRepo<T> entity;

        public UnitOfWork(AppDB c )
        {
            _context = c;
        }

        public IgenericRepo<T> Entity()
        {
            return entity ?? (new GenericRepo<T>(_context));
        }


        public void Save()
        {
            _context.SaveChanges();
        } 
    }
}
