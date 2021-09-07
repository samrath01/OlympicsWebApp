using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OlympicsWebApp.BusinessLayer;
using OlympicsWebApp.Data;

namespace OlympicsWebApp.Pages.Medals
{
    public class DeleteModel : PageModel
    {
        private readonly OlympicsWebApp.Data.OlympicsDataContext _context;

        public DeleteModel(OlympicsWebApp.Data.OlympicsDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Medal Medal { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Medal = await _context.Medals
                .Include(m => m.Country).FirstOrDefaultAsync(m => m.Id == id);

            if (Medal == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Medal = await _context.Medals.FindAsync(id);

            if (Medal != null)
            {
                _context.Medals.Remove(Medal);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
