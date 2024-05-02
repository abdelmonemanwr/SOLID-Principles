using SOLID_Soln.Models;
using SOLID_Soln.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Soln.UnitOfWork
{
    public class UnitWork
    {
        EcommerceContext db;
        
        private IGenericRepository<Order> orderGenericRepository;
        
        private IGenericRepository<Product> productGenericRepository;
        
        public UnitWork(EcommerceContext db, IGenericRepository<Order> orderGenericRepository, IGenericRepository<Product>  productGenericRepository) 
        {
            this.db = db;
            this.orderGenericRepository = orderGenericRepository;
            this.productGenericRepository = productGenericRepository;
        }

        public IGenericRepository<Product> ProductGenericRepository
        {
            get
            {
                return productGenericRepository ?? (productGenericRepository = new GenericRepository<Product>(db));
            }
        }

        public IGenericRepository<Order> OrderGenericRepository
        {
            get
            {
                return orderGenericRepository ?? (orderGenericRepository = new GenericRepository<Order>(db));
            }
        }

    }
}
