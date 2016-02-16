using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DInerMax3000Console
{
    public class DrinksMenu:Menu
    {
        string disclaimer;

        public void setDisclaimer(string legalText)
        {
            this.disclaimer = legalText;
        }

        public string getDisclaimer()
        {
            // see if this forces push
            return this.disclaimer;
        }
    }
}
