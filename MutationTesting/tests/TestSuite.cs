using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NinjaTurtles;
using NUnit.Framework;

namespace MutationTesting.tests
{
    [TestFixture]
    public class TestSuite
    {

        public TestSuite()
        {
        }

        [Test]
         public void TestCase4()
         {
             Assert.AreEqual(2, Program.triangle(2,2,3));
         }

         [Test]
         public void TestCase5()
         {
             Assert.AreEqual(4, Program.triangle(0,0,0));
         }

         [Test]
         public void TestCase6()
         {
             Assert.AreEqual(4, Program.triangle(1,1,3));
         }

         [Test]
         public void TestCase7()
         {
             Assert.AreEqual(1, Program.triangle(2,2,2));
         }

         [Test]
         public void TestCase8()
         {
             Assert.AreEqual(3, Program.triangle(2, 3, 4));
         }

         [Test, MutationTest]
         public void TestCase9()
         {
             MutationTestBuilder<Program>
                 .For("triangle")
                 .Run();
         }
    }
}
