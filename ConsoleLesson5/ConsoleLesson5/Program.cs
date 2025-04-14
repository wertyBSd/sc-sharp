internal class Program
{
    private static void Main(string[] args)
    {
        List<int> list = new List<int>();
        int i = 200;
        while (true)
        {
            if(i%17 == 0)
            {
                list.Add(i);
            }
            if(i>500 ) break;
            i++;
        }
        Console.WriteLine(string.Join(", ", list));
    }
}