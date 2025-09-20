
using TrainCode.Log;
using TrainCode.Models;

namespace TrainCode.DB
{
    public class OrderRespository
    {
        private List<Order> orders=new List<Order>();
        public List<Order> saveOrder(int userId, int  productId, int quantity, decimal totalPrice)
        {
            orders.Add(new Order { UserId= userId, ProductId = productId, Quantity = quantity, TotalPrice = totalPrice });
            return orders;
        }
            

        
    }
}
