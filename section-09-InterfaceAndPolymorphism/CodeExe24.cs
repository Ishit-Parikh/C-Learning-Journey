namespace Section09;

/*
Create a C# program that demonstrates Constructor Injection, Setter Injection, and Interface Injection. Implement a simple service ILoggingService and a class MyClass that depends on this service. Demonstrate each type of dependency injection method.

Alert!
The result of execution should be:
Constructor Injection: Logging message.
Setter Injection: Logging message.
Interface Injection: Logging message.
*/

public interface ILoggingService
{
    void Log(string message);
}

public class LoggingService : ILoggingService
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}

public class MyClassConstructorInjection
{
    private readonly ILoggingService _loggingService;
    public MyClassConstructorInjection(ILoggingService loggingService)
    {
        _loggingService = loggingService;
    }

    public void PerformAction()
    {
        _loggingService.Log("Constructor Injection: Logging message.");
    }
}

public class MyClassSetterInjection
{
    public ILoggingService LoggingService { private get; set; }

    public void PerformAction()
    {
        LoggingService.Log("Setter Injection: Logging message.");
    }
}

public interface IDependencyInjector
{
    void SetDependency(ILoggingService loggingService);
}

public class MyClassInterfaceInjection : IDependencyInjector
{
    private ILoggingService? _loggingService = null;
    public void SetDependency(ILoggingService loggingService)
    {
        _loggingService = loggingService;
    }

    public void PerformAction()
    {
        _loggingService.Log("Interface Injection: Logging message.");
    }
}

public class CodeExe24
{
    public static void Run()
    {
        var loggingService = new LoggingService();

        var constructorInjection = new MyClassConstructorInjection(loggingService);
        constructorInjection.PerformAction();

        var setterInjection = new MyClassSetterInjection { LoggingService = loggingService };
        setterInjection.PerformAction();

        var interfaceInjection = new MyClassInterfaceInjection();
        interfaceInjection.SetDependency(loggingService);
        interfaceInjection.PerformAction();
    }
}