namespace ProgrammingFoundationsAssessment
{
    internal class EmailAddress
    {
        /// <summary>
        /// Asks the user for their name and creates an email address
        /// </summary>
        public static void CreateEmail()
        {
            try
            {
                string firstname = "";
                char firstinitial;
                string lastname = "";
                string emailAddress;

                Console.ForegroundColor = ConsoleColor.Green;

                firstname = CheckForValidInput(firstname, "First");

                lastname = CheckForValidInput(lastname, "Last");   

                firstinitial = firstname[0];

                Console.WriteLine($"Your Email Address is: {firstinitial}.{lastname}@dundeeandangus.ac.uk");

                Console.ForegroundColor = ConsoleColor.Gray;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Checks the provided string is not empty or null
        /// </summary>
        /// <param name="input">User Input</param>
        /// <param name="nameType"></param>
        /// <returns></returns>
        private static string CheckForValidInput(string input, string nameType)
        {
            while (string.IsNullOrEmpty(input))
            {
                Console.Write($"Enter your {nameType} Name: ");
                input = Console.ReadLine();
                
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Invalid Input. Please Try Again");
                }
            }

            return input.ToLower();
        }
    }
}
