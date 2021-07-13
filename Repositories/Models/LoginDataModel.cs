using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginMVC.Repositories.Models
{
    [Table("Login")]
    public class LoginDataModel
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        public string UserName { get; set; }

    }
}
