
using System.Threading;

namespace AsyncMethod;

class Program
{
    public static async Task Main()
    {
        Console.WriteLine("开始下载人邮社网站");
        int i1 = await DownloadAsync("https://www.ptpress.com.cn", "/Users/dawanzi/Projects/TempIOCache/ptpress.html");
        Console.WriteLine($"下载完成，长度{i1}");
        
    }

    static async Task<int> DownloadAsync(string url, string destFilePath)
    {
        using HttpClient httpClient = new HttpClient();
        string body = await httpClient.GetStringAsync(url);
        await File.WriteAllTextAsync(destFilePath, body);
        return body.Length;
    }
}

