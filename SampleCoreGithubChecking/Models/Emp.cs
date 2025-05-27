using System.ComponentModel.DataAnnotations;

namespace SampleCoreGithubChecking.Models
{
    public class Emp
    {
        [Key]
        public int eid { get; set; }

        public string name { get; set; }
    }
}
