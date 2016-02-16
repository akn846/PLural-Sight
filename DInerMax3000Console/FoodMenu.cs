using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DInerMax3000Console
{
    public class FoodMenu:Menu
    {
        string hospitalDirections;

        public void setHospitalDirections(string toHospital)
        {
            this.hospitalDirections = toHospital;
        }

        public string getHospitalDirections()
        {
            return this.hospitalDirections;
        }
    }
}
