namespace TrainCode.Status
{
    public class StatusOrder
    {
        public void StatusOrDer( )
        {
            var stats = new Dictionary<string, int>();
        stats["TotalOrders"] = stats.GetValueOrDefault("TotalOrders") + 1;
        }
    }
}
