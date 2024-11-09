using DIP;

public class Program
{
    public static void Main(string[] args)
    {
        ILogger logger = new Logger();
        MyService service = new MyService(logger);
        service.Process();
    }
}