﻿using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public List<Character> Characters { get; set; }
    }
}
