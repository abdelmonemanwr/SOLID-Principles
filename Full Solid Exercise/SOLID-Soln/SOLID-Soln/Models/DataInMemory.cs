using System.Collections.Generic;

namespace SOLID_Soln.Models
{
    public class DataInMemory
    {
        private readonly List<Product> _myProducts;
        private readonly List<Order> _myOrders;

        public DataInMemory()
        {
            _myProducts = new List<Product>
            {
                new Product { Id = 1, Name = "Apple", Price = 25, Quantity = 20 },
                new Product { Id = 2, Name = "Mango", Price = 40, Quantity = 5 },
                new Product { Id = 3, Name = "Banana", Price = 15, Quantity = 30 }
            };

            _myOrders = new List<Order>
            {
                new Order
                {
                    CustomerName = "Men3m",
                    TotalCost = 240,
                    Products = new List<Product>
                    {
                        new Product { Id = 1, Name = "Apple", Price = 25, Quantity = 3 },
                        new Product { Id = 3, Name = "Mango", Price = 40, Quantity = 3 },
                        new Product { Id = 3, Name = "Banana", Price = 15, Quantity = 3 }
                    }
                },
                new Order
                {
                    CustomerName = "Magdy",
                    TotalCost = 200,
                    Products = new List<Product>
                    {
                        new Product { Id = 1, Name = "Apple", Price = 25, Quantity = 2 },
                        new Product { Id = 3, Name = "Banana", Price = 15, Quantity = 10 }
                    }
                }
            };
        }

        public List<Product> MyProducts => _myProducts;
        public List<Order> MyOrders => _myOrders;
    }
}
