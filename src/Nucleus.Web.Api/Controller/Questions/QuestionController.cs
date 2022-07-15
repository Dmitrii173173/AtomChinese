using Microsoft.AspNetCore.Mvc;
using Nucleus.Application.Quesions;
using Nucleus.Application.Quesions.Dto;
using Nucleus.Web.Core.Controllers;
using System.Collections.Generic;

namespace Nucleus.Web.Api.Controller.Questions
{
    [Route("api/[controller]")]
    public class QuestionController : BaseController
    {
        private readonly IQuestionAppService _questionAppService;
        public QuestionController(IQuestionAppService questionAppService)
        {
            _questionAppService = questionAppService;
        }

        [HttpGet]
        public List<QuestionsListOutput> GetQuestions()
        {
            return _questionAppService.GetQuestions();
        }
    }
}
