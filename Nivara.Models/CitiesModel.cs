﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Nivara.Models
{
    public class CitiesModel
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public int StateId { get; set; }
       
    }
}
