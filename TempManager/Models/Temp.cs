using System;
using System.ComponentModel.DataAnnotations;

namespace TempManager.Models
{
    public class Temp
    {
        public int Id { get; set; }

        [Required]
        public DateTime? Date { get; set; }

        [Required]
        [Range(-200, 200)]
        public double? Low { get; set; }

        [Required]
        [Range(-200, 200)]
        public double? High { get; set; }
    }
}
