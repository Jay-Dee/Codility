namespace MissingElement {
    internal class Solution {
        public int solution(int[] A) {
            Console.WriteLine(string.Join(", ", A));
            int missingElement = int.MinValue;
            Array.Sort(A);
            Console.WriteLine(string.Join(", ", A));
            for(int elementCounter = 1; elementCounter < A.Length; elementCounter++) {
                if (A[elementCounter] - A[elementCounter -1] > 1 ) {
                    missingElement = elementCounter + 1;
                    break;
                }
            }
            Console.WriteLine($"Missing element : {missingElement}");

            return missingElement;
        }
    }
}
