using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
  public  interface IBase<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        bool Add(T model);

        bool Update(T model);

        bool Delete(int id);

    }
}
