using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoreTest.Data;
using CoreTest.Models;

namespace CoreTest.Pages.Movie
{
    public class DetailsModel : PageModel
    {
#pragma warning disable CS8618
#pragma warning disable CS8604
        private readonly CoreTest.Data.CoreTestContext _context;

        public DetailsModel(CoreTest.Data.CoreTestContext context)
        {
            _context = context;
        }

        public Models.Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
