using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Prova27_10.Data;

namespace Prova27_10.Pages.Estoque
{
    public class DetailsModel : PageModel
    {
        private readonly Prova27_10.Data.Prova27_10Context _context;

        public DetailsModel(Prova27_10.Data.Prova27_10Context context)
        {
            _context = context;
        }

        public Estoque Estoque { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Estoque = await _context.Estoque.FirstOrDefaultAsync(m => m.ID == id);

            if (Estoque == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
