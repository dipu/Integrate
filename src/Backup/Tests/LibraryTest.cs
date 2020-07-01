using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Iseries;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class LibraryTest : TestBase
    {
        [Test]
        public void Create()
        {
            Library lib = Library.Create(this.AllorsSession, "TestLib");
            Assert.IsTrue(lib != null);
        }
    }
}
