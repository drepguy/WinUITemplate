using Microsoft.UI.Xaml.Controls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.AppContainer;
using WinUIStudio.ViewModels;

namespace WinUIStudio.Tests;
[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        Assert.AreEqual(0, 0);
    }

    // Use the UITestMethod attribute for tests that need to run on the UI thread.
    [TestMethod]
    public void TestMethod2()
    {
        Assert.AreEqual(0, 0);
    }

    [TestMethod]
    public void TestMethod3()
    {
        var vm = new BlankViewModel();
        Assert.AreEqual("Hallo Welt!", vm.Title);
    }
}
