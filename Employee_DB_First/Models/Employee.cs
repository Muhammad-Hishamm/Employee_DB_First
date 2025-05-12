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

    [StringLength(100)]
    [Unicode(false)]
    public string EmployeeNameEnglish { get; set; } = null!;

    [Column("DOB")]
    public DateOnly Dob { get; set; }

    public DateOnly HiringDate { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal Salary { get; set; }

    public int? CityId { get; set; }

    public int? DepartmentId { get; set; }

    [ForeignKey("CityId")]
    [InverseProperty("Employees")]
    public virtual City? City { get; set; }

    [ForeignKey("DepartmentId")]
    [InverseProperty("Employees")]
    public virtual Department? Department { get; set; }
}
