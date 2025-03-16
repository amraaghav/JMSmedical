using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace JMSmedical.Models
{
    public class Category
    {
        public string? Name { get; internal set; }
        public string? ImageUrl { get; internal set; }
        public string? Id { get; internal set; }
    }
}
