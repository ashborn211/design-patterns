using DecoratorPattern.Condiments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal class Liqour : CondimentDecorator
    {
        public Liqour(Beverage beverage)
        {
            baseBeverage = beverage;
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
            return baseBeverage.GetDescription() + ", Liqour ";
        }
    }
}
