﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Prova27_10.Data;

namespace Prova27_10.Pages.Estoque
{
    public class IndexModel : PageModel
    {
        private readonly Prova27_10.Data.Prova27_10Context _context;

        public IndexModel(Prova27_10.Data.Prova27_10Context context)
        {
            _context = context;
        }

        public IList<Estoque> Estoque { get;set; }

        public async Task OnGetAsync()
        {
            Estoque = await _context.Estoque.ToListAsync();
        }
    }
}
