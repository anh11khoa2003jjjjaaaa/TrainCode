namespace TrainCode.Validator
{
    public class Validate
    {
        public void IsValidateOder( int userId, int productId,decimal totalPrice)
        {
            if (userId <= 0 || productId <= 0 || totalPrice < 0)
                throw new ArgumentException("Invalid order data.");
           
        }
    }
}
