using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclicRotation {
    internal class Solution {
        public int[] solution(int[] A, int K) {
            Console.WriteLine($"{string.Join(", ", A)} rotated {K} times");
            var srcArray = new int[A.Length];
            var rotatedArray = new int[A.Length];
            A.CopyTo(rotatedArray, 0);
            if(K %  A.Length != 0) {
                for(int rotationCounter = 1; rotationCounter <= K ; rotationCounter++) {
                    rotatedArray.CopyTo(srcArray, 0);
                    for(int elementCounter = 0; elementCounter < A.Length; elementCounter++) {
                        int srcElementCounter = elementCounter + 1;
                        if(srcElementCounter > A.Length - 1) {
                            srcElementCounter = srcElementCounter - A.Length;
                        }

                        if(srcElementCounter == 0) {
                            rotatedArray[srcElementCounter] = srcArray[srcArray.Length - 1];
                        } else {
                            rotatedArray[srcElementCounter] = srcArray[srcElementCounter - 1];
                        }
                    }
                    Console.WriteLine(string.Join(", ", rotatedArray));
                }
            }
            Console.WriteLine($"Final rotation : {string.Join(", ", rotatedArray)}");
            return rotatedArray;
        }
    }
}
