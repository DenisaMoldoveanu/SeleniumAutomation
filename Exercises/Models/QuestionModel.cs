using System.Collections.Generic;

namespace Exercises.Models
{
    public class QuestionModel
    {
        public string QuestionName { get; set; }
        public List<AnswerModel> QuestionAnswers { get; set; }
    }
}
