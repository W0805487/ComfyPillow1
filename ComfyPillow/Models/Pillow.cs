﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ComfyPillow.Models
{
    public class Pillow
    {
        public int Id { get; set; }
        public string material { get; set; }
        public string Types { get; set; }
        public string size { get; set; }


        public string color { get; set; }
        public decimal Price { get; set; }
    }
}