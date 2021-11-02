using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMudBlazor.Interfaces;
using TestMudBlazor.Models;

namespace TestMudBlazor.Services
{
    public class AnswerService : IAnswerService
    {
        public List<Answer> GetAnswers(int questionsId)
        {
            try
            {
                List<Answer> result; 

                switch (questionsId)
                {
                    case 0:
                        result = new List<Answer>{ new Answer { Id = 0, IsTrue = false, Title = "Ответ на вопрос1" },
                                                   new Answer { Id = 1, IsTrue = false, Title = "Ответ на вопрос2" },
                                                   new Answer { Id = 2, IsTrue = true, Title = "Ответ на вопрос3" } };
                        break;

                    case 1:
                        result = new List<Answer>{ new Answer { Id = 3, IsTrue = false, Title = "Ответ на вопрос4" },
                                                   new Answer { Id = 4, IsTrue = false, Title = "Ответ на вопрос5" },
                                                   new Answer { Id = 5, IsTrue = true, Title = "Ответ на вопрос6" } };
                        break;

                    case 2:
                        result = new List<Answer>{ new Answer { Id = 6, IsTrue = true, Title = "Ответ на вопрос7" },
                                                   new Answer { Id = 7, IsTrue = false, Title = "Ответ на вопрос8" }};

                        break;

                    case 3:
                        result = new List<Answer>{ new Answer { Id = 8, IsTrue = false, Title = "Ответ на вопрос9" },
                                                   new Answer { Id = 9, IsTrue = false, Title = "Ответ на вопрос10" },
                                                   new Answer { Id = 10, IsTrue = true, Title = "Ответ на вопрос11" } };
                        break;

                    case 4:
                        result = new List<Answer>{ new Answer { Id = 11, IsTrue = true, Title = "Ответ на вопрос12" },
                                                   new Answer { Id = 12, IsTrue = false, Title = "Ответ на вопрос13" }};
                        break;

                    default:
                        result = new List<Answer>();
                        break;
                }

                return result;
            }
            catch(Exception ex)
            {
                throw new Exception($"GetAnswers error: {ex.Message}");
            }
        }
    }
}
