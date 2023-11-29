namespace TapeEquilibrium {
    internal class Solution {
        public int solution(int[] A) {
            Console.WriteLine(string.Join(", ", A));
            int minDifference = int.MaxValue;

            var elementList = A.ToList();

            for(int elementCounter = 1;  elementCounter < elementList.Count; elementCounter++) {
                int sumTopHalf = elementList.Take(elementCounter).Sum();
                Console.WriteLine($"Sum of Top part = {sumTopHalf}");

                int sumBottomHalf = elementList.Skip(elementCounter).Sum();
                Console.WriteLine($"Sum of Bottom part = {sumBottomHalf}");

                if (Math.Abs(sumTopHalf - sumBottomHalf) < minDifference) {
                    minDifference = Math.Abs(sumTopHalf - sumBottomHalf);
                }
                Console.WriteLine($"At Counter = {elementCounter} min difference is {minDifference}");
                Console.WriteLine();
            }

            return minDifference;
        }
    }
}
