using Nucleus.Application.Quesions.Dto;
using Nucleus.Core.Questions;
using Nucleus.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nucleus.Application.Quesions
{
    public class QuestionAppService : IQuestionAppService
    {
        private readonly NucleusDbContext _dbContext;
        public QuestionAppService(NucleusDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<QuestionsListOutput> GetQuestions() 
        {
            return _dbContext.Questions.Select(x => new QuestionsListOutput()
            {
                Text = x.Text,
                CreationDate = x.CreationDate,
            }).ToList();
        }
    }
}
