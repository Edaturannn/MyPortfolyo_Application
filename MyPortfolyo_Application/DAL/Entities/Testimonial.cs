﻿using System.ComponentModel.DataAnnotations;

namespace MyPortfolyo_Application.DAL.Entities
{
    public class Testimonial
    {
        [Key]
        public int TestimonialId { get; set; }

        [StringLength(200)]
        public string NameSurname { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(300)]
        public string ImageUrl { get; set; }
    }
}
