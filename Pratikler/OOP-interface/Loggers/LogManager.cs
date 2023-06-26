using System;

namespace OOP_interface;

public class LogManager:ILogger
{
    public ILogger _logger; // ILogger interface referansi aliriz, instance olusturamazsiniz.

    public LogManager(ILogger logger)
    {
        _logger =logger;
    }

    public void WriteLog()
    {
        _logger.WriteLog();
    }
}