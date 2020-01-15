using Exercises.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Data
{
    public class QuizData
    {
        public static QuizModel GetFirstQuiz()
        {
            QuestionModel firstQuestion = new QuestionModel
            {
                QuestionName = "",
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
                QuestionName = "",
                QuestionAnswers = new List<AnswerModel>
                {
                    new AnswerModel { IsCorrect = false, Text = "", Order = "A"},
                    new AnswerModel { IsCorrect = false, Text = "", Order = "B"},
                    new AnswerModel { IsCorrect = true, Text = "", Order = "C"},
                    new AnswerModel { IsCorrect = false, Text = "", Order = "D"},
                }
            };

            QuestionModel thirsQuestion = new QuestionModel
            {
                QuestionName = "",
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
                    firstQuestion, secondQuestion, thirsQuestion
                }
            };

            return firstQuiz;
        }
    }
}
