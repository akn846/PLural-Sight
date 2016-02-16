using System;
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
            // Menu summerMenu = new Menu();
            FoodMenu summerMenu = new FoodMenu();
            summerMenu.setMenuName("The Summer Menu");
            /* MenuItem salmonDish = new MenuItem();
             salmonDish.setTitle("Summer sumptious Salmon");
             salmonDish.setDescription("Salmon served with some nordik sauce");
             salmonDish.setPrice(25.00);

             summerMenu.Items.Add(salmonDish);
             */

            summerMenu.addToMenu("Sumptious Salmon", "Norwegian Salmon with local butter", 25.50);
            summerMenu.addToMenu("Steak special", "T-bone steak with proper chips", 35.40);

            summerMenu.setHospitalDirections("Just around the corner....");

            DrinksMenu drinks = new DrinksMenu();
            drinks.addToMenu("Ale", "Shephard Neame Spitfire Ale", 1.65);
            drinks.addToMenu("Lager", "Stella Artois", 2.50);
            drinks.addToMenu("Rum", "Bacardi and Coke", 5.00);
            drinks.setDisclaimer("Don't drink and then try and fly a plane...");

            Orders hungryPerson = new Orders();

            for (int loopCounter=0; loopCounter < summerMenu.Items.Count; loopCounter++)
            {
                hungryPerson.orderContents.Add(summerMenu.Items[loopCounter]);

            }

            for (int loopCounter=0; loopCounter < drinks.Items.Count; loopCounter++)
            {
                hungryPerson.orderContents.Add(drinks.Items[loopCounter]);
            }

        }
    }
}
