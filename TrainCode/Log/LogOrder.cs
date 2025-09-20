namespace TrainCode.Log
{
    public class LogOrder
    {

        public void LogODer(int userId, int productId)
        {
            Console.WriteLine($"Order created: UserId={userId}, ProductId={productId}");
        }
    }
}
