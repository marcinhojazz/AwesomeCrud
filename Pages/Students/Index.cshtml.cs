using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AwesomeCrud.Data;
using AwesomeCrud.Models;

namespace AwesomeCrud.Pages_Students
{
    public class IndexModel : PageModel
    {
        private readonly AwesomeCrud.Data.ApplicationDbContext _context;

        public IndexModel(AwesomeCrud.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Students != null)
            {
                Student = await _context.Students.ToListAsync();
            }
        }
    }
}
