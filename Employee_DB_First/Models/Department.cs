using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Employee_DB_First.Models;

[Table("Department")]
public partial class Department
{
    [Key]
    public int DepartmentId { get; set; }

    [StringLength(50)]
    public string? DepartmentName { get; set; }
    [Display(Name = "Department")]

    [StringLength(50)]
    [Unicode(false)]
    public string DepatmentAbbr { get; set; } = null!;
    [Display(Name = "Department Abbreviation")]

    [InverseProperty("Department")]
    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
