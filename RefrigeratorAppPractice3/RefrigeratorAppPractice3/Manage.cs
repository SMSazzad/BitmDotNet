using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorAppPractice3
{
    class Manage
    {

        public double Limit { get; set; }

        private double loadedWeight = 0.0;

        public bool AddWeight(int items, double weight)
        {
            double chk = items * weight;
            if (loadedWeight + chk <= Limit)
            {
                loadedWeight += chk;
                return true;
            }

            else
                return false;
            
        }

        public double CurrentWeight()
        {
            return loadedWeight;
        }
        public double RemainingWeight()
        {
            return Limit - loadedWeight;
        }


    }
}
