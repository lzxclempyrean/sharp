using Lab_1.Logic;
using Lab_1.Models;
using Penkov_Lab_1.Logic;
using Penkov_Lab_1.Models;
using System;

internal class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        Console.WriteLine("Student info: " + student.ToShortString());
        Console.WriteLine("Is Education.Specialist: " + student[Education.Specialist]);
        Console.WriteLine("Is Education.Bachelor: " + student[Education.Bachelor]);
        Console.WriteLine("Is Education.SecondEducation: " + student[Education.SecondEducation]);

        student.Exams = new Exam[]
        {
                new Exam(),
                new Exam("Math", 4, DateTime.Now)
        };
        Console.WriteLine(student.ToString());

        student.AddExams(new Exam[]
        {
                new Exam(),
                new Exam(),
                new Exam()
        });

        Console.WriteLine(student.ToString());

        Exam[] oneDim = new Exam[10000];

        for (int i = 0; i < 10000; i++)
        {
            oneDim[i] = new Exam();
        }

        Exam[,] twoDim = new Exam[5000, 2];

        for (int i = 0; i < 5000; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                twoDim[i, j] = new Exam();
            }
        }

        Exam[][] sDim = new Exam[5000][];

        for (int i = 0; i < 5000; i++)
        {
            sDim[i] = new Exam[] { new Exam(), new Exam() };
        }

        CompareArrayTime<Exam> compareTime = new CompareArrayTime<Exam>();

        CompareArrayResult result = compareTime.CompareTime(oneDim, twoDim, sDim);

        Console.WriteLine($"One dimension time: {result.OneDimensionTime}\n" +
                          $"Two dimension time: {result.TwoDimensionTime}\n" +
                          $"Stair array time: {result.StairArrayTime}");
    }
}