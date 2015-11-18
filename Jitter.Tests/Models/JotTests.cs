using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jitter.Models;

namespace Jitter.Tests.Models
{
    [TestClass]
    public class JotTests
    {
        [TestMethod]
        public void JotEnsureICanCreateInstance()
        {
            Jot a_jot = new Jot();
            Assert.IsNotNull(a_jot);
        }

        [TestMethod]
        public void JotEnsureJotHasAllTheThings()
        {
            Jot a_jot = new Jot();
            DateTime expected_time = DateTime.Now;
            a_jot.JotID = 1;
            a_jot.Content = "My Content";
            a_jot.Date = expected_time;
            a_jot.Author = null; //Will need to define this later
            a_jot.Picture = "https://google.com";
            Assert.AreEqual(1, a_jot.JotID);
            Assert.AreEqual("My Content", a_jot.Content);
            Assert.AreEqual(expected_time, a_jot.Date);
            Assert.AreEqual(null, a_jot.Author);
            Assert.AreEqual("https://google.com", a_jot.Picture);
        }

        [TestMethod]
        public void JotEnsureICanUseObjectInitializerSyntax()
        {
            DateTime expected_time = DateTime.Now;
            Jot a_jot = new Jot { JotID = 1, Content = "My Content", Date = expected_time, Author = null, Picture = "https://google.com" };
            Assert.AreEqual(1, a_jot.JotID);
            Assert.AreEqual("My Content", a_jot.Content);
            Assert.AreEqual(expected_time, a_jot.Date);
            Assert.AreEqual(null, a_jot.Author);
            Assert.AreEqual("https://google.com", a_jot.Picture);
        }
    }
}
