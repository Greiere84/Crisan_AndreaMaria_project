using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crisan_AndreaMaria_project.Models
{
    public class Star
    {
        public int ID { get; set; }
        public string StarName { get; set; }
        public string Description { get; set; }
        public ICollection<Movie> Movies { get; set; } //navigation property
    }
}
