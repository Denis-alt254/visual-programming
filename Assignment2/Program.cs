using System;
using System.Collections.Generic;
using System.IO;

struct GroceryItem {
    public string ID;
    public string Name;
    public int Qty;
    public double Price;
    public double SubTotal;
}

class Program {
    static void Main() {
        // 1. Ask for input file 
        Console.Write("Enter the input file name (e.g., items.txt): ");
        string fileName = Console.ReadLine();
        
        List<GroceryItem> cart = new List<GroceryItem>();
        double grandTotal = 0;

        // 2. Read and process file 
        ProcessFile(fileName, cart, ref grandTotal);

        // 4. Print Receipt to Console [cite: 42]
        PrintReceipt(cart, grandTotal);

        // 5. Write to output file [cite: 43]
        WriteOutputFile("receipt_output.txt", cart, grandTotal);
    }

    static void ProcessFile(string path, List<GroceryItem> list, ref double total) {
        if (!File.Exists(path)) return;

        string[] lines = File.ReadAllLines(path);
        foreach (string line in lines) {
            string[] parts = line.Split(','); // Assuming CSV format
            GroceryItem item = new GroceryItem {
                ID = parts[0],
                Name = parts[1],
                Qty = int.Parse(parts[2]),
                Price = double.Parse(parts[3])
            };
            
            // 3. Calculate totals 
            item.SubTotal = item.Qty * item.Price;
            total += item.SubTotal;
            list.Add(item);
        }
    }

    static void PrintReceipt(List<GroceryItem> list, double total) {
        double tax = total * 0.16; // 16% VAT 
        Console.WriteLine("\n--- SHOPPING RECEIPT ---");
        foreach (var item in list) {
            Console.WriteLine($"{item.Name,-10} x{item.Qty} @{item.Price:N2} = {item.SubTotal:N2}");
        }
        Console.WriteLine("------------------------");
        Console.WriteLine($"Sub-total: {total:N2}");
        Console.WriteLine($"VAT (16%): {tax:N2}");
        Console.WriteLine($"Grand Total: {(total + tax):N2}");
    }

    static void WriteOutputFile(string path, List<GroceryItem> list, double total) {
        // Implementation for writing to file [cite: 43]
    }
}