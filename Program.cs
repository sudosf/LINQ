namespace LINQ {
	internal class Program {
		private static void Main(string[] args) {

			Methods method = new();

			List<int> numbers = Enumerable.Repeat(1, 10).ToList();

			int startIndex = 1;
			int endIndex = 10;

			Console.WriteLine("Sum: " + Methods.ListRangeSumExclusive(numbers, startIndex, endIndex));
		}
	}
}