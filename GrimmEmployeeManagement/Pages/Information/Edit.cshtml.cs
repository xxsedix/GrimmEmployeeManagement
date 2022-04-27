#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GrimmEmployeeManagement.Data;
using GrimmEmployeeManagement.Models;

namespace GrimmEmployeeManagement.Pages.Information
{
    public class EditModel : PageModel
    {
        private readonly GrimmEmployeeManagement.Data.GrimmEmployeeManagementContext _context;

        public EditModel(GrimmEmployeeManagement.Data.GrimmEmployeeManagementContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(EmployeeData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeDataExists(EmployeeData.ID))
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

        private bool EmployeeDataExists(int id)
        {
            return _context.EmployeeData.Any(e => e.ID == id);
        }
    }
}
