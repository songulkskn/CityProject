﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehirRehberi.API.Models
{ // 1 fotografın 1 tane şehri vardır * 1-1 kuramı*
    public class Photo
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public bool IsMain { get; set; }
        public string PublicId { get; set; }
        public DateTime DateAdded { get; set; }
        // bu fotograf hangı sehrın fotografı onun ıcın bu yapı
        public  City Ciyt { get; set; }
    }
}
