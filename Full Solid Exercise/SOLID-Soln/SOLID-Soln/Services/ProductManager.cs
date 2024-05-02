using SOLID_Soln.Interface;
using SOLID_Soln.Models;
using SOLID_Soln.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Soln.Services
{
    public class ProductManager : IProductManager
    {
        private readonly UnitWork unit;

        public ProductManager(UnitWork unit)
        {
            this.unit = unit;
        }

        /* Note: I've converted the signature of the method from being 
            public void AddProduct(string name, decimal price, int quantity)
                to be like that
            public void AddProduct(Product product)  */
        
        public void AddProduct(Product product)
        {
            unit.ProductGenericRepository.AddAsync(product);
        }
    }
}
