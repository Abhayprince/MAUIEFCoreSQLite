using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MAUIEFCoreSQLite.Data.Entities;

[Table("Users")]
public class User
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; }
}
