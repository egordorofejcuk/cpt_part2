public class Program
{
    public static T FindMin<T>(T[] array) where T : IComparable<T>
    {
        T minValue = array[0];
        foreach (T item in array)
        {
            if (item.CompareTo(minValue) < 0)
            {
                minValue = item;
            }
        }

        return minValue;
    }

    public static void Main()
    {
        int[] intArray = { 1, 2, 3, 4, 5, 6};
        Console.WriteLine("Минимальное в intArray: " + FindMin(intArray));
        double[] doubleArray = { 1.1, 1.2, 1.3, 1.4 };
        Console.WriteLine("Минимальное в doubleArray: " + FindMin(doubleArray));
    }
}