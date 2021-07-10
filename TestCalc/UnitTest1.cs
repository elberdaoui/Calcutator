using System;
using System.Buffers;
using Xunit;
using Calcutator;

namespace TestCalc
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(8, Convert.ToInt32(Operations.Add(4, 4)));
        }

        [Fact]
        public void Test2()
        {
            
            Assert.Equal(0, Convert.ToInt32(Operations.Sub(4, 4)));
        }

        [Fact]
        public void Test3()
        {
            Assert.Equal(16, Convert.ToInt32(Operations.Mul(4, 4)));
        }

        [Fact]
        public void Test4()
        {
            Assert.Equal(1, Convert.ToInt32(Operations.Div(4, 4)));
        }
    }
}
