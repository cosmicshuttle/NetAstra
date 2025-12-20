using System.ComponentModel.DataAnnotations;

namespace AstraArchive.Models;

public class SigninViewModel
{
    [Required(AllowEmptyStrings = false)]
    public string Username { get; set; }

    [Required(AllowEmptyStrings = false)]
    [DataType(DataType.Password)]
    public string Password { get; set; }
}
