using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMudBlazor.Interfaces;
using TestMudBlazor.Models;

namespace TestMudBlazor.Services
{
    public class TestService : ITestService
    {
        public Test GetTest(int testId)
        {
            try
            {
                return new Test { Id = 0, Title = "Наименование теста" };
            }
            catch (Exception ex)
            {
                throw new Exception($"GetTest error: {ex.Message}");
            }
        }
    }
}
