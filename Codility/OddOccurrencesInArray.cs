namespace OddOccurrencesInArray {
    internal class Solution {
        public int solution(int[] A) {
            Console.WriteLine(string.Join(", ", A));

            int unmatchedElement = int.MinValue;

            var elementWithNoMatch = A.GroupBy(a => a).Where(g => g.Count() == 1);
            unmatchedElement = elementWithNoMatch.First().Key;
            Console.WriteLine($"Unmatched element = {unmatchedElement}");

            return unmatchedElement;
        }
    }
}
