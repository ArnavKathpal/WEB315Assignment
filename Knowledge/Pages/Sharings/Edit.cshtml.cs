using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Knowledge.Models;

namespace Knowledge.Pages_Sharings
{
    public class EditModel : PageModel
    {
        private readonly KnowledgeSharingContext _context;

        public EditModel(KnowledgeSharingContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Sharing).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SharingExists(Sharing.ID))
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

        private bool SharingExists(int id)
        {
            return _context.Sharing.Any(e => e.ID == id);
        }
    }
}
