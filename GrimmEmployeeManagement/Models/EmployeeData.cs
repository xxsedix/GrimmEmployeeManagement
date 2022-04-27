using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GrimmEmployeeManagement.Models
{
    public class EmployeeData
    {
        public int ID { get; set; }
        [Display(Name = "Site Name")]
        [Required]
        public string SiteName { get; set; }
        [Display(Name = "Site Region")]
        [Required]
        public string SiteRegion { get; set; }
        [Display(Name = "Site Number")]
        [Required]
        [StringLength(4, MinimumLength = 4)]
        public string SiteNumber { get; set; }
        [Display(Name = "Employee Name")]
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public string Birthday { get; set; }
        [Required]
        [StringLength(11, MinimumLength =9)]
        public string Social { get; set; }
        [Display(Name = "Starting Date")]
        [Required]
        public string StartingDate { get; set; }
        [Required]
        public string Pay { get; set; }
        [Required]
        [StringLength(1, MinimumLength = 1)]
        public string Clearence { get; set; }
    }
}
