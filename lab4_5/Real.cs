// Real.cs
namespace lab4_5 {
	public class Real : INumber {
		private double value;
		public double Value { get => value; set => this.value = value; }

		public INumber Add(INumber number) => this + number;
		public INumber Division(INumber number) => this / number;
		public INumber Multiplication(INumber number) => this * number;
		public INumber Substaction(INumber number) => this - number;

		public static INumber operator +(Real n1, INumber n2) {
			Real result = new Real();
			result.Value = n1.Value + ((Real)n2).Value;
			return result;
		}
		public static INumber operator -(Real n1, INumber n2) {
			Real result = new Real();
			result.Value = n1.Value - ((Real)n2).Value;
			return result;
		}
		public static INumber operator *(Real n1, INumber n2) {
			Real result = new Real();
			result.Value = n1.Value * ((Real)n2).Value;
			return result;
		}
		public static INumber operator /(Real n1, INumber n2) {
			Real result = new Real();
			result.Value = n1.Value / ((Real)n2).Value;
			return result;
		}
	}
}
