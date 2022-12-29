using System;
using System.IO;
using NUnit.Framework;
using FindSpeed;

namespace FindSpeed.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        private StringWriter writer;
        
        [SetUp]
        public void SetUp()
        {
            writer = new StringWriter();
            Console.SetOut(writer);
        }
        
        [TearDown]
        public void Cleanup()
        {
            this.writer.Close();
        }
        
        [TestCase(5.2, 2.1, 3.5, 1, 21.3)]
        [TestCase(20.5,5.2, 5, 2.5, 140.75)]
        [TestCase(15.2, 7.8, 1.25, 3.5, 44.9)]
        [TestCase(10.54, 3.7, 2.5, 5.25, 62.26)] 
        public void Task1_ReturnsCorrectSpeed(double v, double u, double t1, double t2, double expected)
        {
            Tasks.Task1(v, u, t1, t2);

            var actual =Convert.ToDouble(this.writer.GetStringBuilder().ToString().Trim());

            Assert.AreEqual(expected, actual, 0.01, "Task1 returns incorrect value.");
        }

        [TestCase(30.5, 2.5, 75.2, 90, 443.5)]
        [TestCase(50.75, 5.5, 65.8, 90.2, 908.75)]
        [TestCase(5.12, 1.25, 80.12, 60, 180.27)]
        [TestCase(10.23, 1.25, 70.54, 110, 235.9)]
        public void Task2_ReturnsCorrectSpeed(double s, double t, double v1, double v2, double expected)
        {
            Tasks.Task2(s, t, v1, v2);
             
            var actual = Convert.ToDouble(this.writer.GetStringBuilder().ToString().Trim());

            Assert.AreEqual(expected, actual, 0.01, "Task2 returns incorrect value.");
        }
    }
}
