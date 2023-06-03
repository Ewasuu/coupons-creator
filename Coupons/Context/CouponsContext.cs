using Coupons.Models;
using Microsoft.EntityFrameworkCore;

namespace Coupons.Context
{
    public class CouponsContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Coupon> Coupons { get; set; }

        public DbSet<CouponUsed> CouponsUsed { get; set; }

        public CouponsContext(DbContextOptions<CouponsContext> options) : base(options) { } 
    }
}
