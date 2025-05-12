using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Employee_DB_First.Models;

[Table("Employee")]
public partial class Employee
{
    [Key]
    public int EmployeeId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string EmployeeNameArabic { get; set; } = null!;
    [Display(Name = "Arabic Name")]

    [StringLength(100)]
    [Unicode(false)]
    public string EmployeeNameEnglish { get; set; } = null!;
    [Display(Name = "Name")]
    [Column("DOB")]
    public DateOnly Dob { get; set; }
    [Display(Name = "Date of Birth")]
    public DateOnly HiringDate { get; set; }
    [Display(Name = "Hiring Date")]
    [Column(TypeName = "decimal(12, 2)")]
    public decimal Salary { get; set; }
    [Display(Name = "Salary")]
    public int? CityId { get; set; }
    [Display(Name = "City")]
    public int? DepartmentId { get; set; }
    [Display(Name = "Department")]

    [ForeignKey("CityId")]
    [InverseProperty("Employees")]
    public virtual City? City { get; set; }

    [ForeignKey("DepartmentId")]
    [InverseProperty("Employees")]
    public virtual Department? Department { get; set; }
}
