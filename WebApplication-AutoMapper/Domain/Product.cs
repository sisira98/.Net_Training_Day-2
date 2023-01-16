﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication_AutoMapper.Domain
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }
}