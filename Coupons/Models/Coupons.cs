using System.ComponentModel.DataAnnotations;

namespace Coupons.Models
{
    public class Coupon
    {
        [Key]
        public Guid CouponId { get; set; }

        public int Amount { get; set; }

        public DateTime ExpirationDate { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool IsDeleted { get; set; }
    }
}
