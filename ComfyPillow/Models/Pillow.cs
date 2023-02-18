
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ComfyPillow.Models
{
    public class Pillow
    {
        public int Id { get; set; }
        public string material { get; set; }
        public string Types { get; set; }
        public string size { get; set; }


        public string color { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        public int Rating { get; set; }
    }
}
