using Nucleus.Core.Questions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nucleus.Application.Quesions
{
    public interface IQuestionAppService
    {
        IEnumerable<Question> GetQuestions();
    }
}
