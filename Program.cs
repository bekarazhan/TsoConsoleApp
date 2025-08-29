using System;
using System.Collections.Generic;
using System.Linq;
class Program {
    static void Main() {
        var batch = new List<List<(int start, int end)>>
        {
            new List<(int,int)>
            {
                (1,3), (2,5), (4,6), (6,7), (5,8), (8,9)
            },

            new List<(int,int)>
            {
                (1,2), (2,3), (3,4), (4,5)
            },

            new List<(int,int)>(),

            new List<(int,int)>
            {
                (1,10), (2,9), (3,8), (4,7)
            },

            new List<(int,int)>
            {
                (1,10), (2,3), (3,4), (4,5), (6,7)
            }


        };

        int i = 1;
        foreach (var routes in batch) {
            int result = GetMaxNonOverlappingRoutes(routes);
            Console.WriteLine($"Test {i}  Max non-overlapping routes {result}");
            Console.WriteLine();
            i++;
        }
    }
    public static int GetMaxNonOverlappingRoutes(List<(int start, int end)> routes) {
        if (routes == null || routes.Count == 0)
            return 0;
        Console.WriteLine("Sorting routs by ends");
        var sorted = routes.OrderBy(r => r.end).ToList();

        int count = 0;
        int lastEnd = int.MinValue;
        Console.WriteLine("Starting");
        foreach (var route in sorted) {
            Console.WriteLine("* " + route);
            if (route.start >= lastEnd) {
                Console.WriteLine("lastEnd before " + lastEnd);
                count++;
                lastEnd = route.end;
                Console.WriteLine("lastEnd after " + lastEnd);
                Console.WriteLine("count " + count);
            } else {
                Console.WriteLine("skip! because route.start is less than lastend");
            }
        }
        Console.WriteLine("Ending");

        return count;
    }

}
