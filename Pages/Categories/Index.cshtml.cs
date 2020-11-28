using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Crisan_Adriana_Lab8.Data;
using Crisan_Adriana_Lab8.Models;

namespace Crisan_Adriana_Lab8.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Crisan_Adriana_Lab8.Data.Crisan_Adriana_Lab8Context _context;

        public IndexModel(Crisan_Adriana_Lab8.Data.Crisan_Adriana_Lab8Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; }

        public async Task OnGetAsync()
        {
            Category = await _context.Category.ToListAsync();
        }
    }
}
