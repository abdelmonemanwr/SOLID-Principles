using Microsoft.EntityFrameworkCore;
using SOLID_Soln.Models;
using SOLID_Soln.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Soln.Repository
{
    public class GenericRepository<Entity> : IGenericRepository<Entity> where Entity : class
    {
        //UnitWork unit;
        EcommerceContext db;
        public GenericRepository(EcommerceContext db /*,UnitWork unit*/ )
        {
            this.db = db;
            //this.unit = unit;
        }

        public async Task<Entity> GetByIDAsync(int id)
        {
            return await db.Set<Entity>().FindAsync(id);
        }

        public async Task<Entity> AddAsync(Entity obj)
        {
            db.Set<Entity>().Add(obj);
            return obj;
        }

        public async Task<int> SaveChangesAsyc()
        {
            int affectedRows = await db.SaveChangesAsync();
            Console.WriteLine($"affected rows  = {affectedRows} :)");
            return affectedRows;
        }
    }
}
