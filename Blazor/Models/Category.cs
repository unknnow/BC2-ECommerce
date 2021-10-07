using System.ComponentModel.DataAnnotations;

namespace Blazor.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Libelle { get; set; }
    }
}