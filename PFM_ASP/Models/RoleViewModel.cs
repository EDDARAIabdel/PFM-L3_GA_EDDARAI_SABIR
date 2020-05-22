using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PFM_ASP.Models
{
    public class RoleViewModel
    {
        public string Id { get; set; }
        [Display(Name = "Nom du role")]
        public string Name { get; set; }
    }
}