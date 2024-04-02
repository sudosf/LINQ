namespace LINQ {
	internal class Program {
		private static void Main(string[] args) {

			Method method = new();

			List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

			Console.WriteLine("Sum: " + method.rangeSum(numbers, 1, 100));
		}
	}
}