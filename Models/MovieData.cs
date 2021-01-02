using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crisan_AndreaMaria_project.Models
{
    public class MovieData
    {
        public IEnumerable<Movie> Movies { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public IEnumerable<MovieGenre> MovieGenres { get; set; }
    }
}
