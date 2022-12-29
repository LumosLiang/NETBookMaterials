using HttpClient httpClient = new HttpClient();
string html = await httpClient.GetStringAsync("https://www.ptpress.com.cn");
Console.WriteLine(html);

var currentPath = "/Users/dawanzi/Projects/TempIOCache/test.txt";

//string destFilePath = "d:/1.txt";

string content = "hello async and await";
await File.WriteAllTextAsync(currentPath, content);
string content2 = await File.ReadAllTextAsync(currentPath);
Console.WriteLine(content2);


