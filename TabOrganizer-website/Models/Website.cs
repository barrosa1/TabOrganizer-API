﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TabOrganizer_website.Models
{
    public class Website
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Link { get; set; }
        public string Comment { get; set; }
        public DateTime DateAdded { get; set; }

        public int ContainerId { get; set; }
        public Container Container { get; set; }
    }
}
