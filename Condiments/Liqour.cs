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
            return 0.20 + baseBeverage.cost();
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Liqour ";
        }
    }
}
