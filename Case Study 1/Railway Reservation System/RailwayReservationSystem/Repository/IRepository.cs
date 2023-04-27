using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailwayReservationSystem.Repository
{
    public interface IRepository<T1,T2> where T2 : class
    {
        Task<IEnumerable<T1>> GetAll();
        Task<T1> GetById(T2 id);
        Task<T1> Insert(T1 entity);
        Task<T1> Update(T1 entity);
        Task DeleteById(T2 id);
        Task Save();
    }
}
