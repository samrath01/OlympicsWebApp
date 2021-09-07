using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OlympicsWebApp.BusinessLayer;
using OlympicsWebApp.Data;

namespace OlympicsWebApp.Pages.Medals
{
    public class EditModel : PageModel
    {
        private readonly OlympicsWebApp.Data.OlympicsDataContext _context;

        public EditModel(OlympicsWebApp.Data.OlympicsDataContext context)
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
           ViewData["CountryID"] = new SelectList(_context.Countries, "Id", "CountryName");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Medal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MedalExists(Medal.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MedalExists(int id)
        {
            return _context.Medals.Any(e => e.Id == id);
        }
    }
}
