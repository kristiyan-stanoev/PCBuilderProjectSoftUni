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
    public class DetailsModel : PageModel
    {
        private readonly PCBuilder.Data.PCBuilderContext _context;

        public DetailsModel(PCBuilder.Data.PCBuilderContext context)
        {
            _context = context;
        }

        public GraphicsCard GraphicsCard { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            bool isInRole = this.User.IsInRole("Administrator");

            GraphicsCard = await _context.GraphicsCards.FirstOrDefaultAsync(m => m.Id == id);

            if (GraphicsCard == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
