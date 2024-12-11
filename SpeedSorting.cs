namespace ProgrammingFoundationsAssessment
{
    internal class SpeedSorting
    {
        ColorRandomizer _colorRandomizer;
        
        /// <summary>
        /// Bubble sorts a list of doubles to find the fastest speed
        /// </summary>
        public static void SortBySpeed()
        {
            _colorRandomizer = new ColorRandomizer();
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            List<double> speeds = new List<double> {12, 123, 54, 34, 6, 70, 57, 120, 634, 420 };
            double temp = 0;

            // Bubble sorts the speeds list to sort from fastest to slowest
            for(int i = 0; i <= speeds.Count -2;  i++)
            {
                for(int j = 0; j <= speeds.Count -2; j++)
                {
                    if (speeds[j] > speeds[j + 1])
                    {
                        temp = speeds[j + 1];
                        speeds[j + 1] = speeds[j];
                        speeds[j] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted List: ");

            foreach(double i in speeds)
            {
                Console.ForegroundColor = ColorRandomizer.GetRandomForegroundColor(ColorRandomizer.GetRandomColor());
                Console.Write($"{i} ");
            }
        }
    }
}
