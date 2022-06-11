using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    interface IGenericService<T> where T: class
    {
        void add(T entity);
        void delete(T entity);
        void update(T entity);
        List<T> getAll();
        T getById(int id);

    }
}
