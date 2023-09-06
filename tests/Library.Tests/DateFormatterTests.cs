namespace TestDateFormat;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void FechaCorrecta()
    {
        string input = "22/11/2019";
        string expected = "2019-11-22";
        string output = DateFormatter.ChangeFormat(input);
        Assert.AreEqual(expected, output);
    }
    [Test]
    public void Vacio()
    {
        string input = "";
        string expected = "";
        string output = DateFormatter.ChangeFormat(input);
        Assert.AreEqual(output, expected);
    }
    [Test]
    public void FormatoIncorrecto()
    {
        string input = "05-04-2005";
        string expected = "";
        string output = DateFormatter.ChangeFormat(input);
        Assert.AreNotEqual(expected, output);
        
    }
}