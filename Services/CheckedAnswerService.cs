using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMudBlazor.Interfaces;
using TestMudBlazor.Models;

namespace TestMudBlazor.Services
{
    public class CheckedAnswerService : ICheckedAnswerService
    {
        public int CountAnswers(int testId)
        {
            return 2;
        }

        public CheckedAnswer GetCheckedAnswer(int questionId)
        {
            try
            {
                CheckedAnswer result;

                switch (questionId)
                {
                    case 1:
                        result = new CheckedAnswer { Id = 0, QuestuionId = 1, AnswerId = 5 };
                        break;

                    case 4:
                        result = new CheckedAnswer { Id = 1, QuestuionId = 4, AnswerId = 12 };
                        break;

                    default:
                        result = null;
                        break;
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception($"GetCheckedAnswer error: {ex.Message}");
            }
        }
    }
}
