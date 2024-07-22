using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalv2.Backend
{
    public class FormatoApi
    {

        public string Category { get; set; }
        public string Id { get; set; }
        public string CorrectAnswer { get; set; }
        public List<string> IncorrectAnswers { get; set; }
        public Question Question { get; set; }
        public List<string> Tags { get; set; }
        public string Type { get; set; }
        public string Difficulty { get; set; }
        public List<string> Regions { get; set; }
        public bool IsNiche { get; set; }

    }

    public class Question
    {
        public string Text { get; set; }
    }

}
