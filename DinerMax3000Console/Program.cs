using System;
// roeut 2
namespace DinerMax3000Console
{
    class MainClass
    {
        static void Main(string[] args)
        {
            FoodMenu summerMenu = new FoodMenu();
            summerMenu.Name = "Summer Menu";
            summerMenu.addMenuItem("Salmon", "Fresh Norwegian Salmon with butter", 25.50);
            summerMenu.addMenuItem("Taco", "norwegian tacos number one", 15.50);
            summerMenu.hospitalDirection = "Right around the corner on 5th St ask for Dr. Jones";

            DrinkMenu outsideDrinks = new DrinkMenu();
            outsideDrinks.disclaimer = "Do not drink and code.";
            outsideDrinks.addMenuItem("Jack Daniels", "a type of rum", 3.50);

            Order hungryGuestOrder = new Order();
            for (int x = 0; x <= summerMenu.items.Count-1; x++){
                MenuItem currentItem = summerMenu.items[x];
                hungryGuestOrder.items.Add(currentItem);
            }
//random comments again
            foreach(MenuItem currentItem in outsideDrinks.items){
                hungryGuestOrder.items.Add(currentItem);
            }

            Console.WriteLine("The total is: "+ hungryGuestOrder.total);

            try {
                outsideDrinks.addMenuItem("Jin", "a type of tequila", 0);
            }
            catch(Exception thrownException) {
                Console.WriteLine(thrownException.Message);
                
            }
            Console.ReadKey();
        }
    }
}
