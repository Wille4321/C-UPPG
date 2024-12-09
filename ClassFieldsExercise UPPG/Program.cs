using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFieldsExercise_UPPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Phone", 599, 5);

            Console.WriteLine("Initial Product Details");
            Console.WriteLine(product.GetDetails());

            product.SetName("Laptop");
            product.SetPrice(999.99);
            product.SetStock(10);

            Console.WriteLine("\nUpdated Product Details:");
            Console.WriteLine(product.GetDetails());

            Console.ReadLine();
        }
    }

    class Product
    {
        private string name;
        private double price;
        private int stock;


        public Product(string name, double price, int stock)
        {
            this.name = name;
            this.price = price;
            this.stock = stock;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetPrice(double price)
        {
            this.price = price;
        }

        public double GetPrice()
        {
            return this.price;
        }

        public void SetStock(int stock)
        {
            this.stock = stock;
        }

        public int GetStock()
        {
            return this.stock;
        }

        public string GetDetails()
        {
            return $"Product Name: {name}, Price: {price:F2}, Stock: {stock} left";
        }

        
    }
}
