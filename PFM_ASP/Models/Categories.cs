using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PFM_ASP.Models
{
    public class Categories
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Category Name")]
        public string CategoryName { get; set; }
        [Required]
        [Display(Name = "Description of the Category")]
        [AllowHtml]
        public string CategoryDescription { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}