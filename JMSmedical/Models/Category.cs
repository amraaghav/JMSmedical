﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace JMSmedical.Models
{
    public class Category
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string ImageUrl { get; set; }
        public int Price { get; set; }
        public int MRP { get; set; }
        public int Discount { get; set; }
        public double Rating { get; set; }
        public int Reviews { get; set; }
        public required string Badge { get; set; }
        public required string TimeLeft { get; set; }
        public required string Quantity { get; set; }

    }
}
