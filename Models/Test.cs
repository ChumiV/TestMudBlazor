using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestMudBlazor.Models
{
    public class Test
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public List<Question> Questions { set; get; }

        public Test()
        {
            Questions = new List<Question>();
        }
    }
}
