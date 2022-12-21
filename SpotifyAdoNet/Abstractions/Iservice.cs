using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONET.Abstractions
{
    interface IService<T>
    {
        void Add(T model);
        void Delete(int Id);
        List<T> GetAll();
        void Update (T model);  
        T GetById(int Id);
    }
}

