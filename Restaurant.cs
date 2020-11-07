using System;
using System.Collections.Generic;

namespace Studio3
{
    class Restaurant
    {
        static void Main(string[] args)
        {
            MenuItem item1 = new MenuItem("stuff", 5.99, "some stuff", "Appetizer");
            MenuItem item2 = new MenuItem("stuff and things", 12.49, "a bunch of stuff and things", "Main");
            MenuItem item3 = new MenuItem("things", 4.49, "some things", "Dessert");

            Menu menu1 = new Menu(new List<MenuItem> { item1, item2, item3 });

            menu1.PrintMenu();
            item3.PrintItem();

            item1.SetItemOld();
            item2.SetItemOld();

            menu1.AddMenuItem(item1);
            menu1.AddMenuItem(new MenuItem("cheaper things", 3.29, "things that are cheaper", "Dessert"));
            menu1.RemoveMenuItem(item3);
            menu1.RemoveMenuItem(item3);

            menu1.PrintMenu();
        }
    }
}
