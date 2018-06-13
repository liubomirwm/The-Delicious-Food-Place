using System;
using System.Collections.Generic;

namespace TheDeliciousFoodPlace
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ITimeState currentTimeState = TimeStateFactory.GetTimeState();

            List<string> menuItems = currentTimeState.GetMenu();
            DrawMenu(menuItems);
            string selectedMenuItem = GetUserSelectedMenuItem(menuItems);

            IFoodProductFactory foodFactory = currentTimeState.GetFoodFactory();
            FoodProduct foodProduct = foodFactory.GetFoodProduct(selectedMenuItem);
            Console.WriteLine("You have bought " + foodProduct.ToString() + " leva");
            Console.ReadKey(true);
        }

        public static void DrawMenu(List<string> menuItems)
        {
            foreach (string menuItem in menuItems)
            {
                Console.WriteLine(menuItem);
            }
            Console.WriteLine();
        }

        public static string GetUserSelectedMenuItem(List<string> menuItems)
        {
            Console.Write("Enter item to order: ");
            string enteredMenuItem = Console.ReadLine();
            while (menuItems.Contains(enteredMenuItem) == false)
            {
                Console.Write("You have entered an invalid item. Please enter one from the list: ");
                enteredMenuItem = Console.ReadLine();
            }
            return enteredMenuItem;
        }
    }
}