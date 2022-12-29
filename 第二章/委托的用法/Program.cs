
//MyDelegate d1 = SayEnglish;
//string s1 = d1(3);
//Console.WriteLine(s1);
//d1 = SayChinese;
//string s2 = d1(5);
//Console.WriteLine(s2);
//static string SayEnglish(int age)
//{
//	return $"Hello {age}";
//}

// version -1

MyDelegate d1 = SayChinese;
static string SayChinese(int age, int name)
{
    return $"你好 {age}, {name}";
}

//delegate int MyDelegate2(int m);


// version0
MyDelegate f10 = delegate (int i1, int i2)
{
    return $"{i1}+{i2}={i1 + i2}";
};

// version1
Func<int, int, string> f1 = delegate (int i1, int i2)
{
    return $"{i1}+{i2}={i1 + i2}";
};

// version2
Func<int, int, string> f2 = (i1, i2) => {
    return $"{i1}+{i2}={i1 + i2}";
};

// version3
Func<int, int, string> f3 = (i1, i2) => $"{i1}+{i2}={i1 + i2}";

public delegate string MyDelegate(int m, int n);

//MyDelegate d1 = SayEnglish;
//string s1 = d1(3);
//Console.WriteLine(s1);
//d1 = SayChinese;
//string s2 = d1(5);
//Console.WriteLine(s2);
//static string SayEnglish(int age)
//{
//    return $"Hello {age}";
//}
//static string SayChinese(int age)
//{
//    return $"你好 {age}";
//}
//delegate string MyDelegate(int n);
