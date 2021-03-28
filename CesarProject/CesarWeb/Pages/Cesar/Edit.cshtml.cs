using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CesarWeb.Data;
using CesarWeb.Models;

namespace CesarWeb.Pages.Cesar
{
    public class EditModel : PageModel
    {
        private readonly CesarWeb.Data.CesarWebContext _context;

        public EditModel(CesarWeb.Data.CesarWebContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CesarNum).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CesarNumExists(CesarNum.ID))
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

        private bool CesarNumExists(int id)
        {
            return _context.CesarNum.Any(e => e.ID == id);
        }
    }
}
