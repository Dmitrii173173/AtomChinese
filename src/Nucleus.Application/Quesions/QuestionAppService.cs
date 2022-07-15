using Nucleus.Core.Questions;
using Nucleus.EntityFramework;
using System;
using System.Collections.Generic;
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
        public IEnumerable<Question> GetQuestions() 
        {
            return _dbContext.Questions;
        }
    }
}
