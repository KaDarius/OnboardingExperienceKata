using System;

namespace OnboardingExperience
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();

            Console.WriteLine("Hey there! Welcome to our onboarding experience");

            var question = "What is your First Name?";
            var answer = AskQuestion(question);
            user.FirstName = answer;

            Console.WriteLine("Awesome! Your name is " + user.FirstName);

            user.LastName = AskQuestion("What is your last name?");
            Console.WriteLine("Awesome! Your full name is " + user.FirstName + " " + user.LastName);

            user.IsAccountOwner = AskBoolQuestion("Are you the account owner?");
            Console.WriteLine("Awesome! You are account owner: " + user.IsAccountOwner);

            user.PinNumber = AskPinNumber("What is your 4-digit pin?", 4);
            Console.WriteLine("Awesome! You entered: " + user.PinNumber);

            Console.ReadLine();
        }

        /// <summary>
        /// Asks a question that the user can respond to, then returns it as a string
        /// </summary>
        /// <param name="question">The question to ask</param>
        /// <returns>The answer to the question</returns>
        public static string AskQuestion(string question)
        {
            // Writes out the question that we want to ask the user.
            Console.WriteLine(question);

            // Grab the answer that the user gave us
            var answer = Console.ReadLine();

            // Return that answer
            return answer;
        }

        static bool AskBoolQuestion(string question)
        {
            var hasAnswered = false;
            var responseBool = false;

            while (!hasAnswered)
            {
                var response = AskQuestion(question + " (y/n)");

                if (response == "y")
                {
                    responseBool = true;
                    hasAnswered = true;
                }
                else if (response == "n")
                {
                    responseBool = false;
                    hasAnswered = true;
                }
            }

            return responseBool;
        }

        /// <summary>
        /// The purpose of this method is to ask an int question 
        /// </summary>
        /// <param name="question">Question to be asked to the Console</param>
        /// <param name="limit">Assert that the length of the int is 4 digits</param>
        /// <returns></returns>
        static string AskPinNumber(string question, int length)
        {
            string numberString = null;

            while (numberString == null)
            {
                var response = AskQuestion(question);

                if (response.Length == length && Int32.TryParse(response, out int _))
                {
                    numberString = response;
                }
            }

            return numberString;
        }
    }
}
