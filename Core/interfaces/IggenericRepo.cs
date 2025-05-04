using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Repo
{
    public interface IgenericRepo<T> where T : class
    { 
        public IEnumerable<T> GetAll();
        public T Get(Object id);

        public void Insert (T item);

        public void Update (T item);    

        public void Delete (Object id);    
    }
}
