using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _08_11_2019WeekendTask.Models
{
    public class Project
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Boş qoyula bilməz")]
        [MaxLength(50, ErrorMessage = "MAksimum 50 xarakter ola bilər")]
        [Display(Name = "Ad")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Boş qoyula bilməz")]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [Required(ErrorMessage = "Boş qoyula bilməz")]
        [Column(TypeName ="Date")]
        [Display(Name = "Paylaşım Tarixi")]
        public DateTime PublishDate { get; set; }
        [Required(ErrorMessage = "Boş qoyula bilməz")]
        [Column(TypeName ="ntext")]
        [Display(Name ="Açıqlama")]
        public string Description { get; set; }

        public List<Category> Categories{ get; set; }

    }
}