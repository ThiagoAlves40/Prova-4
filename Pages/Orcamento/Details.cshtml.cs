using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Prova27_10.Data;

namespace Prova27_10.Pages.Orcamento
{
    public class DetailsModel : PageModel
    {
        private readonly Prova27_10.Data.Prova27_10Context _context;

        public DetailsModel(Prova27_10.Data.Prova27_10Context context)
        {
            _context = context;
        }

        public Orcamento Orcamento { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Orcamento = await _context.Orcamento.FirstOrDefaultAsync(m => m.ID == id);

            if (Orcamento == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
