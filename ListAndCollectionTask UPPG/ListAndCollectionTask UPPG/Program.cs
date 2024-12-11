using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndCollectionTask_UPPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            inventory.AddItem("Laptop", 1200.50, 7);
            inventory.AddItem("Smartphone", 799.99, 12);
            inventory.AddItem("Tablet", 399.99, 15);

            inventory.PrintAllItems();

            inventory.UpdateStock("Laptop", 5);

            inventory.RemoveItem("Tablet");

            inventory.PrintMostExpensiveItem();

            inventory.PrintTotalInventoryValue();
        }
    }

    class Inventory
    {
        private List<string> items = new List<string>();
        private Dictionary<string, (double Price, int Stock)> itemDetails = new Dictionary<string, (double, int)>();

        public void AddItem(string productName, double price, int stock)
        {
            if (!items.Contains(productName))
            {
                items.Add(productName);
                itemDetails[productName] = (price, stock);
                Console.WriteLine($"Added {productName} to the inventory.");
            }
            else
            {
                Console.WriteLine($"Item {productName} already exists.");
            }
        }

        public void RemoveItem(string productName)
        {
            if (items.Contains(productName))
            {
                items.Remove(productName);
                itemDetails.Remove(productName);
                Console.WriteLine($"Removed {productName} from the inventory.");
            }
            else
            {
                Console.WriteLine($"Item {productName} not found.");
            }
        }

        public void UpdateStock(string productName, int newStock)
        {
            if (items.Contains(productName))
            {
                var details = itemDetails[productName];
                itemDetails[productName] = (details.Price, newStock);
                Console.WriteLine($"Updated stock of {productName} to {newStock}.");
            }
            else
            {
                Console.WriteLine($"Item {productName} not found.");
            }
        }

        public void PrintAllItems()
        {
            Console.WriteLine("\nInventory Details:");
            foreach (var item in items)
            {
                var details = itemDetails[item];
                Console.WriteLine($"Item: {item}, Price: {details.Price}, Stock: {details.Stock}");
            }
        }

        public void PrintMostExpensiveItem()
        {
            if (items.Count > 0)
            {
                var mostExpensive = itemDetails.OrderByDescending(x => x.Value.Price).First();
                Console.WriteLine($"\nMost Expensive Item: {mostExpensive.Key}, Price: {mostExpensive.Value.Price}");
            }
            else
            {
                Console.WriteLine("Inventory is empty.");
            }
        }

        public void PrintTotalInventoryValue()
        {
            double totalValue = itemDetails.Sum(x => x.Value.Price * x.Value.Stock);
            Console.WriteLine($"\nTotal Inventory Value: {totalValue}");
        }
    }
}
