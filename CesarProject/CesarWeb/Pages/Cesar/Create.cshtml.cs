using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CesarWeb.Data;
using CesarWeb.Models;

namespace CesarWeb.Pages.Cesar
{
    public class CreateModel : PageModel
    {
        private readonly CesarWeb.Data.CesarWebContext _context;

        public CreateModel(CesarWeb.Data.CesarWebContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }
     
        [BindProperty]
        public CesarNum CesarNum { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            Models.Cesar cesar = new Models.Cesar();
     
            if (!ModelState.IsValid)
            {
                return Page();
            }
            

            _context.CesarNum.Add(CesarNum);
            
          
            await _context.SaveChangesAsync();


            return RedirectToPage("./Index");
        }
    }
}
