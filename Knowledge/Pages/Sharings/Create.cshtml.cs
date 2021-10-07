using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Knowledge.Models;

namespace Knowledge.Pages_Sharings
{
    public class CreateModel : PageModel
    {
        private readonly KnowledgeSharingContext _context;

        public CreateModel(KnowledgeSharingContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Sharing Sharing { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Sharing.Add(Sharing);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
