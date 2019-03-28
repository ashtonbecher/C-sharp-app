using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03
{
    public class Student
    {
        public string StudentName { get; set; }
        public string StudentID { get; set; }
        public Int32 MidtermGrade { get; set; }
        public Int32 FinalGrade { get; set; }

        public Student()
        {
        }

        public Student(string studentName, string studentID, Int32 midtermGrade, Int32 finalGrade)
        {
            StudentName = studentName;
            StudentID = studentID;
            MidtermGrade = midtermGrade;
            FinalGrade = finalGrade;
        }

        public string CalcLetterGrade()
        {
            int grade = (MidtermGrade + FinalGrade) / 2;
            string letter = "";

            string[] letterGrade = { "A", "B", "C", "D", "F" };
            int[] gradeScale = { 90, 80, 70, 60, 50 };

            for (int i = 0; i < gradeScale.Length - 1; i++)
            {
                if (grade >= gradeScale[i])
                {
                    letter = letterGrade[i];
                    return letter;
                }
            }

            return "F";
        }

        public string DisplayStudentInfo()
        {
            return StudentID + "\t" + StudentName;
        }

        public string DisplayStudentInfo(int spaces)
        {
            int n1 = StudentName.Length + spaces;
            int n2 = StudentID.Length + spaces;
            int n3 = CalcLetterGrade().Length + spaces;

            return StudentName.PadRight(n1) + StudentID.PadRight(n2) + CalcLetterGrade().PadRight(n3);
        }
    }
}
