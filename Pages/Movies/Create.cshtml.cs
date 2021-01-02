using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Crisan_AndreaMaria_project.Data;
using Crisan_AndreaMaria_project.Models;

namespace Crisan_AndreaMaria_project.Pages.Movies
{
    public class CreateModel : MovieGenresPageModel
    {
        private readonly Crisan_AndreaMaria_project.Data.Crisan_AndreaMaria_projectContext _context;

        public CreateModel(Crisan_AndreaMaria_project.Data.Crisan_AndreaMaria_projectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["ProductionCoID"] = new SelectList(_context.Set<ProductionCo>(), "ID", "ProductionCoName");
            ViewData["StarID"] = new SelectList(_context.Set<Star>(), "ID", "StarName");
            var movie = new Movie();
            movie.MovieGenres = new List<MovieGenre>();
            PopulateAssignedGenreData(_context, movie);

            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(string[] selectedGenres)
        {
            var newMovie = new Movie();
            if (selectedGenres != null)
            {
                newMovie.MovieGenres = new List<MovieGenre>();
                foreach (var gen in selectedGenres)
                {
                    var genToAdd = new MovieGenre
                    {
                        GenreID = int.Parse(gen)
                    };
                    newMovie.MovieGenres.Add(genToAdd);
                }
            }
            if (await TryUpdateModelAsync<Movie>(
            newMovie,
            "Movie",
            i => i.Title, i => i.Director,
            i => i.IMDBRatings, i => i.ReleaseDate, i => i.ProductionCoID, i => i.StarID))
            {
                _context.Movie.Add(newMovie);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            PopulateAssignedGenreData(_context, newMovie);
            return Page();
        }
    }
}
