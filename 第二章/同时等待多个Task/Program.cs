// original code:
//Task<string> t1 = File.ReadAllTextAsync("d:/1.txt");
//Task<string> t2 = File.ReadAllTextAsync("d:/2.txt");
//Task<string> t3 = File.ReadAllTextAsync("d:/3.txt");
//string[] results = await Task.WhenAll(t1, t2, t3);
//string s1 = results[0];
//string s2 = results[1];
//string s3 = results[2];

class Program
{
    public static async Task Main(string[] args)
    {

        Console.WriteLine("Current Thread id is:" + Environment.CurrentManagedThreadId);
        Console.WriteLine("Current time is:" + DateTime.Now);

        Task<int> t1 = DoSomething1Async();
        Task<int> t2 = DoSomething2Async();
        Task<int> t3 = DoSomething3Async();

        var val1 = await t1;
        Console.WriteLine("after get val1, current Thread id is:" + Environment.CurrentManagedThreadId);

        var val2 = await t2;
        Console.WriteLine("after get val2, current Thread id is:" + Environment.CurrentManagedThreadId);

        var val3 = await t3;
        Console.WriteLine("after get val3, current Thread id is:" + Environment.CurrentManagedThreadId);

        Console.WriteLine("Current time is:" + DateTime.Now);

        // return val1 + val2 + val3;

    }

    public static async Task<int> DoSomething1Async()
    {
        Console.WriteLine("Current dosth1 Thread id is:" + Environment.CurrentManagedThreadId);
        await Task.Delay(5000);
        return 5;
    }

    public static async Task<int> DoSomething2Async()
    {

        Console.WriteLine("Current dosth2 Thread id is:" + Environment.CurrentManagedThreadId);
        await Task.Delay(10000);
        return 10;
    }

    public static async Task<int> DoSomething3Async()
    {
        Console.WriteLine("Current dosth3 Thread id is:" + Environment.CurrentManagedThreadId);
        await Task.Delay(15000);
        return 15;
    }

}

