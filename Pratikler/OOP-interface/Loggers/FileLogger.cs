using System;

namespace OOP_interface;

public class FileLogger : ILogger
{
    public void WriteLog()
    {
        Console.WriteLine("File loglarini yazar");
    }
}