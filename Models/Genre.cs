using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crisan_AndreaMaria_project.Models
{
    public class Genre
    {
        public int ID { get; set; }
        public string GenreName { get; set; }
        public ICollection<MovieGenre> MovieGenres { get; set; }
    }
}
