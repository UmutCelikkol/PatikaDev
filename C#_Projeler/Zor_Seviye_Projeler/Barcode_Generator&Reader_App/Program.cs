using System;
using System.Drawing;
using ZXing;

namespace Barcode_Generator_Reader_App;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Barcode Generator & Reader App");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("1. Generate Barcode");
        Console.WriteLine("2. Read Barcode");
        Console.WriteLine("3. Exit");
        while (true)
        {
            Console.WriteLine("Enter your choice (1-3):");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter the text for the barcode:");
                    string text = Console.ReadLine();
                    Console.WriteLine("Enter the file name (without extension) to save the barcode:");
                    string fileName = Console.ReadLine();
                    GenerateBarcode(text, fileName);
                    break;
                case "2":
                    Console.WriteLine("Enter the file name (without extension) to read the barcode:");
                    string barcodeFile = Console.ReadLine();
                    string barcodeText = ReadBarcode(barcodeFile);
                    Console.WriteLine($"Barcode Text: {barcodeText}");
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
            Console.WriteLine();
        }
    }
    static void GenerateBarcode(string text, string fileName)
    {
        BarcodeWriter writer = new BarcodeWriter
        {
            Format = BarcodeFormat.CODE_128,
            Options = new ZXing.Common.EncodingOptions
            {
                Width = 300,
                Height = 100
            }
        };
        Bitmap barcodeBitmap = writer.Write(text);
        string filePath = $"{fileName}.png";
        barcodeBitmap.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
        Console.WriteLine($"Barcode generated successfully. Saved as {filePath}");
    }
    static string ReadBarcode(string fileName)
    {
        Bitmap barcodeBitmap = (Bitmap)Image.FromFile($"{fileName}.png");
        BarcodeReader reader = new BarcodeReader();
        ZXing.Result result = reader.Decode(barcodeBitmap);
        string barcodeText = result?.Text;
        return barcodeText;
    }

}
