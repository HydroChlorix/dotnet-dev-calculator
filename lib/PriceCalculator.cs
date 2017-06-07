using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{

    interface ICalculator
    {
        int Calculate(int cust, int pricePer);
    }
    public class PriceCalculator : ICalculator
    {
        public int Calculate(int cust, int pricePer)
        {
            return cust * pricePer;
        }
    }

    public interface IDiscount
    {
        int Discount(int price);
        int GetDiscountPercent { get; }
    }


    public class DiscountCalculator : IDiscount
    {
        private int _Percent;

        public DiscountCalculator(int percent)
        {
            this._Percent = percent;
        }

        public int Discount(int price)
        {
            return price * this._Percent;
        }

        public int GetDiscountPercent
        {
            get
            {
                return this._Percent;
            }
        }
    }


    //abstract class AbstractCalculator
    //{
    //    public abstract AbstractProductA CreateDiscount10();
    //    public abstract AbstractProductB CreateDiscount10();
    //}

    //abstract class AbstractProductA
    //{
    //    public abstract void Interact(AbstractProductA a);
    //}

    //abstract class AbstractProductB
    //{
    //    public abstract void Interact(AbstractProductA a);
    //}
}
