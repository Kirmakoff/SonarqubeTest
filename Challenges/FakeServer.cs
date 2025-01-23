using System;

namespace SonarqubeTest.Challenges;

public class FakeServer
{
    public void Initialize()
    {
        Console.WriteLine("Init");
    }

    public void DoStuff()
    {
        Console.WriteLine("Doing stuff");
    }

    public void Dispose()
    {
        Console.WriteLine("Disposed");
    }
}