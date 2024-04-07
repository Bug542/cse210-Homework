using System;
using System.Collections.Generic;

class InventoryItem
{
    public string Name { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
}

class Program
{
    static List<InventoryItem> inventory = new List<InventoryItem>();

    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Add an item to inventory");
            Console.WriteLine("2. View inventory");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddItem();
                    break;
                case "2":
                    ViewInventory();
                    break;
                case "3":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void AddItem()
    {
        Console.Write("Enter the name of the item: ");
        string name = Console.ReadLine();

        Console.Write("Enter the quantity: ");
        int quantity = int.Parse(Console.ReadLine());

        Console.Write("Enter the price: ");
        double price = double.Parse(Console.ReadLine());

        InventoryItem newItem = new InventoryItem
        {
            Name = name,
            Quantity = quantity,
            Price = price
        };

        inventory.Add(newItem);

        Console.WriteLine("Item added to inventory successfully.");
    }

    static void ViewInventory()
    {
        Console.WriteLine("Inventory:");
        foreach (var item in inventory)
        {
            Console.WriteLine($"Name: {item.Name}, Quantity: {item.Quantity}, Price: {item.Price:C}");
        }
    }
}
