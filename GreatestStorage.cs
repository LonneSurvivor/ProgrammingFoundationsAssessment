namespace ProgrammingFoundationsAssessment
{
    internal class GreatestStorage
    {
        /// <summary>
        /// Checks the list of files and compares the sizes 
        /// </summary>
        public static void GetFileSize()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            IEnumerable<int> files = [12, 1223, 53, 12, 9863, 242, 5, 23, 690, 453, 19];

            Console.WriteLine($"The largest file is {files.Max()}MB");
        }
    }
}
