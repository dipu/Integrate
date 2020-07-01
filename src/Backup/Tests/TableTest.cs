using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using Iseries;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class TableTest : TestBase
    {
        [Test]
        public void ExecuteReader()
        {
            Library lib = Library.Create(this.AllorsSession, "TestLib");
            Table table = Table.Create(this.AllorsSession, lib, "TestFile");
            Assert.IsTrue(table != null);
            Assert.IsTrue(lib.Tables.Count == 1);

            string connectionstring = ConfigurationManager.ConnectionStrings["iseries"].ConnectionString;
            using (Session session = new Session(connectionstring))
            {
                table.ExecuteReader(session);
                session.Commit();
            }

            Assert.IsTrue(table.ExistColumns);
            Assert.IsTrue(table.ExistRows);

            foreach(Row row in table.Rows)
            {
                Assert.IsTrue(row.ExistCells);
                foreach(Cell cell in row.Cells)
                {
                    Assert.IsTrue(cell.ExistValue);
                }
            }


        }

        
    }
}
