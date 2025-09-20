namespace TrainCode.ECommere
{

    public class Order
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }

    public class OrderManager
    {
        private readonly List<Order> _orders = new List<Order>();

        public void CreateOrder(int userId, int productId, int quantity, decimal totalPrice)
        {
            // Validate
            if (userId <= 0 || productId <= 0 || totalPrice < 0)
                throw new ArgumentException("Invalid order data.");

            // Lưu DB
            var order = new Order { UserId = userId, ProductId = productId, Quantity = quantity, TotalPrice = totalPrice };
            _orders.Add(order);

            // Log
            Console.WriteLine($"Order created: UserId={userId}, ProductId={productId}");

            // Notify
            Console.WriteLine($"Sent email to user {userId}");

            // Stats
            var stats = new Dictionary<string, int>();
            stats["TotalOrders"] = stats.GetValueOrDefault("TotalOrders") + 1;
        }
    }
}
 