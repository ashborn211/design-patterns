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

            // 2. Doppio (double espresso)
            Beverage doppio = new Espresso();
            doppio = new Espresso();
            doppio = new Espresso();
            PrintBeverage(doppio);

            // 3. Lungo (espresso + water)
            Beverage lungo = new Espresso();
            lungo = new Water(lungo);
            PrintBeverage(lungo);

            // 4. Ristretto (espresso)
            Beverage ristretto = new Espresso();
            PrintBeverage(ristretto);

            // 5. Macchiato (espresso + milk foam)
            Beverage macchiato = new Espresso();
            macchiato = new Milk_Foam(macchiato);
            PrintBeverage(macchiato);

            // 6. Corretto (espresso + liquor)
            Beverage corretto = new Espresso();
            corretto = new Liqour(corretto);
            PrintBeverage(corretto);

            // 7. Con Panna (espresso + whipped cream)
            Beverage conPanna = new Espresso();
            conPanna = new Whip(conPanna);
            PrintBeverage(conPanna);

            // 8. Cappuccino (espresso + milk + milk foam)
            Beverage cappuccino = new Espresso();
            cappuccino = new Half_Milk(cappuccino);
            cappuccino = new Milk_Foam(cappuccino);
            PrintBeverage(cappuccino);

            // 9. Americano (espresso + 2x water)
            Beverage americano = new Espresso();
            americano = new Water(americano);
            americano = new Water(americano);
            PrintBeverage(americano);

            // 10. Caffè Latte (espresso + milk + foam)
            Beverage latte = new Espresso();
            latte = new Half_Milk(latte);
            latte = new Milk_Foam(latte);
            PrintBeverage(latte);

            // 11. Flat White (espresso + milk)
            Beverage flatWhite = new Espresso();
            flatWhite = new Half_Milk(flatWhite);
            PrintBeverage(flatWhite);

            // 12. Romano (espresso + lemon)
            Beverage romano = new Espresso();
            romano = new Lemon(romano);
            PrintBeverage(romano);

            // 13. Marocchino (espresso + chocolate + foam)
            Beverage marocchino = new Espresso();
            marocchino = new Chocolate(marocchino);
            marocchino = new Milk_Foam(marocchino);
            PrintBeverage(marocchino);

            // 14. Mocha (espresso + chocolate + milk + whipped cream)
            Beverage mocha = new Espresso();
            mocha = new Chocolate(mocha);
            mocha = new Half_Milk(mocha);
            mocha = new Whip(mocha);
            PrintBeverage(mocha);

            // 15. Bicerin (espresso + chocolate + whipped cream)
            Beverage bicerin = new Espresso();
            bicerin = new Chocolate(bicerin);
            bicerin = new Whip(bicerin);
            PrintBeverage(bicerin);

            // 16. Breve (espresso + milk + foam)
            Beverage breve = new Espresso();
            breve = new Half_Milk(breve);
            breve = new Milk_Foam(breve);
            PrintBeverage(breve);

            // 17. Raf Coffee (espresso + cream + vanilla sugar)
            Beverage raf = new Espresso();
            raf = new Cream(raf);
            raf = new Vanilla_Sugar(raf);
            PrintBeverage(raf);

            // 18. Mead Raf (espresso + cream + honey)
            Beverage meadRaf = new Espresso();
            meadRaf = new Cream(meadRaf);
            meadRaf = new Honey(meadRaf);
            PrintBeverage(meadRaf);

            // 19. Galao (espresso + milk foam)
            Beverage galao = new Espresso();
            galao = new Milk_Foam(galao);
            PrintBeverage(galao);

            // 20. Caffè Affogato (espresso + ice cream)
            Beverage affogato = new Espresso();
            affogato = new Ice_cream(affogato);
            PrintBeverage(affogato);

            // 21. Vienna Coffee (espresso + whipped cream)
            Beverage vienna = new Espresso();
            vienna = new Whip(vienna);
            PrintBeverage(vienna);

            // 22. Glace (espresso + ice cream)
            Beverage glace = new Espresso();
            glace = new Ice_cream(glace);
            PrintBeverage(glace);

            // 23. Chocolate Milk (espresso + milk + cocoa)
            Beverage chocolateMilk = new Espresso();
            chocolateMilk = new Half_Milk(chocolateMilk);
            chocolateMilk = new Black_chocolate(chocolateMilk);
            PrintBeverage(chocolateMilk);

            // 24. Demi-Crème (espresso + cream)
            Beverage demiCreme = new Espresso();
            demiCreme = new Cream(demiCreme);
            PrintBeverage(demiCreme);

            // 25. Latte Macchiato (espresso + milk + foam)
            Beverage latteMacchiato = new Espresso();
            latteMacchiato = new Half_Milk(latteMacchiato);
            latteMacchiato = new Milk_Foam(latteMacchiato);
            PrintBeverage(latteMacchiato);

            // 26. Freddo (espresso + liquor + ice)
            Beverage freddo = new Espresso();
            freddo = new Liqour(freddo);
            freddo = new Ice(freddo);
            PrintBeverage(freddo);

            // 27. Frappuccino (espresso + milk + whipped cream)
            Beverage frappuccino = new Espresso();
            frappuccino = new Half_Milk(frappuccino);
            frappuccino = new Whip(frappuccino);
            PrintBeverage(frappuccino);

            // 28. Caramel Frappuccino (espresso + milk + caramel syrup + cream)
            Beverage caramelFrappuccino = new Espresso();
            caramelFrappuccino = new Half_Milk(caramelFrappuccino);
            caramelFrappuccino = new Syrup(caramelFrappuccino);
            caramelFrappuccino = new Cream(caramelFrappuccino);
            PrintBeverage(caramelFrappuccino);

            // 29. Frappe (espresso + milk + ice cream)
            Beverage frappe = new Espresso();
            frappe = new Half_Milk(frappe);
            frappe = new Ice_cream(frappe);
            PrintBeverage(frappe);

            // 30. Irish Coffee (espresso + whiskey + whipped cream)
            Beverage irishCoffee = new Espresso();
            irishCoffee = new Whiskey(irishCoffee);
            irishCoffee = new Whip(irishCoffee);
            PrintBeverage(irishCoffee);
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.cost().ToString("#.##"));
        }
    }
}
