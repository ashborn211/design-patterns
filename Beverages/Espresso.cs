using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal class Espresso : Beverage
    {
        public Espresso (Beverage beverage = null)
        {
            description = "Espresso";
            this.baseBeverage = beverage;
        
        }
        public override string GetDescription()
        {
            if (baseBeverage != null)
            {
                return baseBeverage.GetDescription() + ", " + description;
            }
            return description;
        }

        public override double cost()
        {
            double basePrice;
            switch (Size)
            {
                case Size.TALL:
                    basePrice = 2.99;
                    break;
                case Size.GRANDE:
                    basePrice = 3.49;
                    break;
                case Size.VENDI:
                    basePrice = 4.99;
                    break;
                default:
                    basePrice = 1.99;
                    break;
            }

            if (baseBeverage != null)
            {
                return basePrice + baseBeverage.cost();
            }
            return basePrice;
        }
    }
}
