using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace C03
{
    public static class StudentDB
    {

        private const string directory = @"..\..\";
        private const string path = directory + "Students.txt";

        public static List<Student> GetStudents()
        {
            FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(fileStream);

            List<Student> students = new List<Student>();
            while(reader.Peek() != -1)
            {
                string record = reader.ReadLine();
                string[] fields = record.Split(',');

                Student s = new Student();
                s.StudentID = fields[0];
                s.StudentName = fields[1];
                s.MidtermGrade = Convert.ToInt32(fields[2]);
                s.FinalGrade = Convert.ToInt32(fields[3]);

                students.Add(s);
            }
            reader.Close();
            return students;
        }

        public static void SaveStudents(List<Student> students)
        {
            FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fileStream);
            foreach (Student s in students)
            {
                writer.WriteLine(s.StudentID + "," + s.StudentName + "," + s.MidtermGrade + "," + s.FinalGrade);
            }

            writer.Close();
        }
    }
}
