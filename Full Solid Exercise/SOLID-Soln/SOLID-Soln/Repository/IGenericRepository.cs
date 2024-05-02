using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Soln.Repository
{
    public interface IGenericRepository<Entity>
    {
        public Task<Entity> GetByIDAsync(int id);
        public Task<Entity> AddAsync(Entity obj);
        public Task<int> SaveChangesAsyc();
    }
}
