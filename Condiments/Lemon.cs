using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class Lemon : CondimentDecorator
    {
        public Lemon (Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        public override double cost()
        {
            double condimentPrice;
            switch (Size)
            {
                case Size.TALL:
                    condimentPrice = 0.20;
                    break;
                case Size.GRANDE:
                    condimentPrice = 0.30;
                    break;
                case Size.VENDI:
                    condimentPrice = 0.40;
                    break;
                default:
                    condimentPrice = 0.20;
                    break;
            }

            return baseBeverage.cost() + condimentPrice;
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Lemon ";
        }
    }
}
