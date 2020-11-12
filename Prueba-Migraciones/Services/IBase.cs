using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_Migraciones.Services
{
    public interface IBase<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        bool Add(T model);

        bool Update(T model);

        bool Delete(int id);

    }
}

