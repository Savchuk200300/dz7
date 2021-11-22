using System;
using System.Collections.Generic;
namespace dz7_1
{
    class Item
    {
        public Item item;
    }
    class Order
    {
        private List<Item> itemList;
        internal List<Item> ItemList
        {
            get
            {
                return itemList;
            }
            set
            {
                itemList = value;
            }
        }

        public void GetItems() {/*...*/}
        public void GetItemCount() {/*...*/}
        public void AddItem(Item item) {/*...*/}
        public void DeleteItem(Item item) {/*...*/}


        class OrderPrint
        {
            public void PrintOrder() {/*...*/}
            public void ShowOrder() {/*...*/}
        }
        class Repository
        {
            public void Load() {/*...*/}
            public void Save() {/*...*/}
        }
        class DoThing
        {
            public void Update() {/*...*/}
            public void Delete() {/*...*/}
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        
        }
    }
}
