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
    public class OrderProcessor
    {
        private DataInMemory data;
        private readonly UnitWork unit;
        private IOrderConfirmation orderConfirmation;
        private readonly IProductManager productManager;
        private readonly IPaymentProcessor paymentProcessor;
        private readonly INotificationSender notificationSender;

        public OrderProcessor(DataInMemory data, UnitWork unit, IOrderConfirmation orderConfirmation, IProductManager productManager, IPaymentProcessor paymentProcessor, INotificationSender notificationSender)
        {
            this.data = data;
            this.unit = unit;
            this.productManager = productManager;
            this.paymentProcessor = paymentProcessor;
            this.orderConfirmation = orderConfirmation;
            this.notificationSender = notificationSender;
        }

        public async void PlaceOrder(string customerName, List<int> productIds, string paymentMethod)
        {
            decimal totalCost = 0;
            List<Product> orderedProducts = new List<Product>();
            
            foreach (int productId in productIds)
            {
                Product product = await unit.ProductGenericRepository.GetByIDAsync(productId);
                if (product != null && product.Quantity > 0)
                {
                    orderedProducts.Add(product);
                    totalCost += product.Price;
                    product.Quantity--;
                }
            }

            if (orderedProducts.Count > 0)
            {
                paymentProcessor.ProcessPayment(totalCost);
                Order order = new Order { CustomerName = customerName,   Products = orderedProducts, TotalCost = totalCost };
                await unit.OrderGenericRepository.AddAsync(order);
                data.MyOrders.Add(order);
                orderConfirmation.SendOrderConfirmationEmail(order);
            }
        }
    }
}
