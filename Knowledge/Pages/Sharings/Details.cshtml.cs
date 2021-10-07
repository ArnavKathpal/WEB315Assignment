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
    public class DetailsModel : PageModel
    {
        private readonly KnowledgeSharingContext _context;

        public DetailsModel(KnowledgeSharingContext context)
        {
            _context = context;
        }

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
    }
}
