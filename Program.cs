public class Program
{
    static void Swap<T>(ref T v1, ref T v2)
    {
        T temp = v1;
        v1 = v2;
        v2 = temp;
    }
    public static void Main(string[] args)
    {
        Console.Clear();
        int a = 1, b = 2;
        Swap<int>(ref a, ref b);
        Console.WriteLine($"a = {a}, b = {b}");

        string s1 = "Hello", s2 = "World";
        Swap<string>(ref s1, ref s2);
        Console.WriteLine($"s1 = {s1}, s2 = {s2}");
    }
}