using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GrandBlue.Data;
using GrandBlue.Models;

namespace GrandBlue
{
    public class DetailsModel : PageModel
    {
        private readonly GrandBlue.Data.GrandBlueContext _context;

        public DetailsModel(GrandBlue.Data.GrandBlueContext context)
        {
            _context = context;
        }

        public Combo Combo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Combo = await _context.Combo.FirstOrDefaultAsync(m => m.ID == id);

            if (Combo == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
