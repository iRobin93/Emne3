using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace QuizAppen
{
    internal class Quiz
    {

        private QuizTypeEnum _quizType;
        private List<QnA> _chosenQuestionList;
        private int _currentQuestionIndex;
        private int _points = 0;


        public Quiz(QuizTypeEnum quiztype)
        {

            _quizType = quiztype;
            switch (quiztype) 
            {
                case QuizTypeEnum.Geografi: _chosenQuestionList = QnA.GeoQuestionList;
                    break;
                case QuizTypeEnum.Sport: _chosenQuestionList = QnA.SportQuestionList;
                    break;
                case QuizTypeEnum.Historie: _chosenQuestionList = QnA.HistoryQuestionList;
                    break;
                default: _chosenQuestionList = QnA.GeoQuestionList;
                    break;
            }
            foreach (var question in _chosenQuestionList)
            {
                question.Answered = false;
            }
        }




        public void Question()
        {
            string question;
            Random random = new Random();
            int RandomNr;
            do
            {
                RandomNr = random.Next(0, _chosenQuestionList.Count);
                _currentQuestionIndex = RandomNr;
                question = _chosenQuestionList[RandomNr].GetQuestion();
            }
            while (question == null);
            
            Console.WriteLine(_chosenQuestionList[RandomNr].GetQuestion());
            Console.WriteLine("0: " + _chosenQuestionList[RandomNr].GetAlt0());
            Console.WriteLine("1: " + _chosenQuestionList[RandomNr].GetAlt1());
            Console.WriteLine("2: " + _chosenQuestionList[RandomNr].GetAlt2());
            Console.WriteLine("3: " + _chosenQuestionList[RandomNr].GetAlt3());
        }

        public bool CheckAnswer(char quizInput)
        {

            if (((int)quizInput - '0') == _chosenQuestionList[_currentQuestionIndex].GetAnswerIndex())
            {
                _points++;
                return true;
            }
            return false;
        }

        public int GetPoints()
        {
            return _points;
        }

        public bool IsAllAnswered()
        {
            
            foreach (var question in _chosenQuestionList) 
            {
                if (!question.Answered)
                    return false;
            }
            return true;
        }

    }
}
