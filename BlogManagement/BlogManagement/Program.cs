using System;

namespace BlogManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}




























/*static void Main(string[] args)
{
    // 1 - Created
    // 2 - Boxed
    // 3 - Sended
    // 4 - On Way
    // 5 - In Terminal
    // 6 - Completed

    Declaration declaration = new Declaration("BPX794200", "Azerbaijan", StatusCodes.Created); //magic numbers
    Declaration declaration2 = new Declaration("BPX794200", "Azerbaijan", StatusCodes.Boxed);
    Declaration declaration3 = new Declaration("BPX794200", "Azerbaijan", StatusCodes.Sended);
    Declaration declaration4 = new Declaration("BPX794200", "Azerbaijan", StatusCodes.OnWay);
    Declaration declaration5 = new Declaration("BPX794200", "Azerbaijan", StatusCodes.InTerminal);
    Declaration declaration6 = new Declaration("BPX794200", "Azerbaijan", StatusCodes.Completed);
}
    }

    public class Declaration
{
    public string TrackingCode { get; set; }
    public string Country { get; set; }
    public byte Status { get; set; }
    public DateTime OrderDate { get; set; } = DateTime.Now;

    public Declaration(string trackingCode, string country, byte status)
    {
        TrackingCode = trackingCode;
        Country = country;
        Status = status;
    }
}

public static class StatusCodes
{
    public static byte Created { get; } = 1;
    public static byte Boxed { get; } = 2;
    public static byte Sended { get; } = 3;
    public static byte OnWay { get; } = 4;
    public static byte InTerminal { get; } = 5;
    public static byte Completed { get; } = 6;
}

    /*public enum DeclarationStatus
    {
        Created,
        Boxed,
        Sended,
        OnWay,
        InTerminal,
        Completed
    }*/