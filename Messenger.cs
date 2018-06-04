using System;

public interface IMessenger
{
    void Info(string message);
    void Error(string message);
}

public class Messenger : IMessenger
{
    public void Error(string message)
    {
        Console.WriteLine($"[ERROR]: {message}");
    }

    public void Info(string message)
    {
        Console.WriteLine(message);
    }
}