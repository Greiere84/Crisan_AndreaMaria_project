using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Crisan_AndreaMaria_project.Data;
using Crisan_AndreaMaria_project.Models;

namespace Crisan_AndreaMaria_project.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly Crisan_AndreaMaria_project.Data.Crisan_AndreaMaria_projectContext _context;

        public IndexModel(Crisan_AndreaMaria_project.Data.Crisan_AndreaMaria_projectContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get; set; }
        public MovieData MovieD { get; set; }
        public int MovieID { get; set; }
        public int GenreID { get; set; }
        public async Task OnGetAsync(int? id, int? genreID)
        {
            MovieD = new MovieData();
            MovieD.Movies = await _context.Movie
                .Include(b => b.ProductionCo)
                .Include(b => b.Star)
                .Include(b => b.MovieGenres)
                .ThenInclude(b => b.Genre)
                .AsNoTracking()
                .OrderBy(b => b.Title)
                .ToListAsync();

            if (id != null)
            {
                MovieID = id.Value;
                Movie movie = MovieD.Movies
                    .Where(i => i.ID == id.Value).Single();
                MovieD.Genres = movie.MovieGenres.Select(s => s.Genre);
            }
        }
    }
}
