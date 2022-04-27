#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GrimmEmployeeManagement.Data;
using GrimmEmployeeManagement.Models;

namespace GrimmEmployeeManagement.Pages.Information
{
    public class IndexModel : PageModel
    {
        private readonly GrimmEmployeeManagement.Data.GrimmEmployeeManagementContext _context;

        public IndexModel(GrimmEmployeeManagement.Data.GrimmEmployeeManagementContext context)
        {
            _context = context;
        }

        public IList<EmployeeData> EmployeeData { get;set; }

        public async Task OnGetAsync()
        {
            EmployeeData = await _context.EmployeeData.ToListAsync();
        }
    }
}
