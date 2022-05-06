// Integer.cs
namespace lab4_5 {
	public class Integer : INumber {
		private int value;
		public int Value { get => value; set => this.value = value; }

		public INumber Add(INumber number) => this + number;
		public INumber Division(INumber number) => this / number;
		public INumber Multiplication(INumber number) => this * number;
		public INumber Substaction(INumber number) => this - number;

		public static INumber operator +(Integer n1, INumber n2) {
			Integer result = new Integer();
			result.Value = n1.Value + ((Integer)n2).Value;
			return result;
}
		public static INumber operator -(Integer n1, INumber n2) {
			Integer result = new Integer();
			result.Value = n1.Value - ((Integer)n2).Value;
			return result;
}
		public static INumber operator *(Integer n1, INumber n2) {
			Integer result = new Integer();
			result.Value = n1.Value * ((Integer)n2).Value;
			return result;
}
		public static INumber operator /(Integer n1, INumber n2) {
			Integer result = new Integer();
			result.Value = n1.Value / ((Integer)n2).Value;
			return result;
		}
	}
}
