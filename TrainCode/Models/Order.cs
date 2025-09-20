namespace TrainCode.Models
{
    public class Order
    {
        public int UserId { get; set; }
        public int ProductId { get;  set; }
        public int Quantity { get;  set; }
        public decimal TotalPrice { get;  set; }

        public Order()
        {
        }

        public Order(int userId, int productId, int quantity,decimal totalPrice)
        {
            UserId = userId;
            ProductId = productId;
            Quantity = quantity;
            TotalPrice = totalPrice;
        }
    }
}
