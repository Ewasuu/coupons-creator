using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Coupons.Models
{
    [Index("Email")]
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [MaxLength(300), Required, EmailAddress]
        public string Email { get; set; }

        public Roles Role { get; set; } = Roles.Customer;
    }

    public enum Roles
    {
        Customer,
        None,
        Admin
    }
}
