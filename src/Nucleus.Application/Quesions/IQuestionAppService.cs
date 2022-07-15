using Nucleus.Application.Quesions.Dto;
using Nucleus.Core.Questions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nucleus.Application.Quesions
{
    public interface IQuestionAppService
    {
        List<QuestionsListOutput> GetQuestions();
    }
}
