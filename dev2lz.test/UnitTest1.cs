using Dev;

namespace dev2lz.test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    } 

    [Test]
    public void Test1()
    {
        string s1 = "1";
        string s2 = "25 10";
        var result = logic.run(s1, s2);
        Assert.AreEqual("35", result);
    }
    [Test]
    public void Test2()
    {
        string s1 = "2";
        string s2 = "25 10";
        var result = logic.run(s1, s2);
        Assert.AreEqual("15", result);
    }
    [Test]
    public void Test3()
    {
        string s1 = "3";
        string s2 = "25 10";
        var result = logic.run(s1, s2);
        Assert.AreEqual("250", result);
    }
    [Test]
    public void Test4()
    {
        string s1 = "4";
        string s2 = "4 2";
        var result = logic.run(s1, s2);
        Assert.AreEqual("2000", result);
        Console.WriteLine(result);
    }
}