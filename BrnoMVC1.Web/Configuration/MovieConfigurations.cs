using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using BrnoMVC1.Web.Models;

namespace BrnoMVC1.Web.Configuration
{
    public class MovieConfigurations
    {

        public class MovieConfiguration : EntityTypeConfiguration<Movie>
        {
            public MovieConfiguration()
                : this("dbo")
            {
            }

            public MovieConfiguration(string schema)
            {
                this.ToTable(nameof(Movie), schema);

                this.HasKey(e => e.Id);

                this.Property(p => p.Title).HasMaxLength(64);
            }
        }
    }



}
