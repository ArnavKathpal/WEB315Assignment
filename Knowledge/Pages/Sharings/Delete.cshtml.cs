using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Knowledge.Models;

namespace Knowledge.Pages_Sharings
{
    public class DeleteModel : PageModel
    {
        private readonly KnowledgeSharingContext _context;

        public DeleteModel(KnowledgeSharingContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Sharing Sharing { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Sharing = await _context.Sharing.FirstOrDefaultAsync(m => m.ID == id);

            if (Sharing == null)
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

            Sharing = await _context.Sharing.FindAsync(id);

            if (Sharing != null)
            {
                _context.Sharing.Remove(Sharing);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
