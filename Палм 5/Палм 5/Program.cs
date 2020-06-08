using System;
using System.IO;

namespace struct_lab_student
{
    partial class Program
    {
        static Student[] ReadData(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);
            Student[] students = new Student[lines.Length];
            for (var i = 0; i < lines.Length; i++)
            {
                students[i] = new Student(lines[i]);
            }
            return students;

        }

        static void runMenu(Student[] studs)
        {
            string path = @"C:\Users\Admin\source\repos\Палм 5\Палм 5\bin\Debug\netcoreapp3.1\data_new.txt";
            foreach (var stud in studs)
            {
                if (stud.mathematicsMark == '2' || stud.physicsMark == '2' || stud.informaticsMark == '2')
                {
                    using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
                    {
                        sw.Write("fname: {0}; marks: {1} {2} {3} 0\n", stud.firstName, stud.informaticsMark, stud.mathematicsMark, stud.physicsMark);
                    }
                    Console.WriteLine("fname: {0}; marks: {1} {2} {3} 0", stud.firstName, stud.informaticsMark, stud.mathematicsMark, stud.physicsMark);
                }

            }
        }
        static void Main(string[] args)
        {
            Student[] studs = ReadData("input.txt");
            runMenu(studs);
        }
    }
}