using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PCBuilder.Data;
using PCBuilder.Models;

namespace PCBuilder.Web.Pages.GraphicsCards
{
    public class IndexModel : PageModel
    {
        private readonly PCBuilder.Data.PCBuilderContext _context;

        public IndexModel(PCBuilder.Data.PCBuilderContext context)
        {
            _context = context;
        }

        public IList<GraphicsCard> GraphicsCard { get;set; }

        public async Task OnGetAsync()
        {
            GraphicsCard = await _context.GraphicsCards.ToListAsync();
        }
    }
}
