using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Це особисте завдання основане на паттерні Facade

namespace Facade.Examples
{
    // Mainapp test application 
    class MainApp
    {
        public static void Main()
        {
            Menu facade = new Menu();
            facade.DefaultMenu();
            facade.BigmagMenu();
            facade.SmallMenu();
            // Wait for user 
            Console.Read();
        }
    }


    // "Subsystem ClassA" 
    class SetDrink
    {
        public void Drink()
        {
            Console.WriteLine("Your drink is cola");
        }
        public void Drink(string drink)
        {
            Console.WriteLine("Your drink is " + drink);
        }
    }

    // Subsystem ClassB" 
    class SetBurger
    {
        public void Burger()
        {
            Console.WriteLine("Your burger is cheeseburger");
        }
        public void Burger(string burger)
        {
            Console.WriteLine("Your burger is " + burger);
        }
    }


    // Subsystem ClassC" 
    class SetToping
    {
        public void Toping()
        {
            Console.WriteLine("Your toping is fried potatoes");
        }
        public void Toping(string toping)
        {
            Console.WriteLine("Your toping is " + toping);
        }
    }
    // "Facade" 
    class Menu
    {
        SetDrink one;
        SetBurger two;
        SetToping three;

        public Menu()
        {
            one = new SetDrink();
            two = new SetBurger();
            three = new SetToping();
        }

        public void DefaultMenu()
        {
            Console.WriteLine("\nDefaultMenu ---- ");
            one.Drink();
            two.Burger();
            three.Toping();
        }

        public void BigmagMenu()
        {
            Console.WriteLine("\nBigmagMenu() ---- ");
            one.Drink("Sprite");
            two.Burger("Bigmag");
            three.Toping("sliced fried potatoes");
        }

        public void SmallMenu()
        {
            Console.WriteLine("\nSmallMenu() ---- ");
            one.Drink();
            two.Burger("hamburger");
        }
    }
}