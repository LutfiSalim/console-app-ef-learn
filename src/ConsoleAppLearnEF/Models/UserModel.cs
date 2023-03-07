using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppLearnEF.Models;
[Table("User")]
public class UserModel
{
    [Key]
    public Guid UserID { get; set; }
    public string FullName { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
}
