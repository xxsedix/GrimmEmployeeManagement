#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GrimmEmployeeManagement.Data;
using GrimmEmployeeManagement.Models;

namespace GrimmEmployeeManagement.Pages.Information
{
    public class CreateModel : PageModel
    {
        private readonly GrimmEmployeeManagement.Data.GrimmEmployeeManagementContext _context;

        public CreateModel(GrimmEmployeeManagement.Data.GrimmEmployeeManagementContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public EmployeeData EmployeeData { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.EmployeeData.Add(EmployeeData);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
