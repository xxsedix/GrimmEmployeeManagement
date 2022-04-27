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
    public class DeleteModel : PageModel
    {
        private readonly GrimmEmployeeManagement.Data.GrimmEmployeeManagementContext _context;

        public DeleteModel(GrimmEmployeeManagement.Data.GrimmEmployeeManagementContext context)
        {
            _context = context;
        }

        [BindProperty]
        public EmployeeData EmployeeData { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EmployeeData = await _context.EmployeeData.FirstOrDefaultAsync(m => m.ID == id);

            if (EmployeeData == null)
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

            EmployeeData = await _context.EmployeeData.FindAsync(id);

            if (EmployeeData != null)
            {
                _context.EmployeeData.Remove(EmployeeData);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
