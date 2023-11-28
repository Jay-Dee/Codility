namespace Codility {
    internal class Program {
        static void Main(string[] args) {
            int[] binaryGapTests = new int[] {0, 1, 2, 9, 15, 20, 32, 529, 1041 };
            foreach (int test in binaryGapTests) {
                var sln = new BinaryGap.Solution();
                sln.solution(test);
            }
            
            Console.ReadKey();
        }
    }
}