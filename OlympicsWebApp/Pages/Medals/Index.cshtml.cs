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
    public class IndexModel : PageModel
    {
        private readonly OlympicsWebApp.Data.OlympicsDataContext _context;

        public IndexModel(OlympicsWebApp.Data.OlympicsDataContext context)
        {
            _context = context;
        }

        public IList<Medal> Medal { get;set; }

        public async Task OnGetAsync()
        {
            Medal = await _context.Medals
                .Include(m => m.Country).ToListAsync();
        }
    }
}
