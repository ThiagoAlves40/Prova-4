using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Prova27_10.Data;

namespace Prova27_10.Pages.Orcamento
{
    public class EditModel : PageModel
    {
        private readonly Prova27_10.Data.Prova27_10Context _context;

        public EditModel(Prova27_10.Data.Prova27_10Context context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Orcamento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrcamentoExists(Orcamento.ID))
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

        private bool OrcamentoExists(int id)
        {
            return _context.Orcamento.Any(e => e.ID == id);
        }
    }
}
