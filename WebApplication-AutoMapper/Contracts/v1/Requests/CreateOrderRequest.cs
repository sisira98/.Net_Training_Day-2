namespace WebApplication_AutoMapper.Contracts.v1.Requests
{
    public class CreateOrderRequest
    {
        public int CustomerId { get; set; }
        public List<CreateOrderItemRequest> OrderItems { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
