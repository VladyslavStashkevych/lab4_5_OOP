// INumber.cs
namespace lab4_5 {
	public interface INumber {
		public INumber Add(INumber number);
		public INumber Substaction(INumber number);
		public INumber Multiplication(INumber number);
		public INumber Division(INumber number);
	}
}
