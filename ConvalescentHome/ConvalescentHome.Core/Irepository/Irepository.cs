using ConvalescentHome.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvalescentHome.Core.Irepository
{
    public interface Irepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
        int IsExist(T code);
        bool Add(T b);
        bool Update(int id, T e);
        bool Delete(int id);
    }
}
