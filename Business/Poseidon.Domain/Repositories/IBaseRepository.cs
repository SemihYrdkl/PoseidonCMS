using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Domain.Repositories
{
    public interface IBaseRepository<T>
    {
        void Insert(T entities);
        void Update(T entities);
        void Delete(T entities);
        T GetByID(int id);
        IList<T> GetList();
    }
}
