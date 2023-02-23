namespace ReizAssigments;

public class Clock
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the hours (in 24-hour format):");
        int hours = int.Parse(Console.ReadLine());
            
        Console.WriteLine("Enter the minutes:");
        int minutes = int.Parse(Console.ReadLine());
            
        int hourDegree = hours * 30; // 1 hour = 30 degrees
        int minuteDegree = minutes * 6; // 1 minute = 6 degrees
        int secondDegree = (hourDegree + minuteDegree) % 360; // 1 full rotation = 360 degrees
            
        Console.WriteLine("The degree of the seconds arrow is: " + secondDegree);
    }
}