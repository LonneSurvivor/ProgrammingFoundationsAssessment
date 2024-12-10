using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFoundationsAssessment
{
    internal class AverageFileSize
    {
        /// <summary>
        /// Displays details for a list of files
        /// </summary>
        public static void DisplayDetails()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            List<File> files = new List<File> { new File(1223), new File(53), new File(12), new File(9863), new File(242), new File(5), new File(23), new File(690), new File(453), new File(19) };
            int fileCount = files.Count;
            int averageFileSize;
            int totalFileSize = 0;
            
            // Foreach loop adding the filesize to the current total
            foreach (var file in files)
            {
                totalFileSize += file.fileSize;
            }

            averageFileSize = totalFileSize / fileCount;

            Console.WriteLine($"Total File Count: {fileCount} \r\nAverage File Size: {averageFileSize} \r\nTotal File Size: {totalFileSize}MB");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

    /// <summary>
    /// File object
    /// </summary>
    public class File
    {
        public int fileSize;

        public File(int fileSize)
        {
            this.fileSize = fileSize;
        }   
    }
}
