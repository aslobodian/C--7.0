using static System.Console;

namespace BinaryLiterals {
	class Program {

		static void Main(string[] args) {

			int one = 0b1;
			int two = 0b10;
			int three = 0b11;
			int nineteen = 0b10011;

			WriteLine(nineteen);

			int[] numbers = { 0b1, 0b10, 0b11, 0b10011};
			foreach (var number in numbers) {
				WriteLine(number);
			}
		}
	}
}
