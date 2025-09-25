using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Espresso
            Beverage espresso = new Espresso();
            espresso.Size = Size.TALL;
            PrintBeverage(espresso);

            // 2. Doppio 
            Beverage doppio = new Espresso();
            doppio = new Espresso();
            doppio.Size = Size.GRANDE;
            PrintBeverage(doppio);

            // 3. Lungo 
            Beverage lungo = new Espresso();
            lungo = new Water(lungo);
            lungo.Size = Size.VENDI;
            PrintBeverage(lungo);

            // 4. Ristretto 
            Beverage ristretto = new Espresso();
            ristretto.Size = Size.TALL;
            PrintBeverage(ristretto);

            // 5. Macchiato
            Beverage macchiato = new Espresso();
            macchiato = new Milk_Foam(macchiato);
            macchiato.Size = Size.GRANDE;
            PrintBeverage(macchiato);

            // 6. Corretto 
            Beverage corretto = new Espresso();
            corretto = new Liqour(corretto);
            corretto.Size = Size.VENDI;
            PrintBeverage(corretto);

            // 7. Con Panna
            Beverage conPanna = new Espresso();
            conPanna = new Whip(conPanna);
            PrintBeverage(conPanna);

            // 8. Cappuccino 
            Beverage cappuccino = new Espresso();
            cappuccino = new Half_Milk(cappuccino);
            cappuccino = new Milk_Foam(cappuccino);
            cappuccino.Size = Size.GRANDE;
            PrintBeverage(cappuccino);

            // 9. Americano 
            Beverage americano = new Espresso();
            americano = new Water(americano);
            americano = new Water(americano);
            PrintBeverage(americano);

            // 10. Caffè Latte 
            Beverage latte = new Espresso();
            latte = new Half_Milk(latte);
            latte = new Milk_Foam(latte);
            PrintBeverage(latte);

            // 11. Flat White 
            Beverage flatWhite = new Espresso();
            flatWhite = new Half_Milk(flatWhite);
            PrintBeverage(flatWhite);

            // 12. Romano
            Beverage romano = new Espresso();
            romano = new Lemon(romano);
            romano.Size = Size.TALL;
            PrintBeverage(romano);

            // 13. Marocchino
            Beverage marocchino = new Espresso();
            marocchino = new Chocolate(marocchino);
            marocchino = new Milk_Foam(marocchino);
            PrintBeverage(marocchino);

            // 14. Mocha 
            Beverage mocha = new Espresso();
            mocha = new Chocolate(mocha);
            mocha = new Half_Milk(mocha);
            mocha = new Whip(mocha);
            PrintBeverage(mocha);

            // 15. Bicerin 
            Beverage bicerin = new Espresso();
            bicerin = new Chocolate(bicerin);
            bicerin = new Whip(bicerin);
            bicerin.Size = Size.VENDI;
            PrintBeverage(bicerin);

            // 16. Breve
            Beverage breve = new Espresso();
            breve = new Half_Milk(breve);
            breve = new Milk_Foam(breve);
            PrintBeverage(breve);

            // 17. Raf Coffee 
            Beverage raf = new Espresso();
            raf = new Cream(raf);
            raf = new Vanilla_Sugar(raf);
            PrintBeverage(raf);

            // 18. Mead Raf 
            Beverage meadRaf = new Espresso();
            meadRaf = new Cream(meadRaf);
            meadRaf = new Honey(meadRaf);
            meadRaf.Size = Size.TALL;
            PrintBeverage(meadRaf);

            // 19. Galao
            Beverage galao = new Espresso();
            galao = new Milk_Foam(galao);
            PrintBeverage(galao);

            // 20. Caffè Affogato
            Beverage affogato = new Espresso();
            affogato = new Ice_cream(affogato);
            PrintBeverage(affogato);

            // 21. Vienna Coffee
            Beverage vienna = new Espresso();
            vienna = new Whip(vienna);
            vienna.Size = Size.GRANDE;
            PrintBeverage(vienna);

            // 22. Glace
            Beverage glace = new Espresso();
            glace = new Ice_cream(glace);
            PrintBeverage(glace);

            // 23. Chocolate Milk
            Beverage chocolateMilk = new Espresso();
            chocolateMilk = new Half_Milk(chocolateMilk);
            chocolateMilk = new Black_chocolate(chocolateMilk);
            PrintBeverage(chocolateMilk);

            // 24. Demi-Crème
            Beverage demiCreme = new Espresso();
            demiCreme = new Cream(demiCreme);
            PrintBeverage(demiCreme);

            // 25. Latte Macchiato
            Beverage latteMacchiato = new Espresso();
            latteMacchiato = new Half_Milk(latteMacchiato);
            latteMacchiato = new Milk_Foam(latteMacchiato);
            PrintBeverage(latteMacchiato);

            // 26. Freddo
            Beverage freddo = new Espresso();
            freddo = new Liqour(freddo);
            freddo = new Ice(freddo);
            freddo.Size = Size.TALL;
            PrintBeverage(freddo);

            // 27. Frappuccino
            Beverage frappuccino = new Espresso();
            frappuccino = new Half_Milk(frappuccino);
            frappuccino = new Whip(frappuccino);
            PrintBeverage(frappuccino);

            // 28. Caramel Frappuccino
            Beverage caramelFrappuccino = new Espresso();
            caramelFrappuccino = new Half_Milk(caramelFrappuccino);
            caramelFrappuccino = new Syrup(caramelFrappuccino);
            caramelFrappuccino = new Cream(caramelFrappuccino);
            PrintBeverage(caramelFrappuccino);

            // 29. Frappe
            Beverage frappe = new Espresso();
            frappe = new Half_Milk(frappe);
            frappe = new Ice_cream(frappe);
            PrintBeverage(frappe);

            // 30. Irish Coffee
            Beverage irishCoffee = new Espresso();
            irishCoffee = new Whiskey(irishCoffee);
            irishCoffee = new Whip(irishCoffee);
            PrintBeverage(irishCoffee);
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription()+" Size:"+ (beverage.Size) + " $" + beverage.cost().ToString("#.##"));
        }
    }
}
