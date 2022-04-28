
namespace C_Sharp_Lesson_1_Homework
{
    public class Homework
    {
        public void CheckIfNumberIsEvenOrOdd(int number)
        {
            /* Exercise 1
          * using "if" write a programm that checks whether an integer is greater then zero and even or odd
          * Example:
          * -------------------------------------------------
          * |input   | result                               |
          * |--------|--------------------------------------|
          * |  1     | even                                 |
          * |--------|--------------------------------------|
          * |  2     | odd                                  |
          * |--------|--------------------------------------|
          * | -1     | the value should be greater than zero|
          * -------------------------------------------------
          * 
          */
            //your code here

            if (number < 0)
            {
                Console.WriteLine("the value should be greater than zero");
            }

            else if (number % 2 == 0)
            {
                Console.WriteLine("odd");
            }
            else
            {
                Console.WriteLine("even");
            }
        }
               
            
            public void NumberDivideToFour(int number)
        {
            /* Exercise 2
        * using a ternary operator write a program that print if number divide to 4
        * Example: 
        * --------------------------------------------
        * |input   | result                          |
        * |--------|---------------------------------|
        * |  -4    | The number divide to 4          |
        * |--------|---------------------------------|
        * |   2    | The number doesn't divide to 4  |
        * --------------------------------------------
        */
            //your code here
            var result = (number % 4 == 0) ? "The number divide to 4" : "The number doesn't divide to 4";

            Console.WriteLine(result);
        }

        public void DayOfWeek(string day)
        {
            /* Exercise 3
             * using "switch" statement write a program that print the number of day of week
             * Example: monday - 1, tuesday - 2 etc. 
             * ---------------------------------------------------------
             * |day           |number                                  |
             * |--------------|----------------------------------------|
             * |monday        |   1                                    |
             * |tuesday       |   2                                    |
             * |wednesday     |   3                                    |
             * |thursday      |   4                                    |
             * |friday        |   5                                    |
             * |saturday      |   6                                    |
             * |sunday        |   7                                    |
             * |default value |Wrong value! Please give a day of a week|
             * ---------------------------------------------------------
             */

            switch (day)
            {
                case "Monday":
                    Console.WriteLine("1");
                    break;
                case "Tuesday":
                    Console.WriteLine("2");
                    break;
                case "Wednesday":
                    Console.WriteLine("3");
                    break;
                case "Thursday":
                    Console.WriteLine("4");
                    break;
                case "Friday":
                    Console.WriteLine("5");
                    break;
                case "Saturday":
                    Console.WriteLine("6");
                    break;
                case "Sunday":
                    Console.WriteLine("7");
                    break;
                default:
                    Console.WriteLine("Wrong value! Please give a day of a week");
                    break;
            }
        }
        public void CheckLetterIfVowel(char character)
        {
            /* Exercise 4
             * write a program that will print input character is a vowel, consonant or not a letter
             * Method 1: using a switch case
             * Method 2: using if
             * ---------------------------
             * |input| result            |
             * |-----|-------------------|
             * |  a  | a is a vowel      |
             * |  b  | b is a consonant  |
             * ---------------------------
             */

            /*Method 1: using a switch case
            switch (character)
            {
                case 'a':
                    Console.WriteLine(character + " is Vowel.");
                    break;
                case 'e':
                    Console.WriteLine(character + " is Vowel.");
                    break;
                case 'i':
                    Console.WriteLine(character + " is Vowel.");
                    break;
                case 'o':
                    Console.WriteLine(character + " is Vowel.");
                    break;
                case 'u':
                    Console.WriteLine(character + " is Vowel.");
                    break;

                default:
                    Console.WriteLine(character + " is Consonant.");
                    break;
            }
        } */

            //Method 2: using if
            if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
            {

                Console.WriteLine(character + " is Vowel.");

            }
            else if ((character >= 'a' && character <= 'z'))
            {
                Console.WriteLine(character + " is Consonant.");
            }

        }
        public static void Main(String[] args)
        {
         Homework homework = new Homework();

            homework.CheckIfNumberIsEvenOrOdd(-11);
            homework.CheckIfNumberIsEvenOrOdd(11);
            homework.CheckIfNumberIsEvenOrOdd(8);
            //---------------------------------------
            homework.NumberDivideToFour(10);
            homework.NumberDivideToFour(16);
            //---------------------------------------
            homework.DayOfWeek("Monday");
            homework.DayOfWeek("Sunday");
            homework.DayOfWeek("some day");
            //---------------------------------------
            homework.CheckLetterIfVowel('p');
            homework.CheckLetterIfVowel('i');

        }
    }
}
