
using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Model
{
    public class Bill
    {
        private int cust;
        private int pricePer;
        private CouponType coupon;

        public Bill(int cust, int pricePer, CouponType coupon)
        {
            this.cust = cust;
            this.pricePer = pricePer;
            this.coupon = coupon;
        }

        public int Calculate(PriceCalculator pc)
        {
           
            return pc.Calculate(this.cust, this.pricePer);
        }
    }
}
