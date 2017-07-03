namespace NServiceBus.Messages
{
    public class PlaceOrder :
        ICommand
    {
        public string OrderId { get; set; }
    }
}
