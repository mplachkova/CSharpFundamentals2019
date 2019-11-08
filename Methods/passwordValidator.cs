using System;

namespace passwordValidator
{
    class passwordValidator
    {
        static void Main(string[] args)
        {
            //Write a program that checks if a given password is valid.Password rules are:
            //6 – 10 characters(inclusive)
            //Consists only of letters and digits
            //Have at least 2 digits
            //If a password is valid print "Password is valid".If it is not valid, for every unfulfilled rule print a message:
            //"Password must be between 6 and 10 characters"
            //"Password must consist only of letters and digits"
            //"Password must have at least 2 digits"

            string password = Console.ReadLine();
            CheckThePasswordConstraints(password);
        }

        static void CheckThePasswordConstraints(string text)
        {
            bool firstCondition = VerifyTheLength(text);
            bool secondCondition = ValidContent(text);
            bool thirdCondition = GotTwoDigits(text);
            if (firstCondition == true && secondCondition == true && thirdCondition == true)
            {
                Console.WriteLine("Password is valid");
            }
            if (firstCondition == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if(secondCondition == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if(thirdCondition == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }
        static bool VerifyTheLength(string text)
        {
            bool validLength = false;
            if (text.Length >= 6 && text.Length <= 10)
            {
                validLength = true;
            }
            return validLength;
        }

        static bool ValidContent(string text)
        {
            int textLength = text.Length;
            char letter;
            bool isLetterOrDigit = true;
            for (int i = 0; i < textLength; i++)
            {
                letter = (char)text[i];
                if (!char.IsLetterOrDigit(letter))
                {
                    isLetterOrDigit = false;
                    break;
                }
            }
            return isLetterOrDigit;
        }

        static bool GotTwoDigits(string text)
        {
            int textLength = text.Length;
            int digitCounter = 0;
            bool gotTwoDigits = false;
            char letter;
            for (int i = 0; i < textLength; i++)
            {
                letter = (char)text[i];
                if (char.IsDigit(letter))
                {
                    digitCounter++;
                }
                if (digitCounter == 2)
                {
                    gotTwoDigits = true;
                    break;
                }
            }
            return gotTwoDigits;
        }
    }
}