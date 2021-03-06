﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace J_LearingSystem.Models
{
     public class Video : BaseEntity
    {
        [Required]
        public string FileName { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public DateTime Time { get; set; }

        [Required]
        public virtual Course Course { get; set; }
    }
}
