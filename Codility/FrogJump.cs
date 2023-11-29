using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogJump {
    internal class Solution {
        public int solution(int X, int Y, int D) {
            int numberOfJumps = 0;
            int distanceToCover = Y - X;
            Console.WriteLine($"Distance to cover = {distanceToCover}");
            if(distanceToCover > 0) {
                if(distanceToCover % D > 0) {
                    numberOfJumps++;
                }
                numberOfJumps += distanceToCover / D;
            }

            Console.WriteLine($"Required number of jumps of {D} length = {numberOfJumps}");
            return numberOfJumps;
        }
    }
}
