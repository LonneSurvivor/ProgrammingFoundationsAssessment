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
            List<int> files = new List<int> {12, 1223, 53, 12, 9863, 242, 5, 23, 690, 453, 19};
            int fileSize;
            int largestFileSize = 0;
           
            foreach (int file in files)
            {
                
                fileSize = file;

                if (fileSize > largestFileSize)
                {
                    largestFileSize = fileSize;
                }
            }

            Console.WriteLine($"The largest file is {largestFileSize}MB.");
        }
    }
}
