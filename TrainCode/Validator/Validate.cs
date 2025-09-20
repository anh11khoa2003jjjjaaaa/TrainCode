namespace TrainCode.Validator
{
    public class Validate
    {
        public bool IsValidateOder( int userId, int productId,decimal totalPrice)
        {
            if (userId <= 0 || productId <=0 || totalPrice == 0) return true;
            return false;
        }
    }
}
