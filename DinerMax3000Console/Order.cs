using System;
using System.Collections.Generic;

namespace DinerMax3000Console
{
    public class Order
    {
        public List<MenuItem> items = new List<MenuItem>();

        public double total{
            get {
                double calculatedTotal = 0;
                foreach(MenuItem item in items){
                    calculatedTotal = calculatedTotal + item.price;
                }
                return calculatedTotal;
            }

        }

    }
}
