using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coupons.Models
{
    [Table("Coupons_Used")]
    public class CouponUsed
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Email")]
        public string Email { get; set; }

        [ForeignKey("CouponId")]
        public Guid CouponId { get; set; }

        public virtual Coupon Coupon { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
