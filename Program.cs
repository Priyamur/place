// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
public abstract class TicketBooking
{
    public abstract void RedBus();
    public abstract void MovieShow();
    public void TrainTicket()
    {
        Console.WriteLine("train timings");
        Console.WriteLine("train name");
        Console.WriteLine("train no");
    }
}
public class Booking:TicketBooking
{
    public override void RedBus()
    {
        Console.WriteLine("bus details");
        Console.WriteLine("bus no");
        Console.WriteLine("passenger details");
    }
    public override void MovieShow()
    {
        Console.WriteLine("movie details");
        Console.WriteLine("theater details");
    }
}
class Program
{
    public static void Main(string [] args)
    {
        TicketBooking myticket = new Booking();
        myticket.RedBus();
        myticket.MovieShow();
    }

}