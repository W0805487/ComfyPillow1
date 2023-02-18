
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ComfyPillow.Models
{
    public class Pillow
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required] 
        public string material { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required] 
        public string Types { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required] 
        public string size { get; set; }


        [StringLength(60, MinimumLength = 3)]
        [Required] 
        public string color { get; set; }
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        [Range(1,5)]
        public int Rating { get; set; }
    }
}
