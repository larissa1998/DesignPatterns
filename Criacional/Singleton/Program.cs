class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Singleton");
        Console.WriteLine("s1");

        Singleton s1 = Singleton.Instance;

        Console.WriteLine(s2);
        
        Singleton s2 = Singleton.Instance;

        if(s1 == s2)
        {
            Console.WriteLine("só uma");
        }
        else
        {
            Console.WriteLine("diferente");
        }

        Console.Read();
    }
}