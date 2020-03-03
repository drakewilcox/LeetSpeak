using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetSpeak;

namespace LeetSpeak.Tests
{
  [TestClass]
  public class LeetSpeakTranslatorTests
  {
    [TestMethod]
    public void TranslateMethod_TranslatesETo3_string()
    {
    LeetSpeakTranslator testTranslateMethod = new LeetSpeakTranslator();
    Assert.AreEqual("3", testTranslateMethod.TranslateMethod("e"));
    }

    [TestMethod]
    public void TranslateMethod_TranslatesOToZero_string()
    {
    LeetSpeakTranslator testTranslateMethod = new LeetSpeakTranslator();
    Assert.AreEqual("0", testTranslateMethod.TranslateMethod("o"));
    }

    [TestMethod]
    public void TranslateMethod_TranslatesIToOne_string()
    {
    LeetSpeakTranslator testTranslateMethod = new LeetSpeakTranslator();
    Assert.AreEqual("1", testTranslateMethod.TranslateMethod("I"));
    }
    [TestMethod]
    public void TranslateMethod_TranslatesTToSeven_string()
    {
    LeetSpeakTranslator testTranslateMethod = new LeetSpeakTranslator();
    Assert.AreEqual("7", testTranslateMethod.TranslateMethod("t"));
    }
    [TestMethod]
    public void TranslateMethod_TranslatesSToZ_string()
    {
    LeetSpeakTranslator testTranslateMethod = new LeetSpeakTranslator();
    Assert.AreEqual("Z", testTranslateMethod.TranslateMethod("s"));
    }
    [TestMethod]
    public void TranslateMethod_TranslatesFirstLetterSToSame_string()
    {
    LeetSpeakTranslator testTranslateMethod = new LeetSpeakTranslator();
    Assert.AreEqual("7hiZ iZ salm0n", testTranslateMethod.TranslateMethod("this is salmon"));
    }
    
  }
}