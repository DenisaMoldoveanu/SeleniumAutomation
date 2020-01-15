using Exercises.Data;
using Exercises.Models;
using Exercises.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //get student full name
            Console.WriteLine("Please enter your first and last name: ");
            string studentFullName = Console.ReadLine();

            //using FullName, get first and last name
            StudentModel student = new StudentModel { FullName = studentFullName };
            StudentServices studentServices = new StudentServices();

            studentServices.GetStudentFirstName(student);

            //enter course
            Console.WriteLine("Enter course name: ");
            string courseName = Console.ReadLine();

            CourseModel course = new CourseModel { Name = courseName };

            //enter teacher
            Console.WriteLine("Enter teacher name: ");
            string teacherName = Console.ReadLine();

            //associate course to teacher
            TeacherModel teacher = new TeacherModel
            {
                FullName = teacherName,
                ListOfCourses = new List<CourseModel> { course }
            };

            //take quiz
            var quiz = QuizData.GetFirstQuiz();
            int rightAnswers = 0;

            Console.WriteLine();
            Console.WriteLine("Please take the following quiz ");

            for (int i = 0; i < quiz.ListOfQuestions.Count; i++)
            {
                Console.WriteLine(quiz.ListOfQuestions[i].QuestionName);
                Console.WriteLine();

                for (int j = 0; j < quiz.ListOfQuestions[i].QuestionAnswers.Count; j++)
                {
                    Console.WriteLine(quiz.ListOfQuestions[i].QuestionAnswers[j].Order + "." + 
                        quiz.ListOfQuestions[i].QuestionAnswers[j].Text);
                }

                string answer = Console.ReadLine();
                Console.WriteLine();

                var isTheCorrectAnswer = quiz.ListOfQuestions[i].QuestionAnswers.FirstOrDefault(
                    x => x.Order.ToLower() == answer.ToLower()).IsCorrect;

                if (isTheCorrectAnswer)
                    rightAnswers++;
            }



        }
    }
}
