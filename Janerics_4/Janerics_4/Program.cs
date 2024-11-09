public class Program
{
    public static void Swap<T>(ref T firstValue, ref T secondValue)
    {
        T temp = firstValue;   
        firstValue = secondValue;   
        secondValue = temp;    
    }

    public static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine(a + " " + b);
        Swap(ref a, ref b);
        Console.WriteLine(a + " " + b);
    }
}
