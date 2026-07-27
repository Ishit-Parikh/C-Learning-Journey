namespace Section10;

public class StructsDemo
{
    public struct Point
    {
        public int X, Y;
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void Display()
        {
            Console.WriteLine($"Point: ({X},{Y})");
        }
    }

    public class pointClass
    {
        public int X, Y;
        public pointClass(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void Display()
        {
            Console.WriteLine($"Point: ({X},{Y})");
        }
    }

    public static void Run()
    {
        Console.WriteLine("=== STRUCT (Value Type) ===");
        Point point = new Point(1, 2);
        System.Console.Write("point: ");
        point.Display();

        Console.WriteLine("\nAssigning point to point1 (struct = struct copies the value)");
        Point point1 = point;

        Console.WriteLine("Changing point1.X to 3...");
        point1.X = 3;

        Console.WriteLine("Since struct is a value type, point1 is an independent copy.");
        Console.WriteLine("Changing point1 does NOT affect point:\n");
        System.Console.Write("point:  ");
        point.Display();
        System.Console.Write("point1: ");
        point1.Display();

        Console.WriteLine("\n=== CLASS (Reference Type) ===");
        pointClass pc = new pointClass(1, 2);
        System.Console.Write("pc: ");
        pc.Display();

        Console.WriteLine("\nAssigning pc to pc1 (class = class copies the reference)");
        pointClass pc1 = pc;

        Console.WriteLine("Changing pc1.X to 3...");
        pc1.X = 3;

        Console.WriteLine("Since class is a reference type, pc and pc1 point to the SAME object.");
        Console.WriteLine("Changing pc1 also changes pc:\n");
        System.Console.Write("pc:  ");
        pc.Display();
        System.Console.Write("pc1: ");
        pc1.Display();
    }
}
