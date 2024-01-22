namespace FrogRiverOne {
    internal class Solution {
        public int solution(int X, int[] A) {
            int maxPosition = -1;
            for(int itemCounter = 1; itemCounter <= X; itemCounter++) {
                int foundAtPosition = -1;
                for (int arrayCounter = 0; arrayCounter < A.Length; arrayCounter++) {
                    if (A[arrayCounter] == itemCounter) {
                            foundAtPosition = arrayCounter;
                        break;
                    }
                }

                if(foundAtPosition != -1 && foundAtPosition > maxPosition) {
                    maxPosition = foundAtPosition;
                }
            }

            return maxPosition;
        }
    }
}