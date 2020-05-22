using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PFM_ASP.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Display(Name = "Book Title")]
        public string BookTitle { get; set; }
        [Display(Name = "Description of the Book")]
        [AllowHtml]
        public string BookDescription { get; set; }
        [Display(Name = "Book Image")]
        public string BookImage { get; set; }
        [Display(Name = "Book Url")]
        public string BookUrl { get; set; }
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public virtual Categories category { get; set; }
    }
}