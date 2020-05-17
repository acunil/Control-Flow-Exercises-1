using System;

namespace Control_Flow_Exercises_1
{
    class Exercises
    {
        /* 1- Write a program and ask the user to enter a number.
         * The number should be between 1 to 10.
         * If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid".
         * (This logic is used a lot in applications where values entered into input boxes need to be validated.)
         */
        public static void Exercise1()
        {
            Console.Write("Enter a number from 1 to 10: ");
            int num = Convert.ToInt16(Console.ReadLine());
            if (num >= 1 && num <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        // 2- Write a program which takes two numbers from the console and displays the maximum of the two.
        public static void Exercise2()
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Max is: " + (num1 > num2 ? num1 : num2));
        }

        // 3- Write a program and ask the user to enter the width and height of an image.
        // Then tell if the image is landscape or portrait.
        public static void Exercise3()
        {
            Console.Write("Enter width of image: ");
            int w = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter height of image: ");
            int h = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Image is " + (w > h ? "landscape" : "portrait"));

        }

        // 4- Your job is to write a program for a speed camera.
        // For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
        // Write a program that asks the user to enter the speed limit.
        // Once set, the program asks for the speed of a car.
        // If the user enters a value less than the speed limit, program should display "Ok" on the console.
        // If the value is above the speed limit, the program should calculate the number of demerit points.
        // For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
        // If the number of demerit points is above 12, the program should display License Suspended.
        public static void Exercise4()
        {
            Console.Write("Enter speed limit: ");
            int limit = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter speed of car: ");
            int car = Convert.ToInt16(Console.ReadLine());

            if (car < limit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                int points = (car - limit) / 5;

                if (points <= 12)
                {
                    Console.WriteLine("{0} points added to license", points);
                }
                else
                {
                    Console.WriteLine("License suspended");
                }
            }
        }
    }
}