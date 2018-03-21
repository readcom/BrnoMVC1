using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrnoMVC1.Web.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public Genres Genres { get; set; }

    }
}