﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinerMax3000.Business;

namespace DinerMax3000.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Menu summerMenu = new Menu();
            FoodMenu summerMenu = new FoodMenu();
            summerMenu.setMenuName("The Summer Menu");
            MenuItem salmonDish = new MenuItem();
             salmonDish.setTitle("Summer sumptious Salmon");
             salmonDish.setDescription("Salmon served with some nordik sauce");
             salmonDish.setPrice(25.00);

             summerMenu.Items.Add(salmonDish);
             

            summerMenu.addToMenu("Sumptious Salmon", "Norwegian Salmon with local butter", 25.50);
            summerMenu.addToMenu("Steak special", "T-bone steak with proper chips", 35.40);

            summerMenu.setHospitalDirections("Just around the corner....");

            DrinksMenu drinks = new DrinksMenu();
            drinks.addToMenu("Ale", "Shephard Neame Spitfire Ale", 1.65);
            drinks.addToMenu("Lager", "Stella Artois", 2.50);
            drinks.addToMenu("Rum", "Bacardi and Coke", 5.00);
            drinks.setDisclaimer("Don't drink and then try and fly a plane...");
            */

            List<Menu> allMenus = Menu.GetAllMenus();

            Orders hungryPerson = new Orders();

            foreach (Menu currentMenu in allMenus)
            {
                foreach (MenuItem currentItem in currentMenu.Items)
                {
                    hungryPerson.orderContents.Add(currentItem);
                }
            }

            Menu firstMenu = allMenus[0];
            firstMenu.saveNewMenuItem("Pie", "Steak and Ale pie", 5.00);
            List<Menu> menusFromDB = Menu.GetAllMenus();

            System.Console.ReadKey();         

        }
    }
}
