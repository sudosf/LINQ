using System.Linq;

namespace LINQ {

  public class Methods {

    public string ClassName { get; set; }

    public Methods() {
      ClassName = "Method class";
    }

    public static int ListRangeSumExclusive(List<int> numbers, int start, int end) {
      return numbers
          .Skip(start)
          .Take(end - start - 1)
          .Sum();
    }

    public static int ParallelListRangeSumExclusive(List<int> numbers, int start, int end) {
      return numbers
        .AsParallel()
        .Skip(start)
        .Take(end - start - 1)
        .Sum();
    }

  }
}