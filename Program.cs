namespace ProgrammingFoundationsAssessment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GreatestStorage.GetFileSize();
            EmailAddress.CreateEmail();
            AverageFileSize.DisplayDetails();
            SpeedSorting.SortBySpeed();
        }
    }

    public class ColorRandomizer()
    {
        private Random _random;
        
        public new ColorRandomizer() 
        {
            _random = new Random();
        }

        public Color GetRandomColor()
        {
            int randomR = _random.Next(0, 256);
            int randomG = _random.Next(0, 256); 
            int randomB = _random.Next(0, 256); 

            return Color.FromArgb(randomR, randomG, randomB); 
        }

        public ConsoleColor GetRandomForegroundColor(Color color)
        {
            int r = color.R > 128 ? 1 : 0;
            int g = color.G > 128 ? 2 : 0;
            int b = color.B > 128 ? 4 : 0; 

            int colorCode = r + g + b;

            return colorCode switch
            {
                0 => ConsoleColor.Black,
                1 => ConsoleColor.DarkRed,
                2 => ConsoleColor.DarkGreen,
                3 => ConsoleColor.DarkYellow,
                4 => ConsoleColor.DarkBlue,
                5 => ConsoleColor.DarkMagenta,
                6 => ConsoleColor.DarkCyan,
                7 => ConsoleColor.Gray,
                8 => ConsoleColor.DarkGray,
                9 => ConsoleColor.Red,
                10 => ConsoleColor.Green,
                11 => ConsoleColor.Yellow,
                12 => ConsoleColor.Blue,
                13 => ConsoleColor.Magenta,
                14 => ConsoleColor.Cyan,
                15 => ConsoleColor.White,
                _ => ConsoleColor.White,
            };
        }
    }
}
