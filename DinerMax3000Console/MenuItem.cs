using System;
namespace DinerMax3000Console
{
    public class MenuItem
    {
        public String title;
        public String description;
        public double price {
            get { return _price; }
            set {
                if (value > 0){
                    _price = value;
                }
                else {
                    throw new ApplicationException("You can not have free or negative value");
                }
                    
            
            }
        }


        private double _price;
    }
}
