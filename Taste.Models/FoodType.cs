using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Taste.Models
{
    public class FoodType
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
