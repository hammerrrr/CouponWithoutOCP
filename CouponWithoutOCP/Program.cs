using System;

namespace CouponWithoutOCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Coupon coupon1 = new Coupon();
            coupon1.discNominal = 2000;
            Console.WriteLine(coupon1.priceNett(1000));
        }
    }
}
