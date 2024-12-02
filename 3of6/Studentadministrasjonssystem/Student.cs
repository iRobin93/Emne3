using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjonssystem
{
    
    internal class Student        
    {
        private string _name;
        private int _age;
        private string _studyprogram;
        private string _studentId;
        public List<Fag> Fagliste;

        public Student(string name, int age, string studyprogram, string studentId)
        {
            _name = name;
            _age = age;
            _studyprogram = studyprogram;
            _studentId = studentId;
        }



        public void writeInfo()
        {
            Console.WriteLine($"Navn: {_name} \n Alder: {_age} \n Studentprogram: {_studyprogram} \n StudentId: {_studentId}");
        }

        public string GetName() 
        {
            return _name;
        }
        public double GetMean()
        {
            int count = 0;
            double SumKarakter = 0;
            double mean = 0;
            foreach(Karakter karakter in Karakter.karakterer)
            {
                if(karakter._student == this)
                {
                    count++;
                    SumKarakter += karakter._karakter;
                }            
            }
            mean = SumKarakter / count;
            return mean;
        }
        
    }
}
