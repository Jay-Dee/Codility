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

            //var sln = new FrogJump.Solution();
            //sln.solution(10, 90, 30);

            //int[] sourceArray = { 2, 3, 1, 5 };
            //var sln = new MissingElement.Solution();
            //sln.solution(sourceArray);

            //int[] sourceArray = { 3, 1, 2, 4, 3 };
            //var sln = new TapeEquilibrium.Solution();
            //sln.solution(sourceArray);

            //int[] sourceArray = { 1, 3, 1, 4, 2, 3, 5, 4 };
            //var sln = new FrogRiverOne.Solution();
            //sln.solution(5, sourceArray);

            int[] sourceArray = { 4, 1, 3, 2 };
            var sln = new PermCheck.Solution();
            sln.solution(sourceArray);

            Console.ReadKey();
        }
    }
}