using System;

namespace InclassGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your grades you got in the class");
            try
            {
                string input = Console.ReadLine();
                int grades = int.Parse(input);

                Console.WriteLine("Your letter grade is " + Letter_Grade(grades));

               


                // exit statement
                Console.WriteLine("Press any key to exit");
                Console.ReadKey(true);
            }
            catch
            {

            }// end of catch
           
        }
        private static string Letter_Grade(int get_grades)
        {
            string LetterGrade = "";
            if (get_grades > 0 && get_grades <= 60)
            {
                LetterGrade = "F";


            }
            else if (get_grades > 60 && get_grades <= 63)
            {
                LetterGrade = "D";
            }
            else if (get_grades > 63 && get_grades <= 67)
            {
                LetterGrade = "D+";
            }
            else if (get_grades > 67 && get_grades <= 70)
            {
                LetterGrade = "C-";
            }
            else if (get_grades > 70 && get_grades <= 74)
            {
                LetterGrade = "C";
            }
            else if (get_grades > 74 && get_grades <= 77)
            {
                LetterGrade = "C+";
            }
            else if (get_grades > 77 && get_grades <= 80)
            {
                LetterGrade = "B-";
            }
            else if (get_grades > 80 && get_grades <= 84)
            {
                LetterGrade = "B";
            }
            else if (get_grades > 84 && get_grades <= 87)
            {
                LetterGrade = "B+";
            }
            else if (get_grades > 87 && get_grades <= 90)
            {
                LetterGrade = "A-";
            }
            else if (get_grades > 90 && get_grades <= 94)
            {
                LetterGrade = "A";
            }
            else if (get_grades > 94 && get_grades <= 100)
            {
                LetterGrade = "A+";
            }
            return LetterGrade;
        }
    }
}
