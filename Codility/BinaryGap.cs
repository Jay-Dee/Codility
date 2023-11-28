namespace BinaryGap {
    internal class Solution {
        public int solution(int N) {
            int largestBinaryGap = 0;
            string numberAsBinaryString = Convert.ToString(N, 2);
            Console.WriteLine($"{N} = {numberAsBinaryString}");
            int foundOne = 0;
            for(int counter = 0; counter < numberAsBinaryString.Length; counter++) {
                int binaryGap = 0;
                if (numberAsBinaryString[counter] == '1') {
                    foundOne++;
                    for(int internalCounter  = counter + 1; internalCounter < numberAsBinaryString.Length; internalCounter++) {
                        if (numberAsBinaryString[internalCounter] == '0') {
                            if(internalCounter + 1 == numberAsBinaryString.Length) {
                                binaryGap = 0;
                            } else {
                                binaryGap++;
                            }
                        } else {
                            counter = internalCounter - 1;
                            break;
                        }
                    }
                }

                if(largestBinaryGap < binaryGap) {
                    largestBinaryGap = binaryGap;
                }
            }

            if (foundOne <= 1) {
                largestBinaryGap = 0;
            }

            Console.WriteLine($"LargestBinaryGap = {largestBinaryGap}");
            return largestBinaryGap;
        }
    }
}
