using System;
using NUnit.Framework;

namespace Example.Tests
{
    public class IssueExample
    {
        [Test]
        public void DoReproduce()
        {
            Assert.Throws<MissingMethodException>(() => Loader.Load());
        }
    }
}