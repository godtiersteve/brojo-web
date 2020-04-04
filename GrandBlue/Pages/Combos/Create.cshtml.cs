using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GrandBlue.Data;
using GrandBlue.Models;

namespace GrandBlue
{
    public class CreateModel : PageModel
    {
        private readonly GrandBlue.Data.GrandBlueContext _context;

        public CreateModel(GrandBlue.Data.GrandBlueContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Combo Combo { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Combo.Add(Combo);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
