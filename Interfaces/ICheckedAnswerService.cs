using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMudBlazor.Models;

namespace TestMudBlazor.Interfaces
{
    interface ICheckedAnswerService
    {
        int CountAnswers(int testId);
        CheckedAnswer GetCheckedAnswer(int questionId);
    }
}
