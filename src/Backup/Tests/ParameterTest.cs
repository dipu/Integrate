using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IBM.Data.DB2.iSeries;
using Iseries;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class ParameterTest : TestBase
    {
        [Test]
        public void CreateString()
        {
            StringParameter param = StringParameter.Create(this.AllorsSession, "strParam", 10, "TestValue");
            Assert.IsTrue(param != null);
            Assert.IsTrue(param.Value == "TestValue");
            Assert.IsTrue(param.Name == "strParam");
            Assert.IsTrue(param.Length == 10);

            iDB2Parameter newValue = new iDB2Parameter("strParam", iDB2DbType.iDB2VarChar, 10);
            newValue.Value = "newValue";
            param.UpdateValue(newValue);

            Assert.IsTrue(param.Value == "newValue");
        }

        [Test]
        public void CreateInt()
        {
            IntParameter param = IntParameter.Create(this.AllorsSession, "strParam", 100);
            Assert.IsTrue(param != null);
            Assert.IsTrue(param.Value == 100);
            Assert.IsTrue(param.Name == "strParam");

            iDB2Parameter newValue = new iDB2Parameter("strParam", iDB2DbType.iDB2Integer);
            newValue.Value = 200;
            param.UpdateValue(newValue);

            Assert.IsTrue(param.Value == 200);
        }

        [Test]
        public void CreateDateTime()
        {
            DateTime tijd = DateTime.Now;

            DateTimeParameter param = DateTimeParameter.Create(this.AllorsSession, "strParam", tijd);
            Assert.IsTrue(param != null);
            Assert.IsTrue(param.Value == tijd);
            Assert.IsTrue(param.Name == "strParam");

            iDB2Parameter newValue = new iDB2Parameter("strParam", iDB2DbType.iDB2TimeStamp);
            DateTime newtijd = DateTime.Now;
            newValue.Value = newtijd;
            param.UpdateValue(newValue);

            Assert.IsTrue(param.Value == newtijd);
        }

        [Test]
        public void CreateDecimal()
        {
            DecimalParameter param = DecimalParameter.Create(this.AllorsSession, "strParam", 4, 2, 10.23M);
            Assert.IsTrue(param != null);
            Assert.IsTrue(param.Value == 10.23M);
            Assert.IsTrue(param.Name == "strParam");

            iDB2Parameter newValue = new iDB2Parameter("strParam", iDB2DbType.iDB2Decimal);
            newValue.Value = 19.86M;
            param.UpdateValue(newValue);

            Assert.IsTrue(param.Value == 19.86M);
        }
    }
}
