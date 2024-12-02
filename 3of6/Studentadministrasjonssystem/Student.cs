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



    }
}
