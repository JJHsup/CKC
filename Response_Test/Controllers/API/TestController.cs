using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;
using Response_Test.Models.QuestionModel;
using Response_Test.Service;

namespace Response_Test.Controllers.API
{
    [RoutePrefix("api/[Controller]/[action]")]
    public class TestController : ApiController
    {
        [HttpGet]
        public List<QuestionsModel> TestOne()
        {
            DataforTest question = new DataforTest();
            return question.TestOne();
        }
    }
}