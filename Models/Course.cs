﻿using System.ComponentModel.DataAnnotations;

namespace u21503193_HW01_API.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        public string Name { get; set; }

        public string Duration { get; set; }
        
        public string Description { get; set; }
    }
}
