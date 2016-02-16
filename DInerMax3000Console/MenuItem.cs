using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DInerMax3000Console
{
    public class MenuItem
    {
        string title;
        string description;
        double price;

 
            public string getTitle()
            {
                return this.title;
            }

            public void setTitle(string titleName)
            {
                this.title = titleName;
            }

            public double getPrice()
            {
                return this.price;
            }

            public void setPrice(double enteredValue)
            {
                this.price= enteredValue;
            }

            public string getDescription()
            {
            return this.description;
            }

            public void setDescription(string menuDescription)
            {
            this.description = menuDescription;
            }

    }

     
    }

