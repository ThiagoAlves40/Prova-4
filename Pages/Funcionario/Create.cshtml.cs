using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Prova27_10.Data;

namespace Prova27_10.Pages.Recepcao
{
    public class CreateModel : PageModel
    {
        private readonly Prova27_10.Data.Prova27_10Context _context;

        public CreateModel(Prova27_10.Data.Prova27_10Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Funcionario Recepcao { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Recepcao.Add(Recepcao);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
