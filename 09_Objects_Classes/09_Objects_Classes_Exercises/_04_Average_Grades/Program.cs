using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Average_Grades
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set;} 

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

            foreach (string student in excelentStudent)
            {
                double[] studentAverageGrades = studentGrades
                    .Where(x => x.Name == student && x.AverageGrade >= 5)
                    .Select(x => x.AverageGrade)
                    .OrderByDescending(x => x)
                    .ToArray();

                foreach (double studentGrade in studentAverageGrades)
                {
                    Console.WriteLine("{0} -> {1:f2}", student, studentGrade);
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
