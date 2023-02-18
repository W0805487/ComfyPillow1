using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ComfyPillow.Models
{
    public class PillowTypesViewModel
    {
        public List<Pillow> Pillows { get; set; }
        public SelectList Type { get; set; }
        public string PillowTypes { get; set; }
        public string SearchString { get; set; }
    }
}
