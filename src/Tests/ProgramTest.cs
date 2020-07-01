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
    public class ProgramTest : TestBase
    {
        [Test]
        public void Create()
        {
            Library lib = Library.Create(this.AllorsSession, "TestLib");
            Program pgm = Program.Create(this.AllorsSession, "TestPgm", lib);
            Assert.IsTrue(pgm != null);
            Assert.IsTrue(lib.Programs.Count == 1);
        }

        [Test]
        public void AddParameters()
        {
            Library lib = Library.Create(this.AllorsSession, "TestLib");
            Program pgm = Program.Create(this.AllorsSession, "TestPgm", lib);

            Parameter parm1 = StringParameter.Create(this.AllorsSession, "@parm1", 10, "test1");
            pgm.FirstParameter = parm1;

            Parameter parm2 = StringParameter.Create(this.AllorsSession, "@parm2", 20, "test2");
            parm1.NextParameter = parm2;

            Parameter parm3 = IntParameter.Create(this.AllorsSession, "@parm3", 30);
            parm2.NextParameter = parm3;

            Parameter parm4 = DecimalParameter.Create(this.AllorsSession, "@parm4", 5, 2, 0M);
            parm3.NextParameter = parm4;

            Parameter parm5 = DateTimeParameter.Create(this.AllorsSession, "@parm5", DateTime.Now);
            parm4.NextParameter = parm5;

            Assert.IsTrue(pgm.Parameters.Count == 5);
        }

        [Test]
        public void Find()
        {
            Library lib = Library.Create(this.AllorsSession, "TestLib");
            Program pgm1 = Program.Create(this.AllorsSession, "TestPgm1", lib);
            Program pgm2 = Program.Create(this.AllorsSession, "TestPgm2", lib);
            Program pgm3 = Program.Create(this.AllorsSession, "TestPgm3", lib);
            Program pgm4 = Program.Create(this.AllorsSession, "TestPgm4", lib);
            Program pgm5 = Program.Create(this.AllorsSession, "TestPgm5", lib);

            Program apgm = lib.Find(this.AllorsSession, "TestPgm3");
            Assert.IsTrue(apgm == pgm3);
        }

        [Test]
        public void CallTest001()
        {
            Library lib = Library.Create(this.AllorsSession, "TestLib");
            StringParameter parm2;
            using (Program pgm = Program.Create(this.AllorsSession, "Test001", lib))
            {
                StringParameter parm1 = StringParameter.Create(this.AllorsSession, "@parm1", 10, "test1");
                pgm.FirstParameter = parm1;

                parm2 = StringParameter.Create(this.AllorsSession, "@parm2", 10, "");
                parm1.NextParameter = parm2;


                string connectionstring = ConfigurationManager.ConnectionStrings["iseries"].ConnectionString;
                using (Session session = new Session(connectionstring))
                {
                    pgm.Call(session);
                    session.Commit();
                }
            }

            Assert.IsTrue(parm2.Value == "test1");

        }

        [Test]
        public void CallTest002()
        {
            Library lib = Library.Create(this.AllorsSession, "TestLib");
            IntParameter parm2;
            using (Program pgm = Program.Create(this.AllorsSession, "Test002", lib))
            {
                IntParameter parm1 = IntParameter.Create(this.AllorsSession, "@parm1", 1235);
                pgm.FirstParameter = parm1;

                parm2 = IntParameter.Create(this.AllorsSession, "@parm2", 0);
                parm1.NextParameter = parm2;

                string connectionstring = ConfigurationManager.ConnectionStrings["iseries"].ConnectionString;
                using (Session session = new Session(connectionstring))
                {
                    pgm.Call(session);
                    session.Commit();
                }
            }

            Assert.IsTrue(parm2.Value == 1235);

        }

        [Test]
        public void CallTest003()
        {
            Library lib = Library.Create(this.AllorsSession, "TestLib");
            DecimalParameter parm2;
            using (Program pgm = Program.Create(this.AllorsSession, "Test003", lib))
            {
                DecimalParameter parm1 = DecimalParameter.Create(this.AllorsSession, "@parm1", 18, 2, 1235.23M);
                pgm.FirstParameter = parm1;

                parm2 = DecimalParameter.Create(this.AllorsSession, "@parm2", 18, 2, 0.00M);
                parm1.NextParameter = parm2;

                string connectionstring = ConfigurationManager.ConnectionStrings["iseries"].ConnectionString;
                using (Session session = new Session(connectionstring))
                {
                    pgm.Call(session);
                    session.Commit();
                }
            }

            Assert.IsTrue(parm2.Value == 1235.23M);

        }

        [Test]
        public void CallTest004()
        {
            Library lib = Library.Create(this.AllorsSession, "TestLib");
            DateTimeParameter parm2;
            DateTime tijd = DateTime.Now;

            using (Program pgm = Program.Create(this.AllorsSession, "Test004", lib))
            {
                DateTimeParameter parm1 = DateTimeParameter.Create(this.AllorsSession, "@parm1", tijd);
                pgm.FirstParameter = parm1;

                parm2 = DateTimeParameter.Create(this.AllorsSession, "@parm2", DateTime.MinValue);
                parm1.NextParameter = parm2;

                string connectionstring = ConfigurationManager.ConnectionStrings["iseries"].ConnectionString;
                using (Session session = new Session(connectionstring))
                {
                    pgm.Call(session);
                    session.Commit();
                }
            }

            Assert.IsTrue(parm2.Value.Date == tijd.Date);
            Assert.IsTrue(parm2.Value.Second == tijd.Second);
            Assert.IsTrue(parm2.Value.Minute == tijd.Minute);

        }

        [Test]
        public void CallTest005()
        {
            Library lib = Library.Create(this.AllorsSession, "TestLib");
            DateParameter parm2;
            DateTime tijd = DateTime.Now;

            using (Program pgm = Program.Create(this.AllorsSession, "Test005", lib))
            {
                DateParameter parm1 = DateParameter.Create(this.AllorsSession, "@parm1", tijd);
                pgm.FirstParameter = parm1;

                parm2 = DateParameter.Create(this.AllorsSession, "@parm2", DateTime.MinValue);
                parm1.NextParameter = parm2;

                string connectionstring = ConfigurationManager.ConnectionStrings["iseries"].ConnectionString;
                using (Session session = new Session(connectionstring))
                {
                    pgm.Call(session);
                    session.Commit();
                }
            }

            Assert.IsTrue(parm2.Value.Date == tijd.Date);

        }

        [Test]
        public void CallTest006()
        {
            Library lib = Library.Create(this.AllorsSession, "TestLib");
            IntParameter parm5;
            StringParameter parm6;
            DecimalParameter parm7;
            DateTimeParameter parm8;

            DateTime tijd = DateTime.Now;

            using (Program pgm = Program.Create(this.AllorsSession, "Test006", lib))
            {
                IntParameter parm1 = IntParameter.Create(this.AllorsSession, "@parm1", 25);
                pgm.FirstParameter = parm1;

                StringParameter parm2 = StringParameter.Create(this.AllorsSession, "@parm2", 20, "testing");
                parm1.NextParameter = parm2;

                DecimalParameter parm3 = DecimalParameter.Create(this.AllorsSession, "@parm3", 18,2, 118.36M);
                parm2.NextParameter = parm3;

                DateTimeParameter parm4 = DateTimeParameter.Create(this.AllorsSession, "@parm4", tijd);
                parm3.NextParameter = parm4;

                parm5 = IntParameter.Create(this.AllorsSession, "@parm5", 0);
                parm4.NextParameter = parm5;

                parm6 = StringParameter.Create(this.AllorsSession, "@parm6", 20, "");
                parm5.NextParameter = parm6;

                parm7 = DecimalParameter.Create(this.AllorsSession, "@parm7", 18, 2, 0.00M);
                parm6.NextParameter = parm7;

                parm8 = DateTimeParameter.Create(this.AllorsSession, "@parm8", DateTime.MinValue);
                parm7.NextParameter = parm8;

                string connectionstring = ConfigurationManager.ConnectionStrings["iseries"].ConnectionString;
                using (Session session = new Session(connectionstring))
                {
                    pgm.Call(session);
                    session.Commit();
                }
            }

            Assert.IsTrue(parm5.Value == 25);
            Assert.IsTrue(parm6.Value == "testing");
            Assert.IsTrue(parm7.Value == 118.36M);
            Assert.IsTrue(parm8.Value.Date == tijd.Date);

        }

        /// <summary>
        /// Updates a dataarea (typically used for storing sequence numbers)
        /// </summary>
        [Test]
        public void CallTest007()
        {
            Library lib = Library.Create(this.AllorsSession, "TestLib");
            IntParameter parm1;

            using (Program pgm = Program.Create(this.AllorsSession, "Test007", lib))
            {
                parm1 = IntParameter.Create(this.AllorsSession, "@parm1", 0);
                pgm.FirstParameter = parm1;

                string connectionstring = ConfigurationManager.ConnectionStrings["iseries"].ConnectionString;
                using (Session session = new Session(connectionstring))
                {
                    pgm.Call(session);

                    int result = parm1.Value;

                    Assert.IsTrue(parm1.Value > 0);

                    // Second call must update value with 1
                    pgm.Call(session);
                    Assert.IsTrue(parm1.Value == result + 1);
                    session.Commit();
                }

                
            }

            

        }
    }
}
