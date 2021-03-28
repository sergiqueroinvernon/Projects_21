using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CesarWeb.Data;
using CesarWeb.Models;

namespace CesarWeb.Pages.Cesar
{
    public class IndexModel : PageModel
    {
        private readonly CesarWeb.Data.CesarWebContext _context;

        public IndexModel(CesarWeb.Data.CesarWebContext context)
        {
            _context = context;
        }

        public IList<CesarNum> CesarNum { get;set; }

        public async Task OnGetAsync()
        {
            CesarNum = await _context.CesarNum.ToListAsync();
        }
    }
}
