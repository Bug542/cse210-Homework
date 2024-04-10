using System;
using System.Collections.Generic;

// Abstract class for the product
public abstract class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(int id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    // Abstract method for displaying product details
    public abstract void Display();
}

// Concrete class representing a physical product
public class PhysicalProduct : Product
{
    public int Quantity { get; set; }

    public PhysicalProduct(int id, string name, double price, int quantity) : base(id, name, price)
    {
        Quantity = quantity;
    }

    // Implementing abstract method from base class
    public override void Display()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Price: {Price:C}, Quantity: {Quantity}");
    }
}

// Concrete class representing a digital product
public class DigitalProduct : Product
{
    public string DownloadLink { get; set; }

    public DigitalProduct(int id, string name, double price, string downloadLink) : base(id, name, price)
    {
        DownloadLink = downloadLink;
    }

    // Implementing abstract method from base class
    public override void Display()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Price: {Price:C}, Download Link: {DownloadLink}");
    }
}

// Inventory class responsible for managing products
public class Inventory
{
    private List<Product> products;

    public Inventory()
    {
        products = new List<Product>();
    }

    // Method to add a product to the inventory
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    // Method to display all products in the inventory
    public void DisplayProducts()
    {
        foreach (var product in products)
        {
            product.Display();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Inventory inventory = new Inventory();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Inventory Management System");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Display Products");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter your choice:");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddProduct(inventory);
                    break;
                case "2":
                    DisplayProducts(inventory);
                    break;
                case "3":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddProduct(Inventory inventory)
    {
        Console.WriteLine("Enter product type (1. Physical, 2. Digital):");
        string typeChoice = Console.ReadLine();

        Console.WriteLine("Enter product ID:");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter product name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter product price:");
        double price = Convert.ToDouble(Console.ReadLine());

        switch (typeChoice)
        {
            case "1":
                Console.WriteLine("Enter product quantity:");
                int quantity = Convert.ToInt32(Console.ReadLine());
                inventory.AddProduct(new PhysicalProduct(id, name, price, quantity));
                Console.WriteLine("Physical product added successfully.");
                break;
            case "2":
                Console.WriteLine("Enter download link:");
                string downloadLink = Console.ReadLine();
                inventory.AddProduct(new DigitalProduct(id, name, price, downloadLink));
                Console.WriteLine("Digital product added successfully.");
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    static void DisplayProducts(Inventory inventory)
    {
        Console.WriteLine("Products in Inventory:");
        inventory.DisplayProducts();
    }
}
