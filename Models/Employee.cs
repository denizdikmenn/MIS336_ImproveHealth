using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _ImproveHealth.Models
{

public class Employee 
{

[Key]
public int EmployeeId { get; set;  }
[Column("nvarchar(250)")]
[Required]
public string  FullName { get; set;  }
[Column("varchar(10)")]
public string Position { get; set;  }
[Column("varchar(100)")]
public string EmpCode { get; set;  }
[DisplayName("Office Location")]
public string OfficeLocation { get; set;  }
[DisplayName("BloodType")]
public string BloodType { get; set;  }
[DisplayName("Allergies")]
public string Allergies { get; set;  }
[DisplayName("MedicalInsuranceNumber")]
public string MedicalInsuranceNumber { get; set;  }
[DisplayName("HeartDissease")]
public string HeartDissease { get; set;  }
}


}