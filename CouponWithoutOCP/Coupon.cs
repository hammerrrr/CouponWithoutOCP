using System;
using System.Collections.Generic;
using System.Text;

namespace CouponWithoutOCP
{
    class Coupon
    {
        public double discNominal = 0;
        public double priceNett (double originPrice)
        {
            double net = 0;
            net = (100 - discNominal) * originPrice / 100;
            return net;
        }
    }
}
