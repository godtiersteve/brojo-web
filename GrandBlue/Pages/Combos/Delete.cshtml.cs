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
    public class DeleteModel : PageModel
    {
        private readonly GrandBlue.Data.GrandBlueContext _context;

        public DeleteModel(GrandBlue.Data.GrandBlueContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Combo = await _context.Combo.FindAsync(id);

            if (Combo != null)
            {
                _context.Combo.Remove(Combo);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
