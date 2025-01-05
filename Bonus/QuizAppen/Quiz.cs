using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAppen
{
    internal class Quiz
    {

        private QuizTypeEnum _quizType;
        private List<string> _questions;
        public Quiz(QuizTypeEnum quiztype)
        {
            _quizType = quiztype;
        }

        public void Question()
        {
            
        }
    }
}
