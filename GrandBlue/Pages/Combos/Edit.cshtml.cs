using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GrandBlue.Data;
using GrandBlue.Models;

namespace GrandBlue
{
    public class EditModel : PageModel
    {
        private readonly GrandBlue.Data.GrandBlueContext _context;

        public EditModel(GrandBlue.Data.GrandBlueContext context)
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Combo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComboExists(Combo.ID))
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

        private bool ComboExists(int id)
        {
            return _context.Combo.Any(e => e.ID == id);
        }
    }
}
