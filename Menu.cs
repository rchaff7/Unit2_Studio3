using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Studio3
{
    class Menu
    {
        public List<MenuItem> Items { get; }
        public DateTime LastUpdated { get; private set; }


        public Menu(List<MenuItem> items)
        {
            Items = items;
            Update();
        }

        public void Update()
        {
            LastUpdated = DateTime.Today;
        }


    }
}
