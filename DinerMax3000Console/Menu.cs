using System;
using System.Collections.Generic;

namespace DinerMax3000Console
{
    public class Menu
    {
        public Menu(){
            items = new List<MenuItem>();
        }

        public void addMenuItem(string title, string description, double price){

            MenuItem item = new MenuItem();
            item.title = title;
            item.description = description;
            item.price = price;
            items.Add(item);
        }
        public string Name;
        public List<MenuItem> items;
    }


}
