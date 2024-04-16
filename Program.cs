using static System.Net.Mime.MediaTypeNames;

namespace Lecture4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Question6();
            Console.ReadKey();
        } // main

        public static void Question6()
        {
            // Write a program that prompts the user to input a length expressed in centimeters. The program should then convert the length to inches (to the nearest inch) and output the length expressed in yards, feet, and inches, in that order. For example, suppose the input for centimeters is 312. To the nearest inch, 312 centimeters is equal to 123 inches. 123 inches would thus be output as: 3 yard(s), 1 feet(foot), and 3 inch(es).

            // 1. Ask user for length in centimeters
            int centimeters = 0;
            try
            {
                Console.Write("Enter a length in centimeters: ");
                string userInput = Console.ReadLine();
                centimeters = int.Parse(userInput);
                // 1b. Wrap in a try / catch
            }
            catch
            {
                Console.WriteLine("Your value was an invalid format");
            }




            // 2. Convert user's length to inches
            double convertedToInches = Math.Round(centimeters / 2.54);
            // 2a. Get the conversion

            // 3. Convert to yards, feet, and inches
            int inchesInYard = 36;
            // Getting whole number of yards
            int yards = (int)convertedToInches / inchesInYard;

            // Getting remaining inches
            convertedToInches %= inchesInYard;

            // Getting the inches 
            int inchesInFoot = 12;
            int feet = (int)convertedToInches / inchesInFoot;

            // Get remaining inches
            convertedToInches %= inchesInFoot;
            int inches = (int)convertedToInches;

            // 3 yard(s), 1 feet(foot), and 3 inch(es).
            Console.WriteLine($"{yards} yard(s), {feet} feet (foot), and {inches} inch(es).");

            // 4. Display
        }// Question 6

        public static void FloatingPointTypeExample()
        {
            // ---------------------------
            // Floating Point Types ( float and double )
            // Precision and Memory
            // Decimal Type
            // ---------------------------

            // A floating point type is a number that has a decimal
            // Float type - Single Precision type
            // We need to be explicit when we declare a float value by putting f after our value
            float floatValue = 1.2f;

            // Double type - Double Precision 
            double doubleValue = 1.2;

            // Decimal type - has the largest range, highest precision, and highest memory cost (16 bit)
            // Need to put m after our value
            decimal decimalValue = 1.23456m;


            // If you ever get the error: "Cannot work with X type, please convert to string"
            // To convert to string, you can call the .ToString() on any object
            Console.WriteLine(doubleValue.ToString());

        } //FloatingPointTypeExample()

        public static void MathManipulation()
        {

            // Revisit Parsing

            //Console.Write("Empty number 1: ");
            //string userString1 = Console.ReadLine();

            //Console.Write("Empty number 2: ");
            //string userString2 = Console.ReadLine();

            // Converting string to number: Parse the string into a number

            //try
            //{
            //    double userNumber1 = double.Parse(userString1);
            //    double userNumber2 = double.Parse(userString2);
            //    double sum = userNumber1 + userNumber2;
            //    Console.WriteLine(sum);
            //}
            //catch
            //{
            //    Console.WriteLine("The number was invalid");
            //};

            // Casting 
            // Implicit casting (It will automatically happen)
            //double number1 = 1;

            // An int will never have a decimal point
            // Explicitly cast
            // We have to give permission to lose data
            // We cast by putting the type we want to convert to in parentheses in front of our data.
            //int number2 = (int)1.0324234;

            // Math with Doubles
            //int number1 = 10;
           // double number2 = 3;
            // You can either do (double)3 or 3.0 to let the computer look at it as a double
            //double result = (double)(10 / 3);
            //Console.WriteLine(result);

            // Rounding
            // Math Library with the keyword...Math
            double numberToRound = 1.45374;
            // We can have it in decimals by putting a number after "numberToRound,"
            double roundedNumber = Math.Round(numberToRound, 2);
            // .ToString() converts a value into a string
            // Pass in an argument that formats the value 
            // "c" format will display the currency symbol and round the value to 2 decimal places (double check for precision)
            Console.WriteLine(roundedNumber.ToString("c"));


        } // MathManipulation()

        public static void TryCatchExample()
        {
            // Shortcuts to comment and uncomment code: ctrl + k, c
            // To uncomment, ctrl + k, u

            // If we try to parse a string into a different type, and the type is invalid, you will receive a FormatException error
            // Runtime error
            // try / catch 
            // To use a try catch, you declare a try block, followed by a catch block.

            // Try catch always has to be grouped together

            Console.Write("Enter a number: ");
            double userNumber = 0;
            try
            {
                userNumber = double.Parse(Console.ReadLine());
                Console.WriteLine($"The user's number is {userNumber}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("The number you entered was invalid");
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("After our try catch block");

            // Console ReadKey waits for a single button input before moving on
            // This can help prevent your console from closing automatically
            Console.ReadKey();

        } // TryCatchExample()

        public static void HomeworkExamples()
        {
            // ---------------------------
            // Question Examples
            // Homework
            // ----------------------------

             

        } // HomeworkExamples()

    } // class
} // namespace
