using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAppen
{
    internal class QnA
    {
        public static List<QnA> GeoQuestionList = new List<QnA>()
        {
            new QnA ("Hva er hovedstaden i Norge?", "Bergen", "Stavanger","Oslo",  "Kristiania" , 2),
            new QnA ("Hva er hovedstaden i Danmark?","Vejle","København",  "Aalborg", "Aarhus", 1),
            new QnA ("Hva er hovedstaden i Finland?","Rovanjemi","Åbo",  "Helsinki", "Borgå", 2),
        };

        public static List<QnA> SportQuestionList = new List<QnA>()
        {
            new QnA ("Hva slags sport spiller Viktor Hovland?", "Golf", "Fotball", "Håndball", "Ishockey" , 0)
        };


        public static List<QnA> HistoryQuestionList = new List<QnA>()
        {
            new QnA ("Når ble Norges grunnlov laget?", "1810", "1817", "1804", "1814" , 3)
        };

        private string _question;
        private string[] _alts = new string[4];
        private int _answerIndex;
        public bool Answered = false;



        public QnA(string Question, string alt0, string alt1, string alt2, string alt3, int answerIndex)
        {
            _question = Question;
            _alts[0] = alt0;
            _alts[1] = alt1;
            _alts[2] = alt2;
            _alts[3] = alt3;
            _answerIndex = answerIndex;
        }

        public string GetQuestion()
        {
            if (Answered)
            {
                return null;
            }
            else
                return _question;
        }


        public string GetAlt0() 
        {
            return _alts[0];
        }

        public string GetAlt1() 
        {
            return _alts[1];
        }

        public string GetAlt2()
        {
            return _alts[2];
        }

        public string GetAlt3()
        {
            return _alts[3];
        }

        public int GetAnswerIndex()
        {
            Answered = true;
            return _answerIndex;
        }
    }
}
