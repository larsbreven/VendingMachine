using System;
using System.Collections.Generic;
using VendingMachine.Data;
using VendingMachine.Models;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Följande ordning på upplägget:
                1. Gör en liten meny där man talar om att det finns 3 produkter att välja.
                2. Visa att priset för produkterna är 44 kr för öl, 22 kr för chips och 11 kr för äpple.
                3. Be användaren att mata in pengarna i en money pool, 8 tillgängliga valörer.
                4. Be användaren att välja produkter, och visa samtidigt hur mycket det finns kvar i money poolen efter varje val..
                5. Visa för användaren en "knapp" för att avsluta köp.
                6. Efter att användaren har beslutat att avsluta sina köp så återbetalas vad som finns kvar i money poolen.
                7. Efter att köpen är avslutade visas en liten meny hue de olika produkterna skall användas.
            */
            
            Console.Clear();

            Products products = new Products(); // Abstract class can not be instantiated by itself
            Apple apple = new Apple();
            Beer beer = new Beer();
            Crisps crisps = new Crisps();
            
            Console.WriteLine("You have a wide selection of products to select from the menu:");
            Console.WriteLine();
            Console.WriteLine($"{apple.size} {apple.measure} {products.product1} from {apple.brand} for {products.price1} {products.currency} ");
            Console.WriteLine($"{beer.size} {beer.measure} {products.product2} from {beer.brand} for {products.price2} {products.currency} ");
            Console.WriteLine($"{crisps.size} {crisps.measure} {products.product3} from {crisps.brand} for {products.price3} {products.currency} ");
            Console.WriteLine();
        }
    }
}
