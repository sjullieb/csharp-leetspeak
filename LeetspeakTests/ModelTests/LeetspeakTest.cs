using Microsoft.VisualStudio.TestTools.UnitTesting;
using Translator;

namespace Translator.Tests
{
  [TestClass]
  public class LeetspeakTranslatorTest
  {
    [TestMethod]
    public void Translate_NoRulesForTheLetter_Input()
    {
      LeetspeakTranslator leetspeakTranslatorTest = new LeetspeakTranslator();
      Assert.AreEqual("c", leetspeakTranslatorTest.Translate("c"));
    }
    [TestMethod]
    public void Translate_ERaplacedWith3_3()
    {
      LeetspeakTranslator leetspeakTranslatorTest = new LeetspeakTranslator();
      Assert.AreEqual("3", leetspeakTranslatorTest.Translate("e"));
    }
    [TestMethod]
    public void Translate_ORaplacedWith0_0()
    {
      LeetspeakTranslator leetspeakTranslatorTest = new LeetspeakTranslator();
      Assert.AreEqual("0", leetspeakTranslatorTest.Translate("o"));
    }
    [TestMethod]
    public void Translate_CapitalIRaplacedWith1_1()
    {
      LeetspeakTranslator leetspeakTranslatorTest = new LeetspeakTranslator();
      Assert.AreEqual("1", leetspeakTranslatorTest.Translate("I"));
    }
    [TestMethod]
    public void Translate_TRaplacedWith7_7()
    {
      LeetspeakTranslator leetspeakTranslatorTest = new LeetspeakTranslator();
      Assert.AreEqual("7", leetspeakTranslatorTest.Translate("t"));
    }
    [TestMethod]
    public void Translate_SReplacedWithZ_Z()
    {
      LeetspeakTranslator leetspeakTranslatorTest = new LeetspeakTranslator();
      Assert.AreEqual("mazz", leetspeakTranslatorTest.Translate("mass"));
    }
    [TestMethod]
    public void Translate_SNotReplacedBeginnigOfPhrase_S()
    {
      LeetspeakTranslator leetspeakTranslatorTest = new LeetspeakTranslator();
      Assert.AreEqual("sum", leetspeakTranslatorTest.Translate("sum"));
    }
    [TestMethod]
    public void Translate_SNotReplacedBeginnigOfWord_S()
    {
      LeetspeakTranslator leetspeakTranslatorTest = new LeetspeakTranslator();
      Assert.AreEqual("A sum", leetspeakTranslatorTest.Translate("A sum"));
    }

  }
}
