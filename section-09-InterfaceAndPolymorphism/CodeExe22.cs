namespace Section09;

/*
Create a simple C# program that demonstrates the implementation and use of interfaces. Define an interface IVehicle with a method Drive. Then, create a class Car that implements this interface and provides an implementation for the Drive method. Print a message to the console from the Drive method.

Alert!
The result of execution should be:
"Car is driving"
*/

public interface IVehicle
{
    void Drive();
}

public class Car: IVehicle
{
    public void Drive()
    {
        System.Console.WriteLine("Car is driving");
    }
}

public class CodeExe22
{
    public static void Run()
    {
        Car car = new Car();
        car.Drive();
    }
}