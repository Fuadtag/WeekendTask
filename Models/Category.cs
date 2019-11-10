using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _08_11_2019WeekendTask.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Boş qoyula bilməz")]
        [MaxLength(50, ErrorMessage ="Maksimum 50 xarakter ola bilər")]
        [Display(Name = "Ad")]
        public string Name { get; set; }
        
    }
}