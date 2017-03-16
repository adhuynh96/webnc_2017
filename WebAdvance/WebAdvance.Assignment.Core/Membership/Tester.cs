using System.ComponentModel.DataAnnotations;

namespace WebAdvance.Assignment.Core.Membership
{
    public class Tester
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [RegularExpression("([a-zA-Z0-9])*")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 7)]
        public string Password { get; set; }
        public string FullName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [RegularExpression("([0-9])*")]
        public string Phone { get; set; }
    }
}
