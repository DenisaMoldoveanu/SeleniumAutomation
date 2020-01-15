using Exercises.Models;
using System.Collections.Generic;

namespace Exercises.Data
{
    public class QuizData
    {
        public static QuizModel GetFirstQuiz()
        {
            QuestionModel firstQuestion = new QuestionModel
            {
                QuestionName = @"Q1 - Which of the following access specifier in C# allows a class to hide its member variables  
and member functions from other class objects and functions, except a child class within the same application?",
                QuestionAnswers = new List<AnswerModel>
                {
                    new AnswerModel { IsCorrect = true, Text = "Protected Internal", Order = "A"},
                    new AnswerModel { IsCorrect = false, Text = "Private", Order = "B"},
                    new AnswerModel { IsCorrect = false, Text = "Internal", Order = "C"},
                    new AnswerModel { IsCorrect = false, Text = "Protected", Order = "D"},
                }
            };

            QuestionModel secondQuestion = new QuestionModel
            {
                QuestionName = @"Q2 - Which of the following is the correct about static member variables of a class?",
                QuestionAnswers = new List<AnswerModel>
                {
                    new AnswerModel { IsCorrect = false, Text = "We can define class members variables as static using the static keyword", Order = "A"},
                    new AnswerModel { IsCorrect = false, Text = @"When we declare a member of a class as static, it means no matter how
many objects of the class are created, there is only one copy of the static member" , Order = "B"},
                    new AnswerModel { IsCorrect = true, Text = "Both of the above", Order = "C"},
                    new AnswerModel { IsCorrect = false, Text = "None of the above", Order = "D"},
                }
            };

            QuestionModel thirdQuestion = new QuestionModel
            {
                QuestionName = "Q3 - Which of the following is the default access specifier of a class member variable?",
                QuestionAnswers = new List<AnswerModel>
                {
                    new AnswerModel { IsCorrect = false, Text = "Public", Order = "A"},
                    new AnswerModel { IsCorrect = true, Text = "Private", Order = "B"},
                    new AnswerModel { IsCorrect = false, Text = "Internal", Order = "C"},
                    new AnswerModel { IsCorrect = false, Text = "Protected", Order = "D"},
                }
            };

            QuizModel firstQuiz = new QuizModel
            {
                ListOfQuestions = new List<QuestionModel>
                {
                    firstQuestion, secondQuestion, thirdQuestion
                }
            };

            return firstQuiz;
        }
    }
}
