using System;

namespace OOP_interface;

public class DatabaseLogger : ILogger
{
    public void WriteLog()
    {
        Console.WriteLine("Database loglarini yazar");
    }
}