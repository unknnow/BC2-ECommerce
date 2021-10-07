using System.Net.Mime;
using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace API.Models
{
    public class Produit
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Img { get; set; }
        public DateTime DatePublish { get; set; }
        public DateTime SoldAt { get; set; }
        public bool Sold { get; set; }
        public User Seller { get; set; }
        public User Purchaser { get; set; }
        public Category Category { get; set; }
    }
}