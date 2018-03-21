using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BrnoMVC1.Web.Models
{
    public class MovieViewModel
    {
        
        public int Id { get; set; }
        [Display(Name = "Nazev: ")]
        [Required]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Zanr: ")]
        public Genres Genres { get; set; }
    }
}