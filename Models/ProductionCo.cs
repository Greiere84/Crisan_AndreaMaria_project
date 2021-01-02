using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crisan_AndreaMaria_project.Models
{
    public class ProductionCo
    {
        public int ID { get; set; }
        public string ProductionCoName { get; set; }
        public ICollection<Movie> Movies { get; set; } //navigation property
    }
}
