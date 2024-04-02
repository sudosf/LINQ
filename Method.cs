using System.Linq;

namespace LINQ {

  public class Method {

    public string ClassName { get; set; }

    public Method() {
      ClassName = "Method class";
    }

    public int rangeSum(List<int> numbers, int a, int b) {

      return numbers.Where(num => num > a && num < b).Sum();
    }

  }
}