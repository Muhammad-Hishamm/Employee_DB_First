using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Employee_DB_First.Models;

[Table("City")]
public partial class City
{
    [Key]
    public int CityId { get; set; }

    [StringLength(50)]
    public string? CityNameArabic { get; set; }

    [StringLength(50)]
    public string CityNameEnglish { get; set; } = null!;

    [InverseProperty("City")]
    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
   
}
