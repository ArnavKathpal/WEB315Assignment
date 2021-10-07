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
    public class IndexModel : PageModel
    {
        private readonly KnowledgeSharingContext _context;

        public IndexModel(KnowledgeSharingContext context)
        {
            _context = context;
        }

        public IList<Sharing> Sharing { get;set; }

        public async Task OnGetAsync()
        {
            Sharing = await _context.Sharing.ToListAsync();
        }
    }
}
