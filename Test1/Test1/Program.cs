using System;
using System.Collections.Generic;
using System.Text;



namespace Test1
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Thank you very for using this code sample - coded by Anuraj Hemantha");
            Console.WriteLine("Please use any grater number than 100 to quit this programe");
            Console.WriteLine("");

            for (int i = 1; i < 101; i++)
            {

                //Console.WriteLine("Please input a value");
                int intValue = Convert.ToInt32(Console.ReadLine());
                if (intValue > 100)
                {
                    System.Environment.Exit(1);
                }
                Console.WriteLine(Program.CalculateValue(intValue));

            }

        }

        public static string CalculateValue(int intValue)
        {
            string strAnswer = string.Empty;
            int intAnswerBy3 = 0;
            int intAnswerBy5 = 0;

            intAnswerBy3 = intValue % 3;
            intAnswerBy5 = intValue % 5;

            if (intAnswerBy3 == 0)
            {
                if (intAnswerBy5 == 0)
                {
                    strAnswer = "ModernMedical";
                }
                else if (intAnswerBy5 < 5 || intAnswerBy5 == intValue)
                {
                    strAnswer = "Modern";
                }

            }
            else if (intAnswerBy3 < 3 || intAnswerBy3 == intValue)
            {
                if (intAnswerBy5 == 0)
                {
                    strAnswer = "Medical";
                }
                else if (intAnswerBy5 < 5 || intAnswerBy5 == intValue)
                {
                    strAnswer = Convert.ToString(intValue);
                }
            }
            else if (intAnswerBy5 == 0)
            {
                strAnswer = "Medical";
            }
            else if (intAnswerBy5 == 0 || intAnswerBy5 == intValue)
            {
                strAnswer = Convert.ToString(intValue);
            }

            return strAnswer;
        }
    }
}
