
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AstraArchive.Context.Entities;

public class Password
{
    [Required]
    [Key]
    [ForeignKey("UserId")]
    public User User { get; set; }

    [Required]
    public string PasswordHash { get; set; }
}