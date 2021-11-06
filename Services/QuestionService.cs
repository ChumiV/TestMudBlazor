using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMudBlazor.Interfaces;
using TestMudBlazor.Models;

namespace TestMudBlazor.Services
{
    public class QuestionService : IQuestionService
    {
        public List<Question> GetQuestions(int testId)
        {
            try
            {
                return new List<Question> { new Question { Id = 0, Title = "Тестовый текст вопроса", Image = "/image/1.jpg", Note = "Тестовая заметка"},
                                            new Question { Id = 1, Title = "Тестовый текст вопроса1", Image = "/image/2.jpg", Note = "Тестовая заметка"},
                                            new Question { Id = 2, Title = "Тестовый текст вопроса2", Image = "/image/3.jpg", Note = "Тестовая заметка"},
                                            new Question { Id = 3, Title = "Тестовый текст вопроса3", Image = "/image/4.jpg", Note = "Тестовая заметка"},
                                            new Question { Id = 4, Title = "Тестовый текст вопроса4", Image = "/image/5.jpg", Note = "Тестовая заметка"}};
            }
            catch(Exception ex)
            {
                throw new Exception($"GetQuestions error: {ex.Message}");
            }
        }
    }
}
