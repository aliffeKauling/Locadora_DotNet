using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Locadora.Data;
using Locadora.Model;

namespace Locadora.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly Locadora.Data.LocadoraContext _context;

        public IndexModel(Locadora.Data.LocadoraContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
