using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PortfolioRK.Database;
using PortfolioRK.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioRK.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly PortfolioRKContext _context;

        public IndexModel(ILogger<IndexModel> logger, PortfolioRKContext context)
        {
            _logger = logger;
            _context = context;
        }

        public ICollection<Repository> Repositories { get; set; }
        public async Task OnGet()
        {
            Repositories = await _context.Repositories.ToListAsync();
        }
    }
}
