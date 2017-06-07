using Lib;

using Lib.Model;
using System;
using System.Collections.Generic;

namespace dotnet_dev_calculator
{
    class Program
    {
        public static List<Rule> _Rules { get; set; }

        static void Main(string[] args)
        {
            CreateRule();

            CouponFactory cf = new CouponFactory();

            PriceCalculator pc = new PriceCalculator();

            int cust = 2;

            int pricePer = 500;

            string coupon = "NONE";

            Console.WriteLine("Customer : {0} , PricePerPerson : {1} , Coupon : {2}", cust, pricePer, coupon);

            var couponType = cf.GetCouponType(coupon);

            Console.WriteLine("Get Coupon by string : " + couponType);

            Bill b = new Bill(cust, pricePer, couponType);

            var initialPrice = b.Calculate(pc);

            Console.WriteLine("Price : " + initialPrice);


            Console.ReadLine();
        }

        private static void CreateRule()
        {
            if (_Rules == null)
            {
                _Rules = new List<Rule>();

                _Rules.Add(new Rule("DIS10"));
                _Rules.Add(new Rule("STARCARD"));
                _Rules.Add(new Rule("NONE"));
            }
        }
    }
}