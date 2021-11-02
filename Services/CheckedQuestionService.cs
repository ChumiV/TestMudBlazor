using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMudBlazor.Interfaces;
using TestMudBlazor.Models;

namespace TestMudBlazor.Services
{
    public class CheckedQuestionService : ICheckedQuestionsService
    {
        public CheckedQuestion GetCheckedQuestion(int questionId)
        {
            try
            {
                CheckedQuestion result;

                switch (questionId)
                {
                    case 1:
                        result = new CheckedQuestion { Id = 0, QuestuionId = 1, AnswerId = 5 };
                        break;

                    case 4:
                        result = new CheckedQuestion { Id = 1, QuestuionId = 4, AnswerId = 12 };
                        break;

                    default:
                        result = null;
                        break;
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception($"GetCheckedQuestion error: {ex.Message}");
            }
        }
    }
}
