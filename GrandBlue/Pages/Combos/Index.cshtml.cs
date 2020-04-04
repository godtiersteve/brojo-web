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
    public class IndexModel : PageModel
    {
        private readonly GrandBlue.Data.GrandBlueContext _context;

        public IndexModel(GrandBlue.Data.GrandBlueContext context)
        {
            _context = context;
        }

        public IList<Combo> Combo { get;set; }

        public async Task OnGetAsync()
        {
            Combo = await _context.Combo.ToListAsync();
        }
    }
}
