﻿using E_Commerce_Cake.Models.Database;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Cake.Models.ViewModel
{
    public class AddSubCategory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int SubCategoryId { get; set; }
    }
}
