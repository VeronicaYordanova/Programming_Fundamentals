using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _08_Average_Grades
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }

        public double AverageGrade
        {
            get
            {
                return (double)Grades.Average();
            }
        }
    }

    public class AverageGrades
    {
        static void Main(string[] args)
        {
            Student[] studentGrades = GetStudentGrades();
            string[] excelentStudent = studentGrades
                .Where(x => x.AverageGrade >= 5)
                .Select(x => x.Name).Distinct()
                .OrderBy(x => x)
                .ToArray();


            File.WriteAllText("output.txt", string.Empty);

            foreach (string student in excelentStudent)
            {
                double[] studentAverageGrades = studentGrades
                    .Where(x => x.Name == student && x.AverageGrade >= 5)
                    .Select(x => x.AverageGrade)
                    .OrderByDescending(x => x)
                    .ToArray();


                foreach (double studentGrade in studentAverageGrades)
                {
                    // File.AppendAllText("output.txt", $"{0} -> {1:f2}", student, studentGrade);
                    File.AppendAllText("output.txt", $"{student} -> {studentGrade:f2}{Environment.NewLine}");
                }
            }

        }

        private static Student[] GetStudentGrades()
        {
            int n = int.Parse(Console.ReadLine());
            Student[] grades = new Student[n];
            for (int i = 0; i < n; i++)
            {
                List<double> studentGrades = new List<double>();
                string[] dataStudent = Console.ReadLine()
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 1; j < dataStudent.Length; j++)
                    studentGrades.Add(double.Parse(dataStudent[j]));
                grades[i] = new Student()
                {
                    Name = dataStudent[0],
                    Grades = studentGrades
                };
            }
            return grades;
        }
    }
}
