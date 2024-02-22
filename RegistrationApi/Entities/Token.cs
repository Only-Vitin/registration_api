using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationApi.Entities
{
    public class Token
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Value { get; set; }

        [Required]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}