using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Crisan_AndreaMaria_project.Data;
using Crisan_AndreaMaria_project.Models;

namespace Crisan_AndreaMaria_project.Pages.Stars
{
    public class DetailsModel : PageModel
    {
        private readonly Crisan_AndreaMaria_project.Data.Crisan_AndreaMaria_projectContext _context;

        public DetailsModel(Crisan_AndreaMaria_project.Data.Crisan_AndreaMaria_projectContext context)
        {
            _context = context;
        }

        public Star Star { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Star = await _context.Star.FirstOrDefaultAsync(m => m.ID == id);

            if (Star == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
