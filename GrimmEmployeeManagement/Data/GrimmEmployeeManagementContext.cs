#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GrimmEmployeeManagement.Models;

namespace GrimmEmployeeManagement.Data
{
    public class GrimmEmployeeManagementContext : DbContext
    {
        public GrimmEmployeeManagementContext (DbContextOptions<GrimmEmployeeManagementContext> options)
            : base(options)
        {
        }

        public DbSet<GrimmEmployeeManagement.Models.EmployeeData> EmployeeData { get; set; }
    }
}
