using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.database.entity
{
    [Table("users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Role { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Address { get; set; }

        public virtual List<Book> FavoriteBooks { get; set; } = new List<Book>();

        public virtual List<CartItem> Cart { get; set; } = new List<CartItem>();
    }
}
