﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApplication_AutoMapper.Contracts.v1.Response;
using WebApplication_AutoMapper.Contracts.v1.Requests;
using WebApplication_AutoMapper.Domain;
using WebApplication_AutoMapper.Services;

namespace WebApplication_AutoMapper.Controllers.v1;

public class CustomerController : Controller
{
    private readonly ICustomerService _customerService;
    private readonly IMapper _mapper;

    public CustomerController(ICustomerService customerService, IMapper mapper)
    {
        _customerService = customerService;
        _mapper = mapper;
    }

    [HttpGet("/api/v1/customers")]
    public async Task<IActionResult> GetAll()
    {
        var customers = await _customerService.GetCustomersAsync();
        var customersResponse = _mapper.Map<List<CustomerResponse>>(customers);
        return Ok(customersResponse);
    }

    [HttpGet("/api/v1/customers/{customerId}")]
    public async Task<IActionResult> GetAll([FromRoute] int customerId)
    {
        var customer = await _customerService.GetCustomerAsync(customerId);

        if (customer == null) return NotFound("No record found");

        var customerResponse = _mapper.Map<CustomerResponse>(customer);
        return Ok(customerResponse);
    }

    [HttpPost("api/v1/customers")]
    public async Task<IActionResult> Create([FromBody] CreateCustomerRequest createCustomerRequest)
    {
        var customer = new Customer
        {
            FirstName = createCustomerRequest.FirstName,
            LastName = createCustomerRequest.LastName
        };
        await _customerService.CreateCustomerAsync(customer);
        var customerResponse = _mapper.Map<CustomerResponse>(customer);
        var uri = "api/v1/customers/" + customer.CustomerId;
        return Created(uri, customerResponse);
    }
}