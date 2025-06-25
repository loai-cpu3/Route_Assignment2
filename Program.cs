using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route_Assignment2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            #region Q1

            Console.WriteLine("Enter a Number");
            bool isValid = int.TryParse(Console.ReadLine(), out int number);
            if (isValid)
            {
                Console.WriteLine($"the number = {number}");
            } else
            {
                Console.WriteLine("Invalid input.");
            }


            Console.WriteLine(number);
            #endregion

            #region Q2


            string s = "123A";
            //int result = Convert.ToInt32(s);

            // This will throw Format exception because "123A" is not a valid integer. 
            #endregion

            #region Q3
            Console.WriteLine(10.5 / 2);
            // This will output 5.25

            #endregion

            #region Q4

            string s2 = "mango";
            Console.WriteLine(s2.Substring(0, 3));
            #endregion

            #region Q5

            int var1 = 10;
            int var2 = var1;

            var2 = 20; // This will not change var1, as var2 is a copy of var1. 
            #endregion

            #region Q6
            Point point = new Point();
            point.X = 10;
            point.Y = 20;

            Point point2 = point;

            point2.X = 30; // This will change point.X to 30, as point2 is a reference to the same object.

            Console.WriteLine($"point.X = {point.X}, point.Y = {point.Y}");


            #endregion

            #region Q7
            string s3 = "loai";
            string s4 = "abdelazeem";
            string s5 = $"{s3} {s4}";
            Console.WriteLine(s5);
            #endregion

            #region Q8
            Console.WriteLine("Enter the Principal Amount");
            bool isPrincipalValid = double.TryParse(Console.ReadLine(), out double principal);
            Console.WriteLine("Enter the Interest rate");
            bool isIntrestValid = double.TryParse(Console.ReadLine(), out double rate);
            Console.WriteLine("Enter the Time in years");
            bool isTimeValid = double.TryParse(Console.ReadLine(), out double time);
            if (!(isPrincipalValid || isIntrestValid || isTimeValid))
            {
                Console.WriteLine("There is Invalid Input");
            }
            else
            {
                double simpleInterest = (principal * rate * time) / 100;
                Console.WriteLine($"The Simple Interest is: {simpleInterest}");
            }

            #endregion

            #region Q9

            Console.WriteLine("Enter your Weight");
            bool isWeightValid = double.TryParse(Console.ReadLine(), out double weight);
            Console.WriteLine("Enter your Height in meters");
            bool isHeightValid = double.TryParse(Console.ReadLine(), out double height);
            if (!(isWeightValid || isHeightValid))
            {
                Console.WriteLine("There is Invalid Input");
            }
            else
            {
                double bmi = weight / (height * height);
                Console.WriteLine($"Your BMI is: {bmi}");
            }
            #endregion

            #region Q10

            float temperature = 25F;
            string result = temperature > 30 ? "Just Hot" : temperature < 10 ? "Just Cold" : "Just Good";
            Console.WriteLine(result);
            #endregion

            #region Q11
            Console.WriteLine("Enter the day:");
            bool isDayValid = int.TryParse(Console.ReadLine(), out int day);
            Console.WriteLine("Enter the month:");
            bool isMonthValid = int.TryParse(Console.ReadLine(), out int month);
            Console.WriteLine("Enter the year:");
            bool isYearValid = int.TryParse(Console.ReadLine(), out int year);

            if (!(isDayValid && isMonthValid && isYearValid))
            {
                Console.WriteLine("Invalid input for date.");
            }
            else if (day < 1 || day > 31 || month < 1 || month > 12 || year < 1)
            {
                Console.WriteLine("Invalid date.");
            }
            else
            {
                Console.WriteLine($"Today's date : {day} , {month} , {year}");
                Console.WriteLine($"Today's date : {day} / {month} / {year}");
                Console.WriteLine($"Today's date : {day} – {month} – {year}");
            }
            #endregion

            #region Q12
            Console.WriteLine("Enter Number");
            bool isNumberValid = int.TryParse(Console.ReadLine(), out int number2);
            if (isNumberValid)
            {
                if (number2 % 4 == 0 && number2 % 3 == 0)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for number.");
            }

            #endregion

            #region Q13
            Console.WriteLine("Enter an integer:");
            bool isIntValid = int.TryParse(Console.ReadLine(), out int userInput);
            if (isIntValid)
            {
                if (userInput < 0)
                {
                    Console.WriteLine("negative");
                }
                else
                {
                    Console.WriteLine("positive");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

            #endregion

            #region Q14
            Console.WriteLine("Enter The First Number");
            bool isFirstNumberValid = int.TryParse(Console.ReadLine(), out int firstNumber);
            Console.WriteLine("Enter The Second Number");
            bool isSecondNumberValid = int.TryParse(Console.ReadLine(), out int secondNumber);
            Console.WriteLine("Enter The Third Number");
            bool isThirdNumberValid = int.TryParse(Console.ReadLine(), out int thirdNumber);
            if (!(isFirstNumberValid && isSecondNumberValid && isThirdNumberValid))
            {
                Console.WriteLine("Invalid input for numbers.");
            }
            else
            {
                int max = firstNumber > secondNumber ? firstNumber : secondNumber > thirdNumber ? secondNumber : thirdNumber;
                Console.WriteLine($"Max element = {max}");
                int min = firstNumber < secondNumber ? firstNumber : secondNumber < thirdNumber ? secondNumber : thirdNumber;
                Console.WriteLine($"Min element = {min}");

            }

            #endregion

            #region Q15
            Console.WriteLine("Enter a Number");

            bool isNumber4Valid = int.TryParse(Console.ReadLine(), out int number4);
            if (isNumber4Valid)
            {
                if (number4 % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Odd");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for number.");
            }

            #endregion

            #region Q16

            Console.WriteLine("Enter a character ");
            bool isCharValid = char.TryParse(Console.ReadLine(), out char character);
            if (isCharValid)
            {
                if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u') { 
                    Console.WriteLine("Vowel");
                }
                else 
                {
                    Console.WriteLine("Consonant");
                }
           
            }
            else
            {
                Console.WriteLine("Invalid input for character.");
            }
            #endregion

            #region Q17
            Console.WriteLine("Enter Month Number:");
            bool isMonthNumValid = int.TryParse(Console.ReadLine(), out int monthNum);
            if (!isMonthNumValid || monthNum < 1 || monthNum > 12)
            {
                Console.WriteLine("Invalid month number.");
            }
            else
            {
                int daysInMonth;
                switch (monthNum)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        daysInMonth = 31;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        daysInMonth = 30;
                        break;
                    case 2:
                        daysInMonth = 28;
                        break;
                    default:
                        daysInMonth = 0;
                        break;
                }
                Console.WriteLine($"Days in Month : {daysInMonth}");
            }

            #endregion
        }
    }
}
