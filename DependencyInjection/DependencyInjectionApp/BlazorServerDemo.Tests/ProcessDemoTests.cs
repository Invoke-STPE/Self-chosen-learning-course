using BlazorServerDemo.Data;
using System;
using Xunit;

namespace BlazorServerDemo.Tests
{
    public class ProcessDemoTests
    {
        [Fact]
        public void GetDaysInMonth_ShouldReturnProperNumberForLeapYear()
        {
            TestingDemo t = new(DateTime.Parse("01/02/2000"));
            ProcessDemo processDemo = new(t);
            int expected = 29;
            int actual = processDemo.GetDaysInMonth();

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetDaysInMonth_ShouldReturnProperNumberForNonLeapYear()
        {
            TestingDemo t = new(DateTime.Parse("01/02/2001"));
            ProcessDemo processDemo = new(t);
            int expected = 28;
            int actual = processDemo.GetDaysInMonth();

            Assert.Equal(expected, actual);
        }
    }

    public class TestingDemo : IDemo
    {
        public DateTime StartupTime { get; init; }

        public TestingDemo(DateTime startTime)
        {
            StartupTime = startTime;
        }
    }
}
