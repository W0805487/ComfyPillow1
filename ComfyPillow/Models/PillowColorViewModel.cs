using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ComfyPillow.Models
{
    public class PillowColorViewModel
    {

        public List<Pillow> Pillows { get; set; }
        public SelectList Colors { get; set; }
        public string PillowColor { get; set; }
        public string SearchString { get; set; }

    }
}
