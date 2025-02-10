public class Program
{
    static void Swap<T>(ref T v1, ref T v2)
    {
        T temp = v1;
        v1 = v2;
        v2 = temp;
    }
    /*static void Swap<T, V>(ref T v1, ref V v2)
    {
       
    }*/
    /* Sử dụng generic để xây dựng hàm tính tổng hai số, hai xâu, hai mảng*/
    static T Sum<T>(T a, T b){
        //Nếu a, b là mảng thì
        if(a.GetType()==typeof(int[]) && b.GetType()==typeof(int[])){
            //Xử lý
            int[] result = new int[((dynamic)a).Length + ((dynamic)b).Length];
            for(int i=0; i<((dynamic)a).Length; i++)
                result[i] = ((dynamic)a)[i];
            for(int i=0; i<((dynamic)b).Length; i++)
                result[i+((dynamic)a).Length] = ((dynamic)b)[i];
            return (dynamic)result;
        }
        //Nếu ngược lại,
        else
            return (dynamic)a + (dynamic)b;
    }
    public static void Main(string[] args)
    {
        Console.Clear();

        int a = 1, b = 2;
        Console.WriteLine($"{a}+{b}={Sum<int>(a, b)}");

        string s1 = "Hello", s2 = "World";
        Console.WriteLine($"{s1}+{s2}={Sum<string>(s1, s2)}");

        int[] arr1 = {1, 2, 3}, arr2 = {4, 5, 6};
        Console.WriteLine($"[{string.Join(", ", arr1)}]+[{string.Join(", ", arr2)}]=[{string.Join(", ", Sum<int[]>(arr1, arr2))}]");

        /*int a = 1, b = 2;
        Swap<int>(ref a, ref b);
        Console.WriteLine($"a = {a}, b = {b}");

        string s1 = "Hello", s2 = "World";
        Swap<string>(ref s1, ref s2);
        Console.WriteLine($"s1 = {s1}, s2 = {s2}");*/

        /*Console.WriteLine("---------------------");
        int v1 = 1;
        string v2 = "Hello";
        int[] v3 = {1, 2, 3};
        Console.WriteLine(v1.GetType()==typeof(int));
        Console.WriteLine(v2.GetType()==typeof(string));
        Console.WriteLine(v3.GetType()==typeof(int[]));*/
    }
}