using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OlympicsWebApp.BusinessLayer;
using OlympicsWebApp.Data;

namespace OlympicsWebApp.Pages.Medals
{
    public class CreateModel : PageModel
    {
        private readonly OlympicsWebApp.Data.OlympicsDataContext _context;

        public CreateModel(OlympicsWebApp.Data.OlympicsDataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CountryID"] = new SelectList(_context.Countries, "Id", "CountryName");
            return Page();
        }

        [BindProperty]
        public Medal Medal { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Medals.Add(Medal);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
