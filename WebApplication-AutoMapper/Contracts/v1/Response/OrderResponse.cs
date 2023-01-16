﻿namespace WebApplication_AutoMapper.Contracts.v1.Response
{
    public class OrderResponse
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public CustomerResponse Customer { get; set; }
        public List<OrderItemResponse> OrderItems { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
