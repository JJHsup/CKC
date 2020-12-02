using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Response_Test.Helper;
using Response_Test.Repository;
using Response_Test.Models.QuestionModel;

namespace Response_Test.Service
{
    public class DataforTest
    {
        public List<QuestionsModel> TestOne()
        {
            List<string> receive = new List<string>();
            List<QuestionsModel> result = new List<QuestionsModel>();
            QuestionsModel itemmodel = new QuestionsModel();
            QuestionsHelper questions = new QuestionsHelper();
            CatchNowTester tester = new CatchNowTester();
            receive.AddRange(questions.ResultAll());
            receive.Add(tester.Name());
            Random random = new Random();
            for (int i = 1; i < 21; i++)
            {
                string item = receive[random.Next(1, receive.Count())];
                if (result.Where(x => x.Main == item).Any())
                {
                    i -= 1;
                }
                else
                {
                    if (questions.Result("Nature").Where(x => x == item).Any())
                    {
                        itemmodel = new QuestionsModel
                        {
                            Main = item,
                            KeybordCode = "65"
                        };
                        result.Add(itemmodel);
                    }
                    else if (questions.Result("Artificial").Where(x => x == item).Any())
                    {
                        itemmodel = new QuestionsModel
                        {
                            Main = item,
                            KeybordCode = "76"
                        };
                        result.Add(itemmodel);
                    }
                    else if (questions.Result("Color").Where(x => x == item).Any())
                    {
                        itemmodel = new QuestionsModel
                        {
                            Main = item,
                            KeybordCode = "76"
                        };
                        result.Add(itemmodel);
                    }
                    else
                    {
                        itemmodel = new QuestionsModel
                        {
                            Main = item,
                            KeybordCode = "65"
                        };
                        result.Add(itemmodel);
                    }
                }
            }
            return result;
        }
    }
}