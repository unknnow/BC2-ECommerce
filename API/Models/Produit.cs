using System.Net.Mime;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace API.Models
{
    public class Produit
    {
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Libelle { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Img { get; set; }
        public DateTime DatePublish { get; set; }
        public DateTime SoldAt { get; set; }
        public bool Sold { get; set; }

        [ForeignKey("Seller")]
        public int SellerId { get; set; }
        public User Seller { get; set; }

        [ForeignKey("Purchaser")]
        public int PurchaserId { get; set; }
        public User Purchaser { get; set; }

        [ForeignKey("Category")]
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
    }
}