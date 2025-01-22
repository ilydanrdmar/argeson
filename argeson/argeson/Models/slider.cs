using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace argeson.Models

{
    public class Slider
    {
        [Key]
        public int SliderId { get; set; }
        public string? SliderName { get; set; } = String.Empty;
        public string? Header1 { get; set; } = String.Empty;
        public string? Header2 { get; set; } = String.Empty;
        public string? Context { get; set; } = String.Empty;
        public string? SliderImage { get; set; } = String.Empty;

        [NotMapped]

        public IFormFile? ImageUpload { get; set; }
    }

}
