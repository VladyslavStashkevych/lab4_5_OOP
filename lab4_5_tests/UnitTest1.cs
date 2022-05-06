using Xunit;
using lab4_5;

namespace lab4_5_tests {
	public class UnitTest1 {
		[Theory]
		[InlineData(10, 2)]
		public void Real_Addition_ReturnsCorrectValue(double d1, double d2) {
			Real r1 = new Real { Value = d1 };
			Real r2 = new Real { Value = d2 };
			double result = d1 + d2;

			Real actual = new Real { Value = ((Real)r1.Add(r2)).Value };

			Assert.Equal(result, actual.Value);
		}
	}
}