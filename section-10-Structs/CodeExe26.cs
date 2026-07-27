namespace Section10;

/*
Create a simple C# program that demonstrates the use of structs with DateTime and Math operations. The program should:
Declare a struct Event with the following members:
A DateTime field called StartDate.
A DateTime field called EndDate.
A method double GetDuration() that returns the duration of the event in days.
A method bool IsOverlapping(Event otherEvent) that returns true if the event overlaps with another event.
In the Exercise class, create a method TestEvents() that:
Creates two Event instances with different start and end dates.
Prints the duration of each event.
Checks and prints whether the two events overlap.

Alert!
The result of execution should be the duration of each event and whether they overlap printed to the console.
Example:
For an event starting on 2024-07-01 and ending on 2024-07-10, and another event starting on 2024-07-05 and ending on 2024-07-15, the output should be:
Event 1 Duration: 9 days
Event 2 Duration: 10 days
Events Overlap: True
*/

public struct Event
{
    public DateTime StartDate;
    public DateTime EndDate;

    public Event(DateTime startDate, DateTime endDate)
    {
        StartDate = startDate;
        EndDate = endDate;
    }

    public double GetDuration()
    {
        return (EndDate - StartDate).TotalDays;
    }

    public bool IsOverlapping(Event otherEvent)
    {
        return StartDate < otherEvent.EndDate && otherEvent.StartDate < EndDate;
    }
}

public class CodeExe26
{
    public static void Run()
    {
        Event event1 = new Event(new DateTime(2024, 7, 1), new DateTime(2024, 7, 10));
        Event event2 = new Event(new DateTime(2024, 7, 5), new DateTime(2024, 7, 15));

        Console.WriteLine($"Event 1 Duration: {event1.GetDuration()} days");
        Console.WriteLine($"Event 2 Duration: {event2.GetDuration()} days");
        Console.WriteLine($"Events Overlap: {event1.IsOverlapping(event2)}");
    }
}