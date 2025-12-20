
using System.ComponentModel.DataAnnotations;

namespace AstraArchive.Context.Entities;

public class User
{
    [Key]
    public string UserId { get; set; } = Guid.NewGuid().ToString();

    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(50)]
    public string LastName { get; set; }

    [Required]
    [MaxLength(50)]
    public string Username { get; set; }

    [Required]
    [MaxLength(100)]
    public string Email { get; set; }

    [Required]
    public string PasswordHash { get; set; }

    [Required]
    public int Role { get; set; }

    [Required]
    public DateTime CreatedAt { get; set; }
}