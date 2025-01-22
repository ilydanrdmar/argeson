
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace argeson.Models




{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public string? ProductName { get; set; } = String.Empty;
        public int? ProductKodu { get; set; }

        public string? ProductDescription { get; set; } = String.Empty;
        public string? ProductPicture { get; set; }
        public int? ProductPrice { get; set; }
        public int? CategoryId { get; set; }
        

        virtual public Category? Category { get; set; }

        [NotMapped]
        public IFormFile? ImageUpload { get; set; }
   

        

    }



}
