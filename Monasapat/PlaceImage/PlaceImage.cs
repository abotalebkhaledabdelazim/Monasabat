﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monasapat.Models
{
    public class PlaceImage
    {
        public int ID { get; set; }
        public string Path { get; set; }
        [ForeignKey("Place")]
        public int PlaceID { get; set; }

        //navigation
        public virtual Place Place { get; set; }
    }
}
