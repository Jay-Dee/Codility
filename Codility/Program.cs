namespace Codility {
    internal class Program {
        static void Main(string[] args) {
            //int[] binaryGapTests = new int[] {0, 1, 2, 9, 15, 20, 32, 529, 1041 };
            //foreach (int test in binaryGapTests) {
            //    var sln = new BinaryGap.Solution();
            //    sln.solution(test);
            //}

            //int[] sourceArray = { 3, 8, 9, 7, 6 };
            //var sln = new CyclicRotation.Solution();
            //sln.solution(sourceArray, 3);


            //int[] sourceArray = { 1, 2, 1, 2, 3, 3, 5, 4, 4, 6, 7, 8, 6, 7, 8 };
            //var sln = new OddOccurrencesInArray.Solution();
            //sln.solution(sourceArray);

            var sln = new FrogJump.Solution();
            sln.solution(10, 90, 30);

            Console.ReadKey();
        }
    }
}