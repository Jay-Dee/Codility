using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermCheck {
    internal class Solution {
        public int solution(int[] A) {
            var maxValue = A.Max();
            Console.WriteLine($"MaxValue = {maxValue}");
            var length = A.Distinct().Count();
            Console.WriteLine($"Length = {length}");

            return maxValue == length ? 1 : 0;
        }
    }
}
