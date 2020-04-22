using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace WPF_QuizApp
{
    public class Question
    {
        public int id { get; set; }
        public string qText { get; set; }

        public string qType { get; set; }
        public string image { get; set; }
        public List<Answer> answers { get; set; }

        //Constructor
        public Question()
        {
            answers = new List<Answer>();
        }
    }

    public class Answer
    {
        public string aText { get; set; }
        public bool isCorrect { get; set; }
    }
}