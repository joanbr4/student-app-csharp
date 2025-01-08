// using Microsoft.EntityFrameworkCore; //That specify EF to create initial table model
// using System;
// using System.Collections.Generic;

namespace ContosoUniversity.Models
{
  public class Student
  {
    public int ID { get; set; } //EF interprets __ID or classanmeID string as primary key
    public string LastName { get; set; }
    public string FirstMidName { get; set; }
    public DateTime EnrollmentDate { get; set; }

    public ICollection<Enrollment> Enrollments { get; set; }
  }
}