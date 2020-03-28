using System;
using Xunit;

using Nysa.Logics;

namespace Nysa.Logics.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            try
            {
                Try<Int32> x = 23.Confirmed();

                Assert.True(x is Resolved<Int32>);
            }
            catch (Exception except)
            {
                Console.WriteLine(except.ToString());
            }
        }
    }

}
