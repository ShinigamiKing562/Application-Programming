using System;

class Mall {
    static void Main() {
        Console.WriteLine("Enter Credit Limit: Ksh. ");
        float Climit = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter Price of item: Ksh. ");
        float price = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter quantity of items: ");
        float quantity = float.Parse(Console.ReadLine());

        float tpurchase = Calculate(price, quantity);
        Console.WriteLine("Total Purchase = Ksh. " + tpurchase);

        while (tpurchase > climit) {
            Console.WriteLine("Sorry, you cannot purchase goods worth such a value on credit.");
            Console.WriteLine("Re-enter quantity of items: ");
            quantity = float.Parse(Console.ReadLine());
            tpurchase = Calculate(price, quantity);
            Console.WriteLine("Total Purchase = Ksh. " + tpurchase);
        }

        Console.WriteLine("Thank You for purchasing from us faithfully.");
    }

    static float Calculate(float price, float quantity) {
        return price * quantity;
    }
}
