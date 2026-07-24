namespace Section09;

public interface IInterfaceDemo
{
    void printStatement();
}

public class InterfaceDemo: IInterfaceDemo
{
    public void printStatement()
    {
        System.Console.WriteLine("Hello, Worls!");
    }
    public static void Run()
    {
        InterfaceDemo interfaceDemo = new InterfaceDemo();
        interfaceDemo.printStatement();
    }
}