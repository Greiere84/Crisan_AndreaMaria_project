using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Crisan_AndreaMaria_project.Data;
using Crisan_AndreaMaria_project.Models;

namespace Crisan_AndreaMaria_project.Pages.ProductionCompanies
{
    public class IndexModel : PageModel
    {
        private readonly Crisan_AndreaMaria_project.Data.Crisan_AndreaMaria_projectContext _context;

        public IndexModel(Crisan_AndreaMaria_project.Data.Crisan_AndreaMaria_projectContext context)
        {
            _context = context;
        }

        public IList<ProductionCo> ProductionCo { get; set; }

        public async Task OnGetAsync()
        {
            ProductionCo = await _context.ProductionCo.ToListAsync();
        }
    }
}
