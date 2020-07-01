using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Allors;
using NUnit.Framework;

namespace Tests
{
    public class TestBase
    {
        public AllorsSession AllorsSession = null;

        [SetUp]
        public void SetUp()
        {
            if (AllorsSession == null)
            {
                AllorsSession = AllorsConfiguration.CreateDisconnectedPopulation().CreateSession();
            }
        }

        [TearDown]
        public void TearDown()
        {
            AllorsSession.Rollback();
            //AllorsSession.Dispose();
            AllorsSession = null;
        }
    }
}
