using System.Net.Mime;
using System;

namespace Blazor.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Produit
    {
        public int Id { get; set; }
        [Required]
        public string Libelle { get; set; }
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        public string img { get; set; }
        public DateTime DatePublish { get; set; }
        public DateTime SoldAt { get; set; }
        public bool Sold { get; set; }
        public User Seller { get; set; }
        public User Purchaser { get; set; }
        public Category Category { get; set; }
    }
}