using M013_Exception;

// MSTest Test Project => WICHTIG!: Achtet auf .NET 8.0 Version

namespace M013_UnitTest;

[TestClass]
public class RechnerTests
{
    private Rechner r;
    [TestInitialize]
    public void Startup() => r = new Rechner();

    //public void Startup()
    //{
    //    r = new Rechner();
    //}

    [TestCleanup]
    public void CleanUp() => r = null;

    /////////////
    [TestMethod]
    [TestCategory("Addieren")]
    public void TestAddiere()
    {
        double ergebnis = r.Addieren(4, 5);
        Assert.AreEqual(9, ergebnis);
    }

    [TestMethod]
    [TestCategory("Subtrahieren")]
    public void TestSubtrahiere()
    {
        double ergebnis = r.Subtrahieren(4, 5);
        Assert.AreEqual(-1, ergebnis);
    }
}
