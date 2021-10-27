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
    public class DeleteModel : PageModel
    {
        private readonly Prova27_10.Data.Prova27_10Context _context;

        public DeleteModel(Prova27_10.Data.Prova27_10Context context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Estoque = await _context.Estoque.FindAsync(id);

            if (Estoque != null)
            {
                _context.Estoque.Remove(Estoque);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
