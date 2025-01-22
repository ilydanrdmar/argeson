using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace argeson.Models


{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        virtual public List<Products>? Products { get; set; }
    }
}