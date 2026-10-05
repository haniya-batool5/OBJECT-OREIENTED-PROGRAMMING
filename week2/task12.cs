using System;
using System.Collections.Generic;
using System.IO;

class Medicine
{
    string ExpiryDate;
    string Title;
    double Price;

    public Medicine(string ExpiryDate, string Title, double Price)
    {
        this.ExpiryDate = ExpiryDate;
        this.Title = Title;
        this.Price = Price;
    }

    public void Display()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Expiry Date: " + ExpiryDate);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        List<Medicine> medicines = new List<Medicine>();

        string[] lines = File.ReadAllLines("medicine.txt");

        foreach (string line in lines)
        {
            string[] data = line.Split(',');

            string title = data[0];
            string expiryDate = data[1];
            double price = double.Parse(data[2]);

            Medicine medicine = new Medicine(
                expiryDate,
                title,
                price
            );

            medicines.Add(medicine);
        }

        Console.WriteLine("All Medicines:");

        foreach (Medicine medicine in medicines)
        {
            medicine.Display();
        }
    }
}
