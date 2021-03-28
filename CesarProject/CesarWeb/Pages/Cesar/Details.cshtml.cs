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
    public class DetailsModel : PageModel
    {
        private readonly CesarWeb.Data.CesarWebContext _context;

        public DetailsModel(CesarWeb.Data.CesarWebContext context)
        {
            _context = context;
        }

        public CesarNum CesarNum { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CesarNum = await _context.CesarNum.FirstOrDefaultAsync(m => m.ID == id);

            if (CesarNum == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
