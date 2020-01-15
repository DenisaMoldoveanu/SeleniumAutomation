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
            #region tema sesiunea 1
            //get student.FullName
            Console.WriteLine("Please enter you first and last name");
            string studentFullName = Console.ReadLine();

            //using FullName, get First Name and Last Name
            StudentModel student = new StudentModel { FullName = studentFullName };
            StudentServices studentServices = new StudentServices();

            studentServices.GetStudentFirstName(student);

            //enter course
            Console.WriteLine("Enter course name: ");
            string courseName = Console.ReadLine();

            CourseModel course = new CourseModel { Name = courseName };

            //enter teacher
            Console.WriteLine("Please enter teacher name:");
            string teacherName = Console.ReadLine();

            //associate course to teacher
            TeacherModel teacher = new TeacherModel
            {
                FullName = teacherName,
                ListOfCourses = new List<CourseModel> { course }
            };
            #endregion

            #region exercitiu sesiunea 2
            //take quiz
            var quiz = QuizData.GetFirstQuiz();
            int rightAnswers = 0;

            Console.WriteLine();
            Console.WriteLine("Plese take the following quiz");

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

                if (isTheCorrectAnswer) rightAnswers++;

            }
            #endregion

            //get grade
            double score = 0;
            try
            {
                score = Math.Round((double)(rightAnswers * 10) / quiz.ListOfQuestions.Count);
            }
            catch (DivideByZeroException) { }
            student.Grade = score;

            //print out student information
            Console.WriteLine();
            Console.WriteLine(@"Final grade: {0}
Student: {1}
Course: {2}
Teacher: {3}", student.Grade, student.FullName, course.Name, teacher.FullName);
        }
    }
}
