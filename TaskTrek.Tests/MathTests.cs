
namespace TaskTrek.Tests
{
    public class MathTests
    {
        [Fact]
        public void Add_TwoNumbers_ReturnsSum()
        {
            int a = 3;
            int b = 5;

            int result = a + b;

            Assert.Equal(8, result);
        }

        [Fact]
        public void Multiply_twoNumbers_ReturnsSum()
        {
            int a = 1;
            int b = 5;
            int result = a * b;
            Assert.Equal(5, result);
        }
    }
}