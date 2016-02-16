using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinerMax3000.Business.dsDinermax3000TableAdapters;

namespace DinerMax3000.Business
{
    public class Menu
    {
        public Menu()
        {
            Items = new List<MenuItem>();
        }

        string name;
        public List<MenuItem> Items; // THis is an example of generics and defines that 'Items' will reference 
                                      // a list of MenuItem objects but has not instantiated the list - this is done
                                      // in the class constructor.
        public void setMenuName (string textName)
        {
            this.name = textName;
        }                        
        
        public string getMenuName()
        {
            return this.name;
        }    

        public static List<Menu> GetAllMenus()
        {
            MenuTableAdapter taMenu = new MenuTableAdapter();
            MenuItemTableAdapter taMenuItem = new MenuItemTableAdapter();
            var rsMenu = taMenu.GetData();
            List<Menu> allMenus = new List<Menu>();

            foreach (dsDinermax3000.MenuRow menuRow in rsMenu.Rows)
            {
                Menu currentMenu = new Menu();
                currentMenu.name = menuRow.Name;

                var rsMenuItems = taMenuItem.GetMenuItemsByMenuId(menuRow.ID);
                foreach (dsDinermax3000.MenuItemRow menuItemRow in rsMenuItems.Rows)
                {
                    currentMenu.addToMenu(menuItemRow.Name, menuItemRow.Description, menuItemRow.Price);
                }
                allMenus.Add(currentMenu);
            }
            return allMenus;
        }
        
        public void addToMenu(string title, string description, double price)
        {
            MenuItem newItem = new MenuItem();
            newItem.setTitle(title);
            newItem.setDescription(description);
            newItem.setPrice(price);

            Items.Add(newItem);
        }  
    }

 
}
