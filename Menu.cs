using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Studio3
{
    class Menu
    {
        public List<MenuItem> Items { get; private set; }
        public string LastUpdated { get; private set; }


        public Menu(List<MenuItem> items)
        {
            Items = items;
            UpdateTime();
        }

        public void UpdateTime()
        {
            LastUpdated = DateTime.Today.ToShortDateString();
        }

        public void AddMenuItem(MenuItem newItem)
        {
            foreach(MenuItem item in Items)
            {
                if(item.Equals(newItem))
                {
                    Console.WriteLine("\n" + newItem.Name + " already exists in Menu.");
                    return;
                }
            }
            Console.WriteLine("\n" + "Adding " +newItem.Name + " to Menu.");
            Items.Add(newItem);
            UpdateTime();
        }

        public void RemoveMenuItem(MenuItem item)
        {
            if (Items.Contains(item))
            {
                Console.WriteLine("\n" +item.ToString() + "\n" + "has been removed from the Menu.");
                Items.Remove(item);
                UpdateTime();
            }
            else
            {
                Console.WriteLine("\n" + "Item does not exist in Menu.");
            }
        }

        public void PrintMenu()
        {
            Console.WriteLine("\n" + "MENU UPDATED " + LastUpdated);
            foreach (MenuItem item in Items)
            {
                item.PrintItem();
            }
        }
    }
}
