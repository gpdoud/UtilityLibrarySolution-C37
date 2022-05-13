using UtilityLibrary;

namespace TestXunitMathLibrary {

    public class TestMathLib {

        [Theory]
        [InlineData(10, 2)]
        [InlineData(122, 10)]
        [InlineData(2, 0)]
        [InlineData(17, -5)]
        public void TestFn1(int ans, int op) {
            Assert.Equal(ans, MathLib.Fn1(op));
        }
    
        [Theory]
        [InlineData(3, 2, 1)]
        [InlineData(8, 7, 1)]
        public void TestAdd(int answer, int operand1, int operand2) {
            Assert.Equal(answer, MathLib.Add(operand1, operand2));
        }

        [Theory]
        [InlineData(1, 2, 1)]
        [InlineData(6, 7, 1)]
        [InlineData(-6, -5, 1)]
        public void TestSubtract(int answer, int operand1, int operand2) {
            Assert.Equal(answer, MathLib.Subtract(operand1, operand2));
        }
    }
}