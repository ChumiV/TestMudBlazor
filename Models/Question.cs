using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestMudBlazor.Models
{
    public class Question
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public string Image { set; get; }
        public string Note { set; get; }
        public List<Answer> Answers { set; get; }

        public Question()
        {
            Answers = new List<Answer>();
        }
    }
}
