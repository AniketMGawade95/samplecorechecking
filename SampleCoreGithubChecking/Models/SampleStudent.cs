using System;
using System.Collections.Generic;

namespace SampleCoreGithubChecking.Models;

public partial class SampleStudent
{
    public int StudentId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public DateTime? EnrollmentDate { get; set; }
}
